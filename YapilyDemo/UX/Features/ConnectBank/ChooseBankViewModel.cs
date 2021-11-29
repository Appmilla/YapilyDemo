using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Reactive;
using System.Reactive.Concurrency;
using System.Reactive.Linq;
using System.Threading.Tasks;
using Appmilla.Xamarin.Infrastructure.Extensions;
using Appmilla.Xamarin.Infrastructure.Framework;
using Appmilla.Xamarin.Infrastructure.Reactive;
using Appmilla.Xamarin.Infrastructure.Utilities;
using Appmilla.Yapily.Refit.Caches;
using Appmilla.Yapily.Refit.Models;
using Appmilla.Yapily.Refit.Queries;
using Appmilla.Yapily.Refit.UseCases.Institutions;
using DynamicData;
using DynamicData.Binding;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using Xamarin.Essentials.Interfaces;
using Xamarin.Forms;
using YapilyDemo.Framework;
using YapilyDemo.UX.Features.Shared;

namespace YapilyDemo.UX.Features.ConnectBank
{
    public class ChooseBankViewModel : ReactiveObject, IViewModel, INavigationAware
    {
        readonly ISchedulerProvider _schedulerProvider;
        readonly IInstituitionsQuery _instituitionsQuery;
        readonly IAccountsQuery _accountsQuery;
        readonly ITransactionsQuery _transactionsQuery;
        readonly ISecureStorage _secureStorage;
        readonly IConnectedInstitutionsCache _connectedInstitutionsCache;
        readonly IConnectInstitution _connectInstitution;
        
        public string Id => NavigationPageKeys.ChooseBankPageKey;

        ReadOnlyObservableCollection<InstitutionViewModel> _institutions;

        public ReadOnlyObservableCollection<InstitutionViewModel> Institutions
        {
            get => _institutions;
            set => this.RaiseAndSetIfChanged(ref _institutions, value);
        }

        private static readonly Func<InstitutionViewModel, Guid> KeySelector = group => group.CacheKey;
        readonly SourceCache<InstitutionViewModel, Guid> _institutionsCache = new SourceCache<InstitutionViewModel, Guid>(KeySelector);

        [ObservableAsProperty]
        // ReSharper disable once UnassignedGetOnlyAutoProperty
        public bool IsBusy { get; }
        
        public ReactiveCommand<Unit, ApiListResponseOfInstitution> Load { get; }

        public ReactiveCommand<Unit, ApiListResponseOfInstitution> Refresh { get; }

        public ReactiveCommand<Unit, Unit> CancelInFlightQueries { get; }

        public ReactiveCommand<InstitutionViewModel, bool> ConnectBank { get; protected set; }
        
        public ReactiveCommand<Unit, Unit> Close { get; }

        public ChooseBankViewModel(
            ISchedulerProvider schedulerProvider,
            IApplicationQuery applicationQuery,
            IInstituitionsQuery instituitionsQuery,
            IAccountsQuery accountsQuery,
            ITransactionsQuery transactionsQuery,
            ISecureStorage secureStorage,
            IConnectedInstitutionsCache connectedInstitutionsCache,
            IConnectInstitution connectInstitution)
        {
            _schedulerProvider = schedulerProvider;
            _instituitionsQuery = instituitionsQuery;
            _accountsQuery = accountsQuery;
            _transactionsQuery = transactionsQuery;
            _secureStorage = secureStorage;
            _connectedInstitutionsCache = connectedInstitutionsCache;
            _connectInstitution = connectInstitution;
            
            this.WhenAnyValue(x => x._instituitionsQuery.IsBusy)
                .ObserveOn(schedulerProvider.MainThread)
                .ToPropertyEx(this, x => x.IsBusy, scheduler: _schedulerProvider.MainThread);

            Load = ReactiveCommand.CreateFromObservable(
                () => _instituitionsQuery.GetInstitutions(GetCacheKey()).TakeUntil(CancelInFlightQueries),
                this.WhenAnyValue(x => x.IsBusy).Select(x => !x),
                outputScheduler: _schedulerProvider.ThreadPool);
            Load.ThrownExceptions.Subscribe(Institutions_OnError);
            Load.Subscribe(Institutions_OnNext);

            Refresh = ReactiveCommand.CreateFromObservable(
                () => _instituitionsQuery.GetInstitutions(GetCacheKey()).TakeUntil(CancelInFlightQueries),
                this.WhenAnyValue(x => x.IsBusy).Select(x => !x),
                outputScheduler: _schedulerProvider.ThreadPool);
            Refresh.ThrownExceptions.Subscribe(Institutions_OnError);
            Refresh.Subscribe(Institutions_OnNext);

            CancelInFlightQueries = ReactiveCommand.Create(
                () => { },
                this.WhenAnyObservable(x => x.Load.IsExecuting, y => y.Refresh.IsExecuting, (x, y) => x || y));

            var institutionsSort = SortExpressionComparer<InstitutionViewModel>
                .Ascending(i => i.Name);

            _ = _institutionsCache.Connect()
                .Sort(institutionsSort)
                .Bind(out _institutions)
                .ObserveOn(schedulerProvider.MainThread)        //ensure operation is on the UI thread;
                .DisposeMany()                              //automatic disposal
                .Subscribe();

            ConnectBank = ReactiveCommand.CreateFromTask<InstitutionViewModel, bool>(OnConnectBank, outputScheduler: _schedulerProvider.MainThread);
            ConnectBank.ThrownExceptions.Subscribe(OnError);
            
            Close = ReactiveCommand.CreateFromTask(OnClose, outputScheduler: _schedulerProvider.MainThread);
            Close.ThrownExceptions.Subscribe(OnError);
        }

        private async Task<bool> OnConnectBank(InstitutionViewModel institutionViewModel)
        {
            bool connected = await _connectInstitution.ConnectBank(institutionViewModel.Id);
            if (connected)
            {
                await Shell.Current.GoToAsync("//main");
            }

            return connected;
        }
        
        string GetCacheKey()
        {
            return $"yapily/institutions";
        }
        
        public void Institutions_OnNext(ApiListResponseOfInstitution institutionsList)
        {
            var results = institutionsList.Data.Select(i => new InstitutionViewModel()
            {
                CacheKey = GuidUtility.GetDeterministicGuid($"{i.Id}"),
                Countries = i.Countries,
                CredentialsType = i.CredentialsType,
                EnvironmentType = i.EnvironmentType,
                Features = i.Features,
                FullName = i.FullName,
                Id = i.Id,
                Media = i.Media,
                Monitoring = i.Monitoring,
                Name = i.Name,
                ImageUrl = i.Media.SingleOrDefault(m => m.Type == "logo")?.Source
            });
            
            _schedulerProvider.MainThread.Schedule(_ =>
            {
                _institutionsCache.UpdateCache(results, KeySelector);
            });
        }
        
        void Institutions_OnError(Exception exception)
        {
            Debug.WriteLine($"Error {exception.Message}");
        }

        public Task OnViewAppearing()
        {
            Observable.Return(Unit.Default).InvokeCommand(Load);
            
            return Task.CompletedTask;
        }

        public Task OnViewDisappearing()
        {
            return Task.CompletedTask;
        }
        
        async Task OnClose()
        {
            await Shell.Current.GoToAsync("..");
        }
        
        void OnError(Exception exception)
        {
            Debug.WriteLine($"Error {exception.Message}");
        }
    }
}