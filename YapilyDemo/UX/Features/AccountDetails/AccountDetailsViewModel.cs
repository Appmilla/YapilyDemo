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
using Appmilla.Yapily.Refit.Models;
using Appmilla.Yapily.Refit.Queries;
using CommonServiceLocator;
using DynamicData;
using DynamicData.Binding;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using Xamarin.Essentials.Interfaces;
using Xamarin.Forms;
using YapilyDemo.UX.Features.Payments;
using YapilyDemo.UX.Features.Shared;

namespace YapilyDemo.UX.Features.AccountDetails
{
    public class AccountDetailsViewModel : ReactiveObject, INavigationAware
    {
        readonly ISchedulerProvider _schedulerProvider;
        readonly ISecureStorage _secureStorage;
        readonly ITransactionsQuery _transactionsQuery;
        
        [Reactive]
        public AccountViewModel Account { get; set; }
        
        ReadOnlyObservableCollection<TransactionViewModel> _transactions;
        
        public ReadOnlyObservableCollection<TransactionViewModel> Transactions
        {
            get => _transactions;
            set => this.RaiseAndSetIfChanged(ref _transactions, value);
        }

        private static readonly Func<TransactionViewModel, Guid> KeySelector = group => group.CacheKey;
        readonly SourceCache<TransactionViewModel, Guid> _transactionsCache = new SourceCache<TransactionViewModel, Guid>(KeySelector);
        
        [ObservableAsProperty]
        // ReSharper disable once UnassignedGetOnlyAutoProperty
        public bool IsBusy { get; }

        public ReactiveCommand<Unit, ApiListResponseOfTransaction> LoadTransactions { get; }
        
        public ReactiveCommand<Unit, Unit> CancelInFlightQueries { get; }
        
        public ReactiveCommand<Unit, Unit> Close { get; }
        
        public ReactiveCommand<Unit, Unit> CreatePayment { get; }
        
        [Reactive]
        public string Title { get; private set; } = "Account details";        
         
        [Reactive] public bool ShowLoading { get; set; }
        
        public AccountDetailsViewModel(
            ISchedulerProvider schedulerProvider,
            ISecureStorage secureStorage,
            ITransactionsQuery transactionsQuery)
        {
            _schedulerProvider = schedulerProvider;
            _secureStorage = secureStorage;
            _transactionsQuery = transactionsQuery;

            this.WhenAnyValue(x => x._transactionsQuery.IsBusy)
                .ObserveOn(schedulerProvider.MainThread)
                .ToPropertyEx(this, x => x.IsBusy, scheduler: _schedulerProvider.MainThread);

            LoadTransactions = ReactiveCommand.CreateFromObservable<Unit, ApiListResponseOfTransaction>(
                LoadQuery,
                outputScheduler: _schedulerProvider.ThreadPool);
            LoadTransactions.ThrownExceptions.Subscribe(OnError);
            LoadTransactions.Subscribe(Transactions_OnNext);
            
            CancelInFlightQueries = ReactiveCommand.Create(
                () => { },
                this.WhenAnyObservable(x => x.LoadTransactions.IsExecuting));

            
            var transactionsSort = SortExpressionComparer<TransactionViewModel>
                .Descending(t => t.Date);

            _ = _transactionsCache.Connect()
                .Sort(transactionsSort)
                .Bind(out _transactions)
                .ObserveOn(schedulerProvider.MainThread)        //ensure operation is on the UI thread;
                .DisposeMany()                              //automatic disposal
                .Subscribe();
            
            Close = ReactiveCommand.CreateFromTask(OnClose, outputScheduler: _schedulerProvider.MainThread);
            Close.ThrownExceptions.Subscribe(OnError);
            
            CreatePayment = ReactiveCommand.CreateFromTask(OnCreatePayment, outputScheduler: _schedulerProvider.MainThread);
            CreatePayment.ThrownExceptions.Subscribe(CreatePayment_OnError);
        }
        
        public Task OnViewAppearing()
        {
            Observable.Return(Unit.Default).InvokeCommand(LoadTransactions);
            
            return Task.CompletedTask;
        }

        public Task OnViewDisappearing()
        {
            _schedulerProvider.MainThread.Schedule(_ =>
            {
                _transactionsCache.Clear();
            });
            
            return Task.CompletedTask;
        }
        
        private IObservable<ApiListResponseOfTransaction> LoadQuery(Unit ignored)
        {
            ShowLoading = true;
            
            var consentTokenKey = $"{Account.InstitutionId}-consent-token";
            var consentToken = AsyncHelper.RunSync(() => _secureStorage.GetAsync(consentTokenKey));

            return _transactionsQuery.GetTransactions(consentToken, Account.Id, GetCacheKey()).TakeUntil(CancelInFlightQueries);
        }
        
        string GetCacheKey()
        {
            return $"{Account.InstitutionId}--{Account.Id}--transactions";
        }
        
        public void Transactions_OnNext(ApiListResponseOfTransaction transactionsList)
        {
            var results = transactionsList.Data.Select(t => new TransactionViewModel()
            {
                CacheKey = GuidUtility.GetDeterministicGuid($"{t.Id}"),
                Id = t.Id,
                Date = t.Date,
                BookingDateTime = t.BookingDateTime,
                ValueDateTime = t.ValueDateTime,
                Status = t.Status,
                Amount = t.Amount,
                Currency = t.Currency,
                TransactionAmount = t.TransactionAmount,
                GrossAmount = t.GrossAmount,
                CurrencyExchange = t.CurrencyExchange,
                ChargeDetails = t.ChargeDetails,
                Reference = t.Reference,
                StatementReferences = t.StatementReferences,
                Description = t.Description,
                TransactionInformation = t.TransactionInformation,
                AddressDetails = t.AddressDetails,
                IsoBankTransactionCode = t.IsoBankTransactionCode,
                ProprietaryBankTransactionCode = t.ProprietaryBankTransactionCode,
                Balance = t.Balance,
                PayeeDetails = t.PayeeDetails,
                PayerDetails = t.PayerDetails,
                Merchant = t.Merchant,
                Enrichment = t.Enrichment,
                SupplementaryData = t.SupplementaryData,
                FormattedAmount = t.TransactionAmount.Amount.ToFormattedCurrencyString(StringUtilities.GetCurrencySymbol(t.TransactionAmount.Currency))
            }).ToList();
            
            _schedulerProvider.MainThread.Schedule(_ =>
            {
                _transactionsCache.UpdateCache(results, KeySelector);

                ShowLoading = false;
            });
        }
        
        void OnError(Exception exception)
        {
            ShowLoading = false;
            
            Debug.WriteLine($"Error {exception.Message}");
        }

        async Task OnClose()
        {
            Observable.Return(Unit.Default).InvokeCommand(CancelInFlightQueries);
            
            await Shell.Current.GoToAsync("..");
        }
        
        async Task OnCreatePayment()
        {
            var createPaymentViewModel = ServiceLocator.Current.GetInstance<CreatePaymentViewModel>();
            createPaymentViewModel.PayerAccount = Account;
            
            await Shell.Current.GoToAsync("createPayment");   
        }

        void CreatePayment_OnError(Exception exception)
        {
            Debug.WriteLine($"Error {exception.Message}");
        }
    }
}