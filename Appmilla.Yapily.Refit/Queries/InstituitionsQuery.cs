using System;
using System.Collections.Generic;
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
    public interface IInstituitionsQuery
    {
        bool IsBusy { get; }

        IObservable<ApiListResponseOfInstitution> GetInstitutions(string cacheKey);

        IObservable<ApiListResponseOfInstitution> RefreshInstitutions(string cacheKey);
        
        IObservable<Institution> GetInstitution(string institutionId, string cacheKey);
        
        IObservable<Institution> RefreshInstitution(string institutionId, string cacheKey);
    }

    public class InstituitionsQuery : ReactiveObject, IInstituitionsQuery
    {
        readonly IBlobCache _blobCache;
        readonly IYapilyHttpClientFactory _httpClientFactory;
        readonly ISchedulerProvider _schedulerProvider;
        readonly RefitSettings _refitSettings;

        readonly TimeSpan _cacheLifetime = TimeSpan.FromDays(1);
            
        [Reactive] public bool IsBusy { get; set; }

        public InstituitionsQuery(IBlobCache blobCache,
            IYapilyHttpClientFactory httpClientFactory,
            ISchedulerProvider schedulerProvider,
            RefitSettings refitSettings)
        {
            _blobCache = blobCache;
            _httpClientFactory = httpClientFactory;
            _schedulerProvider = schedulerProvider;
            _refitSettings = refitSettings;
        }

        public IObservable<ApiListResponseOfInstitution> GetInstitutions(string cacheKey)
        {
            DateTimeOffset? expiration = DateTimeOffset.Now + _cacheLifetime;

            return _blobCache.GetAndFetchLatest(cacheKey, FetchInstitutions, null, expiration);
        }

        public IObservable<ApiListResponseOfInstitution> RefreshInstitutions(string cacheKey)
        {
            return Observable.Create<ApiListResponseOfInstitution>(async observer =>
            {
                
                DateTimeOffset? expiration = DateTimeOffset.Now + _cacheLifetime;

                var institutions = await FetchInstitutions().ConfigureAwait(false);

                await _blobCache.InsertObject(cacheKey, institutions, expiration);

                observer.OnNext(institutions);

            }).SubscribeOn(_schedulerProvider.ThreadPool);
        }
        
        async Task<ApiListResponseOfInstitution> FetchInstitutions()
        {
            IsBusy = true;

            try
            {
                var httpClient = _httpClientFactory.CreateClient();

                var institutionsApi = RestService.For<IInstitutions>(httpClient, _refitSettings);
                var institutions = await institutionsApi.GetInstitutionsUsingGETAsync();
                
                return institutions;
            }
            finally
            {
                IsBusy = false;
            }  
        }
        
        public IObservable<Institution> GetInstitution(string institutionId, string cacheKey)
        {
            DateTimeOffset? expiration = DateTimeOffset.Now + _cacheLifetime;

            return _blobCache.GetAndFetchLatest(cacheKey, () => FetchInstitution(institutionId), null, expiration);
        }

        public IObservable<Institution> RefreshInstitution(string institutionId, string cacheKey)
        {
            return Observable.Create<Institution>(async observer =>
            {
                DateTimeOffset? expiration = DateTimeOffset.Now + _cacheLifetime;

                var institution = await FetchInstitution(institutionId).ConfigureAwait(false);

                await _blobCache.InsertObject(cacheKey, institution, expiration);

                observer.OnNext(institution);

            }).SubscribeOn(_schedulerProvider.ThreadPool);
        }
        
        async Task<Institution> FetchInstitution(string institutionId)
        {
            IsBusy = true;

            try
            {
                var httpClient = _httpClientFactory.CreateClient();

                var institutionsApi = RestService.For<IInstitutions>(httpClient, _refitSettings);
                var institution = await institutionsApi.GetInstitutionUsingGETAsync(institutionId);

                return institution;
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