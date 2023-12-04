using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Reactive;
using System.Reactive.Concurrency;
using System.Reactive.Linq;
using System.Reactive.Subjects;
using System.Threading.Tasks;
using Appmilla.Xamarin.Infrastructure.Reactive;
using Appmilla.Xamarin.Infrastructure.Extensions;
using Appmilla.Xamarin.Infrastructure.Utilities;
using Appmilla.Yapily.Refit.Database;
using Appmilla.Yapily.Refit.Models;
using Appmilla.Yapily.Refit.Queries;
using Appmilla.Yapily.Refit.Storage;
using DynamicData;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using Xamarin.Essentials.Interfaces;

namespace Appmilla.Yapily.Refit.Caches
{
    public class ConnectedInstitutionsRefreshed
    { }
    
    public class ConnectedInstitutionsLoaded
    { }
    
    public class ConnectedInstitutionsDataError
    { }
    
    public interface IConnectedInstitutionsCache
    {
        SourceCache<ConnectedInstitution, string> ConnectedInstitutions { get; }
          
        ReactiveCommand<Unit, ApiListResponseOfConsent> Load { get; }

        ReactiveCommand<Unit, ApiListResponseOfConsent> Refresh { get; }
        
        void Clear();
        
        IObservable<ConnectedInstitutionsLoaded> ConnectedInstitutionsLoadedNotifications { get; }
        
        IObservable<ConnectedInstitutionsRefreshed> ConnectedInstitutionsRefreshedNotifications { get; }
        
        IObservable<ConnectedInstitutionsDataError> ConnectedInstitutionsDataErrorNotifications { get; }
    }
    
    public class ConnectedInstitutionsCache : ReactiveObject, IConnectedInstitutionsCache
    {
        readonly ISchedulerProvider _schedulerProvider;
        readonly IConsentsQuery _consentsQuery;
        readonly ISecureStorage _secureStorage;
        
        readonly Subject<ConnectedInstitutionsLoaded> _connectedInstitutionsLoadedNotifications;
        readonly Subject<ConnectedInstitutionsRefreshed> _connectedInstitutionsRefreshedNotifications;
        readonly Subject<ConnectedInstitutionsDataError> _connectedInstitutionsDataErrorNotifications;

        public IObservable<ConnectedInstitutionsLoaded> ConnectedInstitutionsLoadedNotifications => _connectedInstitutionsLoadedNotifications;
        public IObservable<ConnectedInstitutionsRefreshed> ConnectedInstitutionsRefreshedNotifications => _connectedInstitutionsRefreshedNotifications;
        public IObservable<ConnectedInstitutionsDataError> ConnectedInstitutionsDataErrorNotifications => _connectedInstitutionsDataErrorNotifications;
        
        private static readonly Func<ConnectedInstitution, string> KeySelector = connectedInstitution => connectedInstitution.InstitutionId;
        public SourceCache<ConnectedInstitution, string> ConnectedInstitutions { get; } = new SourceCache<ConnectedInstitution, string>(KeySelector);

        [ObservableAsProperty]
        // ReSharper disable once UnassignedGetOnlyAutoProperty
        public bool IsBusy { get; }
        
        public ReactiveCommand<Unit, ApiListResponseOfConsent> Load { get; }
        
        public ReactiveCommand<Unit, ApiListResponseOfConsent> Refresh { get; }
        
        public ConnectedInstitutionsCache(
            ISchedulerProvider schedulerProvider,
            IConsentsQuery consentsQuery,
            ISecureStorage secureStorage)
        {
            _schedulerProvider = schedulerProvider;
            _consentsQuery = consentsQuery;
            _secureStorage = secureStorage;
            
            _connectedInstitutionsLoadedNotifications = new Subject<ConnectedInstitutionsLoaded>();
            _connectedInstitutionsRefreshedNotifications = new Subject<ConnectedInstitutionsRefreshed>();
            _connectedInstitutionsDataErrorNotifications = new Subject<ConnectedInstitutionsDataError>();
            
            Load = ReactiveCommand.CreateFromTask(
                _ => OnLoad(),
                this.WhenAnyValue(x => x.IsBusy).Select(x => !x),
                outputScheduler: _schedulerProvider.ThreadPool);
            
            Load.ThrownExceptions.Subscribe(OnError);
            Load.Subscribe(Load_OnNext);
            
            Refresh = ReactiveCommand.CreateFromTask(
                _ => OnRefresh(),
                this.WhenAnyValue(x => x.IsBusy).Select(x => !x),
                outputScheduler: _schedulerProvider.ThreadPool);
            
            Refresh.ThrownExceptions.Subscribe(OnError);
            Refresh.Subscribe(Refresh_OnNext);
        }
        
        string GetCacheKey(string userUuid)
        {
            return $"{userUuid}-consents";
        }
        
        private async Task<ApiListResponseOfConsent> OnLoad()
        {
            var userUuid = await _secureStorage.GetAsync(StorageKeys.UserUuid);
            
            var consents = await _consentsQuery.GetConsents(new string[] { userUuid}, GetCacheKey(userUuid));
            
            return consents;
        }
        
        private async Task<ApiListResponseOfConsent> OnRefresh()
        {
            var userUuid = await _secureStorage.GetAsync(StorageKeys.UserUuid);
            
            var consents = await _consentsQuery.RefreshConsents(new string[] { userUuid}, GetCacheKey(userUuid));

            return consents;
        }
        
        public void Clear()
        {
            _schedulerProvider.MainThread.Schedule(() =>
            {
                ConnectedInstitutions.Clear();
            });
        }
        
        void Load_OnNext(ApiListResponseOfConsent consentList)
        {
            try
            {
                Update(consentList);
                
                _connectedInstitutionsLoadedNotifications.OnNext(new ConnectedInstitutionsLoaded());
            }
            catch(Exception exception)
            {
                OnError(exception);
            }
        }
        
        void Refresh_OnNext(ApiListResponseOfConsent consentList)
        {
            try
            {
                Clear();
                
                Update(consentList);
                
                _connectedInstitutionsRefreshedNotifications.OnNext(new ConnectedInstitutionsRefreshed());
            }
            catch(Exception exception)
            {
                OnError(exception);
            }
        }

        void Update(ApiListResponseOfConsent consentList)
        {
            var userUuid = AsyncHelper.RunSync(() => _secureStorage.GetAsync("UserUuid"));
            
            // filtering doesn't seem to be working in the Api call??
            var filteredConsents = consentList.Data.Where(c => c.UserUuid == userUuid && c.Status == ConsentStatus.AUTHORIZED);
            
            var results = new List<ConnectedInstitution>();
            
            var groupedList = filteredConsents.GroupBy(x => x.InstitutionId);
            
            foreach (var group in groupedList)
            {
                Console.WriteLine($"Items in group {group.Key}:");

                var orderedGroup = group.OrderByDescending(c => c.AuthorizedAt);

                var newestInGroup = orderedGroup.First();
                results.Add(new ConnectedInstitution
                {
                    InstitutionId = newestInGroup.InstitutionId,
                    Status = newestInGroup.Status,
                    ConsentToken = newestInGroup.ConsentToken,
                    AuthorizedAt = newestInGroup.AuthorizedAt
                });
            }
            
            foreach (var connectedInstitution in results)
            {
                AsyncHelper.RunSync(() => _secureStorage.SetAsync($"{connectedInstitution.InstitutionId}-consent-token", connectedInstitution.ConsentToken));
            }
            
            _schedulerProvider.MainThread.Schedule(() =>
            {
                ConnectedInstitutions.UpdateCache(results, KeySelector);
            });
        }

        void OnError(Exception exception)
        {
            Debug.WriteLine($"Error {exception.Message}");

            Clear();
            
            _connectedInstitutionsDataErrorNotifications.OnNext(new ConnectedInstitutionsDataError());
        }
    }
}