using System;
using System.Reactive.Linq;
using System.Threading.Tasks;
using Akavache;
using Appmilla.Yapily.Refit.Apis;
using Appmilla.Yapily.Refit.Http;
using Appmilla.Yapily.Refit.Models;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using Refit;

namespace Appmilla.Yapily.Refit.Queries
{
    public interface IApplicationQuery
    {
        bool IsBusy { get; }

        Task<Application> GetApplication(string cacheKey);
    }
    
    public class ApplicationQuery : ReactiveObject, IApplicationQuery
    {
        readonly IBlobCache _blobCache;
        readonly IYapilyHttpClientFactory _httpClientFactory;
        readonly RefitSettings _refitSettings;
        
        readonly TimeSpan _cacheLifetime = TimeSpan.FromDays(1);
        
        [Reactive] public bool IsBusy { get; set; }

        public ApplicationQuery(IBlobCache blobCache,
            IYapilyHttpClientFactory httpClientFactory,
            RefitSettings refitSettings)
        {
            _blobCache = blobCache;
            _httpClientFactory = httpClientFactory;
            _refitSettings = refitSettings;
        }
        
        public async Task<Application> GetApplication(string cacheKey)
        {
            DateTimeOffset? expiration = DateTimeOffset.Now + _cacheLifetime;
            
            return await _blobCache.GetOrFetchObject(cacheKey,
                () => FetchApplication(),
                expiration);
        }
        
        async Task<Application> FetchApplication()
        {
            IsBusy = true;

            try
            {
                var httpClient = _httpClientFactory.CreateClient();

                var applicationApi = RestService.For<IApplication>(httpClient, _refitSettings);
                var application = await applicationApi.GetApplicationMeUsingGETAsync();
                
                return application;
            }
            finally
            {
                IsBusy = false;
            }  
        }
    }
}