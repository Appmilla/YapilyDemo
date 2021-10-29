using System;
using System.Diagnostics;
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
    public interface ITransactionsQuery
    {
        bool IsBusy { get; }
        
        IObservable<ApiListResponseOfTransaction> GetTransactions(string consentToken, string accountId, string cacheKey);
        
        IObservable<ApiListResponseOfTransaction> RefreshTransactions(string consentToken, string accountId, string cacheKey);
    }

    public class TransactionsQuery : ReactiveObject, ITransactionsQuery
    {
        readonly IBlobCache _blobCache;
        readonly IYapilyHttpClientFactory _httpClientFactory;
        readonly ISchedulerProvider _schedulerProvider;
        readonly RefitSettings _refitSettings;
        
        //readonly TimeSpan _cacheLifetime = TimeSpan.FromHours(1);
        readonly TimeSpan _cacheLifetime = TimeSpan.FromSeconds(10);
        
        [Reactive] public bool IsBusy { get; set; }

        public TransactionsQuery(IBlobCache blobCache,
            IYapilyHttpClientFactory httpClientFactory,
            ISchedulerProvider schedulerProvider,
            RefitSettings refitSettings)
        {
            _blobCache = blobCache;
            _httpClientFactory = httpClientFactory;
            _schedulerProvider = schedulerProvider;
            _refitSettings = refitSettings;
        }
        
        
        public IObservable<ApiListResponseOfTransaction> GetTransactions(string consentToken, string accountId, string cacheKey)
        {
            DateTimeOffset? expiration = DateTimeOffset.Now + _cacheLifetime;

            return _blobCache.GetOrFetchObject(cacheKey,
                () => FetchTransactions(consentToken, accountId),
                expiration);
        }

        public IObservable<ApiListResponseOfTransaction> RefreshTransactions(string consentToken, string accountId, string cacheKey)
        {
            return Observable.Create<ApiListResponseOfTransaction>(async observer =>
            {
                DateTimeOffset? expiration = DateTimeOffset.Now + _cacheLifetime;

                var institution = await FetchTransactions(consentToken, accountId).ConfigureAwait(false);

                await _blobCache.InsertObject(cacheKey, institution, expiration);

                observer.OnNext(institution);

            }).SubscribeOn(_schedulerProvider.ThreadPool);
        }
        
        async Task<ApiListResponseOfTransaction> FetchTransactions(string consentToken, string accountId)
        {
            IsBusy = true;

            try
            {
                var httpClient = _httpClientFactory.CreateClient();

                var transactionsApi = RestService.For<ITransactions>(httpClient, _refitSettings);
                var transactions = await transactionsApi.GetTransactionsUsingGETAsync(consentToken, accountId);

                return transactions;
            }
            catch (Exception exception)
            {
                Debug.WriteLine($"Error {exception.Message}");
                throw;
            }
            finally
            {
                IsBusy = false;
            }  
        }
    }
        

        

}
