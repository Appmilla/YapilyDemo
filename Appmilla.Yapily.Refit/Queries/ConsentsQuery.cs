using System;
using System.Collections.Generic;
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
    public interface IConsentsQuery
    {
        bool IsBusy { get; }

        IObservable<ApiListResponseOfConsent> GetConsents(IEnumerable<string> filterapplicationUserId, string cacheKey);

        IObservable<ApiListResponseOfConsent> RefreshConsents(IEnumerable<string> filterapplicationUserId, string cacheKey);
    }
    
    public class ConsentsQuery : ReactiveObject, IConsentsQuery
    {
        readonly IBlobCache _blobCache;
        readonly IYapilyHttpClientFactory _httpClientFactory;
        readonly ISchedulerProvider _schedulerProvider;
        readonly RefitSettings _refitSettings;

        readonly TimeSpan _cacheLifetime = TimeSpan.FromDays(1);
             
        [Reactive] public bool IsBusy { get; set; }

        public ConsentsQuery(IBlobCache blobCache,
            IYapilyHttpClientFactory httpClientFactory,
            ISchedulerProvider schedulerProvider,
            RefitSettings refitSettings)
        {
            _blobCache = blobCache;
            _httpClientFactory = httpClientFactory;
            _schedulerProvider = schedulerProvider;
            _refitSettings = refitSettings;
        }

        public IObservable<ApiListResponseOfConsent> GetConsents(IEnumerable<string> filterapplicationUserId, string cacheKey)
        {
            DateTimeOffset? expiration = DateTimeOffset.Now + _cacheLifetime;

            return _blobCache.GetAndFetchLatest(cacheKey, () => FetchConsents(filterapplicationUserId), null, expiration);
        }

        public IObservable<ApiListResponseOfConsent> RefreshConsents(IEnumerable<string> filterapplicationUserId, string cacheKey)
        {
            return Observable.Create<ApiListResponseOfConsent>(async observer =>
            {
                
                DateTimeOffset? expiration = DateTimeOffset.Now + _cacheLifetime;

                var institutions = await FetchConsents(filterapplicationUserId).ConfigureAwait(false);

                await _blobCache.InsertObject(cacheKey, institutions, expiration);

                observer.OnNext(institutions);

            }).SubscribeOn(_schedulerProvider.ThreadPool);
        }
        
        async Task<ApiListResponseOfConsent> FetchConsents(IEnumerable<string> filterapplicationUserId)
        {
            IsBusy = true;

            try
            {
                var httpClient = _httpClientFactory.CreateClient();

                var consentsApi = RestService.For<IConsents>(httpClient, _refitSettings);
                var consents = await consentsApi.GetConsentsUsingGETAsync(new ConsentsQueryParams { FilterapplicationUserId = filterapplicationUserId});
                
                return consents;
            }
            finally
            {
                IsBusy = false;
            }  
        }
        
    }
}