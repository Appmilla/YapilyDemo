using System;
using System.Collections.ObjectModel;
using System.Reactive;
using System.Reactive.Linq;
using Appmilla.Xamarin.Infrastructure.Reactive;
using Appmilla.Yapily.Refit.Models;
using Appmilla.Yapily.Refit.Queries;
using DynamicData;
using DynamicData.Binding;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using System.Diagnostics;
using System.Linq;
using System.Reactive.Concurrency;
using System.Threading.Tasks;
using Appmilla.Xamarin.Infrastructure.Extensions;
using Appmilla.Xamarin.Infrastructure.Utilities;
using Xamarin.Essentials.Interfaces;

namespace YapilyDemo.UX
{
    public class InstitutionSummaryViewModel : ReactiveObject
    {
        readonly ISchedulerProvider _schedulerProvider;
        readonly IAccountsQuery _accountsQuery;
        readonly ISecureStorage _secureStorage;
        
        ReadOnlyObservableCollection<AccountViewModel> _accounts;
        
        public ReadOnlyObservableCollection<AccountViewModel> Accounts
        {
            get => _accounts;
            set => this.RaiseAndSetIfChanged(ref _accounts, value);
        }

        private static readonly Func<AccountViewModel, Guid> KeySelector = group => group.CacheKey;
        readonly SourceCache<AccountViewModel, Guid> _accountCache = new SourceCache<AccountViewModel, Guid>(KeySelector);

        [ObservableAsProperty]
        // ReSharper disable once UnassignedGetOnlyAutoProperty
        public bool IsBusy { get; }
        
        [Reactive]
        public string InstitutionId { get; set; }
        
        [Reactive]
        public string Name { get; set; }
        
        [Reactive]
        public string ImageUrl { get; set; }
        
        //[Reactive]
        //public InstitutionViewModel Institution { get; set; }
        
        public ReactiveCommand<Unit, ApiListResponseOfAccount> LoadAccounts { get; }
         
        public ReactiveCommand<Unit, ApiListResponseOfAccount> RefreshAccounts { get; }

        public ReactiveCommand<Unit, Unit> CancelInFlightQueries { get; }

        public ReactiveCommand<Unit, Unit> ViewInstitutionDetails { get; }
        
        public InstitutionSummaryViewModel(
            ISchedulerProvider schedulerProvider,
            IAccountsQuery accountsQuery,
            ISecureStorage secureStorage)
        {
            _schedulerProvider = schedulerProvider;            
            _accountsQuery = accountsQuery;  
            _secureStorage = secureStorage;
            
            this.WhenAnyValue(x => x._accountsQuery.IsBusy)
                .ObserveOn(schedulerProvider.MainThread)
                .ToPropertyEx(this, x => x.IsBusy, scheduler: _schedulerProvider.MainThread);
            
            /*
            LoadAccounts = ReactiveCommand.CreateFromObservable(
                () => _accountsQuery.GetAccounts(AsyncHelper.RunSync(_secureStorage.GetAsync($"{InstitutionId}-consent-token")), GetCacheKey()).TakeUntil(CancelInFlightQueries),
                this.WhenAnyValue(x => x.IsBusy).Select(x => !x),
                outputScheduler: _schedulerProvider.ThreadPool);
            */
            
            LoadAccounts = ReactiveCommand.CreateFromObservable<Unit, ApiListResponseOfAccount>(
                LoadQuery,
                outputScheduler: _schedulerProvider.ThreadPool);
            LoadAccounts.ThrownExceptions.Subscribe(Accounts_OnError);
            LoadAccounts.Subscribe(Accounts_OnNext);
            
            /*
            RefreshAccounts = ReactiveCommand.CreateFromObservable(
                () => _accountsQuery.RefreshAccounts(GetCacheKey()).TakeUntil(CancelInFlightQueries),
                this.WhenAnyValue(x => x.IsBusy).Select(x => !x),
                outputScheduler: _schedulerProvider.ThreadPool);
            RefreshAccounts.ThrownExceptions.Subscribe(Accounts_OnError);
            RefreshAccounts.Subscribe(Accounts_OnNext);
            */
            
            CancelInFlightQueries = ReactiveCommand.Create(
                () => { },
                this.WhenAnyObservable(x => x.LoadAccounts.IsExecuting, y => y.RefreshAccounts.IsExecuting, (x, y) => x || y));
            
            ViewInstitutionDetails = ReactiveCommand.CreateFromTask(OnViewInstitutionDetails, outputScheduler: _schedulerProvider.MainThread);
            ViewInstitutionDetails.ThrownExceptions.Subscribe(ViewInstitutionDetails_OnError);
            
            var accountsSort = SortExpressionComparer<AccountViewModel>
                .Ascending(i => i.Id);

            _ = _accountCache.Connect()
                .Sort(accountsSort)
                .Bind(out _accounts)
                .ObserveOn(schedulerProvider.MainThread)        //ensure operation is on the UI thread;
                .DisposeMany()                              //automatic disposal
                .Subscribe();
            
        }
        
        private IObservable<ApiListResponseOfAccount> LoadQuery(Unit ignored)
        {
            var consentTokenKey = $"{InstitutionId}-consent-token";
            var consentToken = AsyncHelper.RunSync(() => _secureStorage.GetAsync(consentTokenKey));
            
            return _accountsQuery.GetAccounts(consentToken, GetCacheKey()).TakeUntil(CancelInFlightQueries);
        }
        
        string GetCacheKey()
        {
            return $"{InstitutionId}--accounts";
        }
        
        public void Accounts_OnNext(ApiListResponseOfAccount accountsList)
        {
            var results = accountsList.Data.Select(i => new AccountViewModel()
            {
                CacheKey = GuidUtility.GetDeterministicGuid($"{i.Id}"),
                Id = i.Id,
                Type = i.Type,
                Description = i.Description,
                Balance = i?.Balance,
                Currency = i.Currency,
                UsageType = i?.UsageType,
                AccountType = i?.AccountType,
                Nickname = i.Nickname,
                Details = i.Details,
                AccountNames = i.AccountNames,
                AccountIdentifications = i.AccountIdentifications,
                AccountBalances = i.AccountBalances
            });
            
            _schedulerProvider.MainThread.Schedule(_ =>
            {
                _accountCache.UpdateCache(results, KeySelector);
            });
        }
        
        void Accounts_OnError(Exception exception)
        {
            Debug.WriteLine($"Error {exception.Message}");
        }
        
        async Task OnViewInstitutionDetails()
        {
            
        }
        
        void ViewInstitutionDetails_OnError(Exception exception)
        {
            Debug.WriteLine($"Error {exception.Message}");
        }
    }
}