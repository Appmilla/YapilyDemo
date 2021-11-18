using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Reactive;
using System.Reactive.Concurrency;
using System.Reactive.Linq;
using System.Threading.Tasks;
using Appmilla.Xamarin.Infrastructure.Extensions;
using Appmilla.Xamarin.Infrastructure.Reactive;
using Appmilla.Xamarin.Infrastructure.Utilities;
using Appmilla.Yapily.Refit.Models;
using Appmilla.Yapily.Refit.Queries;
using DynamicData;
using DynamicData.Binding;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using Xamarin.Essentials;
using Xamarin.Essentials.Interfaces;
using Xamarin.Forms;
using YapilyDemo.UX.Features.Shared;

namespace YapilyDemo.UX.Features.Home
{
    public class InstitutionSummaryViewModel : ReactiveObject
    {
        readonly ISchedulerProvider _schedulerProvider;
        readonly IAccountsQuery _accountsQuery;
        readonly ISecureStorage _secureStorage;
        readonly ITransactionsQuery _transactionsQuery;
        
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
        
        public ReactiveCommand<Unit, bool> ReauthoriseAccounts { get; protected set; }

        [Reactive] public bool ShowLoading { get; set; }

        [ObservableAsProperty]
        // ReSharper disable once UnassignedGetOnlyAutoProperty
        public bool ShowAccounts { get; }
        
        //[ObservableAsProperty]
        // ReSharper disable once UnassignedGetOnlyAutoProperty
        //public bool ShowAccountsError { get; }
        
        [Reactive]
        public bool IsAccountsInError { get; set; }
        
        public InstitutionSummaryViewModel(
            ISchedulerProvider schedulerProvider,
            IAccountsQuery accountsQuery,
            ISecureStorage secureStorage,
            ITransactionsQuery transactionsQuery)
        {
            _schedulerProvider = schedulerProvider;            
            _accountsQuery = accountsQuery;  
            _secureStorage = secureStorage;
            _transactionsQuery = transactionsQuery;
            
            this.WhenAnyValue(x => x._accountsQuery.IsBusy)
                .ObserveOn(schedulerProvider.MainThread)
                .ToPropertyEx(this, x => x.IsBusy, scheduler: _schedulerProvider.MainThread);
                                   
            this.WhenAnyValue(x => x.Accounts.Count, y => y.IsAccountsInError, (x,y) => x > 0 && !y)
                .ToPropertyEx(this, x => x.ShowAccounts, scheduler: schedulerProvider.MainThread);                       
            
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
            
            ReauthoriseAccounts = ReactiveCommand.CreateFromTask<Unit, bool>(OnReauthoriseAccounts, outputScheduler: _schedulerProvider.MainThread);
            ReauthoriseAccounts.ThrownExceptions.Subscribe(OnReauthoriseAccountsError);
        }
        
        private IObservable<ApiListResponseOfAccount> LoadQuery(Unit ignored)
        {
            ShowLoading = true;

            var consentTokenKey = $"{InstitutionId}-consent-token";
            var consentToken = AsyncHelper.RunSync(() => _secureStorage.GetAsync(consentTokenKey));

            IsAccountsInError = false;
            
            return _accountsQuery.GetAccounts(consentToken, GetCacheKey()).TakeUntil(CancelInFlightQueries);
        }
        
        string GetCacheKey()
        {
            return $"{InstitutionId}--accounts";
        }
        
        public void Accounts_OnNext(ApiListResponseOfAccount accountsList)
        {
            var results = accountsList.Data.Select(i => new AccountViewModel(
                _schedulerProvider,
                _transactionsQuery,
                _secureStorage)
            {
                CacheKey = GuidUtility.GetDeterministicGuid($"{i.Id}"),
                Id = i.Id,
                InstitutionId = InstitutionId,
                Type = i.Type,
                Description = i.Description,
                Balance = i?.Balance,
                Currency = i.Currency,
                FormattedBalance = i?.Balance.ToFormattedCurrencyString(StringUtilities.GetCurrencySymbol(i.Currency)),
                UsageType = i?.UsageType,
                AccountType = i?.AccountType,
                Nickname = i.Nickname,
                Details = i.Details,
                AccountNames = i.AccountNames,
                AccountIdentifications = i.AccountIdentifications,
                AccountBalances = i.AccountBalances
            }).ToList();
            
            IsAccountsInError = false;
            
            _schedulerProvider.MainThread.Schedule(_ =>
            {
                _accountCache.UpdateCache(results, KeySelector);

                ShowLoading = false;
            });
        }
        
        void Accounts_OnError(Exception exception)
        {
            ShowLoading = false;

            Debug.WriteLine($"Error {exception.Message}");

            IsAccountsInError = true;
            
            if (exception is Refit.ApiException refitApiException)
            {
                if (refitApiException.StatusCode == HttpStatusCode.Forbidden)
                {
                    //re-auth
                    
                    _schedulerProvider.MainThread.Schedule(_ =>
                    {
                        Observable.Return(Unit.Default).InvokeCommand(ReauthoriseAccounts);
                    });
                }
            }
        }

        async Task<bool> OnReauthoriseAccounts(Unit ignored)
        {
            //getting this Refit.ApiException: Response status code does not indicate success: 415 (Unsupported Media Type).
            
            try
            {
                var consentTokenKey = $"{InstitutionId}-consent-token";
                var consentToken = AsyncHelper.RunSync(() => _secureStorage.GetAsync(consentTokenKey));
                
                var authResponse = await _accountsQuery.ReauthoriseAccount(consentToken);

                Debug.WriteLine(authResponse);

                var callback = "com.intuitive.yapilydemo://callback";
                var authResult = await WebAuthenticator.AuthenticateAsync(new Uri(authResponse.Data.AuthorisationUrl), new Uri(callback));
                
                Debug.WriteLine(authResult);

                var consentTokenResult = authResult.GetConsentToken();
                var result = !string.IsNullOrEmpty(consentTokenResult);

                if (result)
                {
                    Observable.Return(Unit.Default).InvokeCommand(LoadAccounts);  
                }
                
                return  result;
            }
            catch (Exception exception)
            {
                Debug.WriteLine($"Error {exception.Message}");
                throw;
            }
        }

        void OnReauthoriseAccountsError(Exception exception)
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