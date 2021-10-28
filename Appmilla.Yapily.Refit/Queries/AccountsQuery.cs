using System;
using System.Reactive.Linq;
using System.Threading.Tasks;
using Akavache;
using Appmilla.Xamarin.Infrastructure.Reactive;
using Appmilla.Yapily.Refit.Apis;
using Appmilla.Yapily.Refit.Http;
using Appmilla.Yapily.Refit.Models;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using Refit;

namespace Appmilla.Yapily.Refit.Queries
{
    public interface IAccountsQuery
    {
        bool IsBusy { get; }
        
        Task<ApiResponseOfAuthorisationRequestResponse> InitiateAccountRequest(AccountAuthorisationRequest accountAuthRequest);

        //Task<ApiListResponseOfAccount> GetAccounts();

        IObservable<ApiListResponseOfAccount> GetAccounts(string consentToken, string cacheKey);

        IObservable<ApiListResponseOfAccount> RefreshAccounts(string consentToken, string cacheKey);
    }

    public class AccountsQuery : ReactiveObject, IAccountsQuery
    {
        readonly IBlobCache _blobCache;
        readonly IYapilyHttpClientFactory _httpClientFactory;
        readonly ISchedulerProvider _schedulerProvider;
        readonly RefitSettings _refitSettings;
        
        //readonly TimeSpan _cacheLifetime = TimeSpan.FromHours(1);
        readonly TimeSpan _cacheLifetime = TimeSpan.FromSeconds(10);
        
        [Reactive] public bool IsBusy { get; set; }

        public AccountsQuery(IBlobCache blobCache,
            IYapilyHttpClientFactory httpClientFactory,
            ISchedulerProvider schedulerProvider,
            RefitSettings refitSettings)
        {
            _blobCache = blobCache;
            _httpClientFactory = httpClientFactory;
            _schedulerProvider = schedulerProvider;
            _refitSettings = refitSettings;
        }
        
        public async Task<ApiResponseOfAuthorisationRequestResponse> InitiateAccountRequest(AccountAuthorisationRequest accountAuthRequest)
        {
            IsBusy = true;

            try
            {
                var httpClient = _httpClientFactory.CreateClient();

                var accountsApi = RestService.For<IAccounts>(httpClient, _refitSettings);
                var accountAuthorisationResponse = await accountsApi.InitiateAccountRequestUsingPOSTAsync(accountAuthRequest);
                
                return accountAuthorisationResponse;
            }
            finally
            {
                IsBusy = false;
            }  
        }

        /*
        public async Task<ApiListResponseOfAccount> GetAccounts()
        {
            IsBusy = true;

            try
            {
                var httpClient = _httpClientFactory.CreateClient();

                var accountsApi = RestService.For<IAccounts>(httpClient, _refitSettings);
                var accountsResponse = await accountsApi.GetAccountsUsingGETAsync();

                return accountsResponse;
            }
            finally
            {
                IsBusy = false;
            }
        }
        */
        
        public IObservable<ApiListResponseOfAccount> GetAccounts(string consentToken, string cacheKey)
        {
            DateTimeOffset? expiration = DateTimeOffset.Now + _cacheLifetime;

            return _blobCache.GetOrFetchObject(cacheKey,
                () => FetchAccounts(consentToken),
                expiration);
        }

        public IObservable<ApiListResponseOfAccount> RefreshAccounts(string consentToken, string cacheKey)
        {
            return Observable.Create<ApiListResponseOfAccount>(async observer =>
            {
                
                DateTimeOffset? expiration = DateTimeOffset.Now + _cacheLifetime;

                var accounts = await FetchAccounts(consentToken).ConfigureAwait(false);

                await _blobCache.InsertObject(cacheKey, accounts, expiration);

                observer.OnNext(accounts);

            }).SubscribeOn(_schedulerProvider.ThreadPool);
        }
        
        async Task<ApiListResponseOfAccount> FetchAccounts(string consentToken)
        {
            IsBusy = true;

            try
            {
                var httpClient = _httpClientFactory.CreateClient();

                var accountsApi = RestService.For<IAccounts>(httpClient, _refitSettings);
                
                /*
                var consentToken =
                    "eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzUxMiJ9.eyJJTlNUSVRVVElPTiI6Im1vZGVsby1zYW5kYm94IiwiQ09OU0VOVCI6IjJiNWM0OTMwLTU4ZjItNGY4OS1iOTA0LTgzMmQ3NzliNDkzMCIsIkFQUExJQ0FUSU9OX1VTRVJfSUQiOiJ1c2VyLTEyOTk1NjAiLCJVU0VSIjoiZjk4MTdmMzQtNmEyZS00MTg2LWJhNmItNDFjNzFiYTBkMTIzIn0.0d1GvfT1PApZPS27fm99nWgGUvOuSq8fiZotzeqSc_z4IE2g_gjjuZlJGmWE7fFk7NkfABMWClQZZpiVnw_Jaw";
                    */
                var accountsResponse = await accountsApi.GetAccountsUsingGETAsync(consentToken);

                return accountsResponse;
            }
            finally
            {
                IsBusy = false;
            }  
        }
    }
}