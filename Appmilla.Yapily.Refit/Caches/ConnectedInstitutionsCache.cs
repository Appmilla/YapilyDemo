using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reactive;
using System.Reactive.Concurrency;
using System.Reactive.Linq;
using System.Reactive.Subjects;
using Appmilla.Xamarin.Infrastructure.Reactive;
using Appmilla.Xamarin.Infrastructure.Extensions;
using Appmilla.Yapily.Refit.Database;
using DynamicData;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;

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
          
        ReactiveCommand<Unit, List<ConnectedInstitution>> Load { get; }

        ReactiveCommand<Unit, List<ConnectedInstitution>> Refresh { get; }
        
        void Clear();
        
        IObservable<ConnectedInstitutionsLoaded> ConnectedInstitutionsLoadedNotifications { get; }
        
        IObservable<ConnectedInstitutionsRefreshed> ConnectedInstitutionsRefreshedNotifications { get; }
        
        IObservable<ConnectedInstitutionsDataError> ConnectedInstitutionsDataErrorNotifications { get; }
    }
    
    public class ConnectedInstitutionsCache : ReactiveObject, IConnectedInstitutionsCache
    {
        enum ActionType
        {
            Load,
            Refresh
        };

        readonly ISchedulerProvider _schedulerProvider;
        readonly IConnectedInstitutionsDb _connectedInstitutionsDb;
        
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
        
        public ReactiveCommand<Unit, List<ConnectedInstitution>> Load { get; }
        
        public ReactiveCommand<Unit, List<ConnectedInstitution>> Refresh { get; }
        
        public ConnectedInstitutionsCache(
            ISchedulerProvider schedulerProvider,
            IConnectedInstitutionsDb connectedInstitutionsDb)
        {
            _schedulerProvider = schedulerProvider;
            _connectedInstitutionsDb = connectedInstitutionsDb;
            
            _connectedInstitutionsLoadedNotifications = new Subject<ConnectedInstitutionsLoaded>();
            _connectedInstitutionsRefreshedNotifications = new Subject<ConnectedInstitutionsRefreshed>();
            _connectedInstitutionsDataErrorNotifications = new Subject<ConnectedInstitutionsDataError>();
            
            Load = ReactiveCommand.CreateFromTask(
                () => _connectedInstitutionsDb.GetInstitutionsAsync(),
                this.WhenAnyValue(x => x.IsBusy).Select(x => !x),
                outputScheduler: _schedulerProvider.ThreadPool);
            Load.ThrownExceptions.Subscribe(OnError);
            Load.Subscribe(Load_OnNext);
            
            Refresh = ReactiveCommand.CreateFromTask(
                () => _connectedInstitutionsDb.GetInstitutionsAsync(),
                this.WhenAnyValue(x => x.IsBusy).Select(x => !x),
                outputScheduler: _schedulerProvider.ThreadPool);
            Refresh.ThrownExceptions.Subscribe(OnError);
            Refresh.Subscribe(Refresh_OnNext);
        }
        
        public void Clear()
        {
            _schedulerProvider.MainThread.Schedule(() =>
            {
                ConnectedInstitutions.Clear();
            });
        }
        
        void Load_OnNext(ICollection<ConnectedInstitution> connectedInstitutions)
        {
            try
            {
                Update(connectedInstitutions, ActionType.Load);
            }
            catch(Exception exception)
            {
                OnError(exception);
            }
        }

        void Refresh_OnNext(ICollection<ConnectedInstitution> connectedInstitutions)
        {
            try
            {
                Clear();
                
                Update(connectedInstitutions, ActionType.Refresh);
            }
            catch(Exception exception)
            {
                OnError(exception);
            }
        }
        
        void Update(ICollection<ConnectedInstitution> connectedInstitutions, ActionType actionType)
        {
            _schedulerProvider.MainThread.Schedule(() =>
            {
                ConnectedInstitutions.UpdateCache(connectedInstitutions, KeySelector);

                if (actionType == ActionType.Load)
                {
                    _connectedInstitutionsLoadedNotifications.OnNext(new ConnectedInstitutionsLoaded());
                }
                else if (actionType == ActionType.Refresh)
                {
                    _connectedInstitutionsRefreshedNotifications.OnNext(new ConnectedInstitutionsRefreshed());
                }
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