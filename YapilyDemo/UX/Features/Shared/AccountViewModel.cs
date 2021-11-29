using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reactive;
using System.Threading.Tasks;
using Appmilla.Xamarin.Infrastructure.Reactive;
using Appmilla.Yapily.Refit.Models;
using Appmilla.Yapily.Refit.Queries;
using CommonServiceLocator;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using Xamarin.Essentials.Interfaces;
using Xamarin.Forms;
using YapilyDemo.UX.Features.AccountDetails;

namespace YapilyDemo.UX.Features.Shared
{
    public class AccountViewModel : ReactiveObject
    {
        readonly ISchedulerProvider _schedulerProvider;
        readonly ITransactionsQuery _transactionsQuery;
        readonly ISecureStorage _secureStorage;
        
        [Reactive]
        public Guid CacheKey { get; set; }

        [Reactive]
        public string Id { get; set; }
        
        [Reactive]
        public string InstitutionId { get; set; }

        [Reactive]
        public string Type { get; set; }

        [Reactive]
        public string Description { get; set; }

        [Reactive]
        public double? Balance { get; set; }

        [Reactive]
        public string Currency { get; set; }

        [Reactive]
        public string FormattedBalance { get; set; }
        
        [Reactive]
        public AccountUsageType? UsageType { get; set; }

        [Reactive]
        public AccountType? AccountType { get; set; }

        [Reactive]
        public string Name { get; set; }
        
        [Reactive]
        public string Nickname { get; set; }

        [Reactive]
        public string Details { get; set; }
       
        [Reactive]
        public List<AccountName> AccountNames { get; set; }

        [Reactive]
        public List<AccountIdentification> AccountIdentifications { get; set; }

        [Reactive]
        public List<AccountBalance> AccountBalances { get; set; }

        public ReactiveCommand<Unit, Unit> ViewAccountDetails { get; }
        
        public AccountViewModel(
            ISchedulerProvider schedulerProvider,
            ITransactionsQuery transactionsQuery,
            ISecureStorage secureStorage)
        {
            _schedulerProvider = schedulerProvider;
            _transactionsQuery = transactionsQuery;
            _secureStorage = secureStorage;
            
            ViewAccountDetails = ReactiveCommand.CreateFromTask(OnViewAccountDetails, outputScheduler: _schedulerProvider.MainThread);
            ViewAccountDetails.ThrownExceptions.Subscribe(OnError);
        }
        
        async Task OnViewAccountDetails()
        {
            var accountDetailsViewModel = ServiceLocator.Current.GetInstance<AccountDetailsViewModel>();
            accountDetailsViewModel.Account = this;
            await Shell.Current.GoToAsync("accountDetails");  
            
            /*
            var consentTokenKey = $"{InstitutionId}-consent-token";
            var consentToken = await _secureStorage.GetAsync(consentTokenKey);

            var transactionTest =
                await _transactionsQuery.GetTransactions(consentToken,Id, $"{CacheKey}--transactions");
                */
        }
        
        void OnError(Exception exception)
        {
            Debug.WriteLine($"Error {exception.Message}");
        }
    }
}
