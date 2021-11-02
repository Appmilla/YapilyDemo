using System;
using System.Collections.Generic;
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
    public interface IUsersQuery
    {
        Task<ICollection<ApplicationUser>> GetUsers(IEnumerable<string> filterapplicationUserId);
        
        Task<ApplicationUser> AddUser(NewApplicationUser newApplicationUser);
        
    }
    
    public class UsersQuery : ReactiveObject, IUsersQuery
    {
        readonly IBlobCache _blobCache;
        readonly IYapilyHttpClientFactory _httpClientFactory;
        readonly ISchedulerProvider _schedulerProvider;
        readonly RefitSettings _refitSettings;
        
        //readonly TimeSpan _cacheLifetime = TimeSpan.FromSeconds(10);
        
        [Reactive] public bool IsBusy { get; set; }
        
        public UsersQuery(IBlobCache blobCache,
            IYapilyHttpClientFactory httpClientFactory,
            ISchedulerProvider schedulerProvider,
            RefitSettings refitSettings)
        {
            _blobCache = blobCache;
            _httpClientFactory = httpClientFactory;
            _schedulerProvider = schedulerProvider;
            _refitSettings = refitSettings;
        }
        
        public async Task<ApplicationUser> AddUser(NewApplicationUser newApplicationUser)
        {
            IsBusy = true;

            try
            {
                var httpClient = _httpClientFactory.CreateClient();

                var applicationUsersApi = RestService.For<IApplication_Users>(httpClient, _refitSettings);
                var addUserResponse = await applicationUsersApi.AddUserUsingPOSTAsync(newApplicationUser);
                
                return addUserResponse;
            }
            finally
            {
                IsBusy = false;
            }  
        }
        
        public async Task<ICollection<ApplicationUser>> GetUsers(IEnumerable<string> filterapplicationUserId)
        {
            IsBusy = true;

            try
            {
                var httpClient = _httpClientFactory.CreateClient();

                var applicationUsersApi = RestService.For<IApplication_Users>(httpClient, _refitSettings);
                var usersResponse = await applicationUsersApi.GetUsersUsingGETAsync(filterapplicationUserId);
                
                return usersResponse;
            }
            finally
            {
                IsBusy = false;
            }  
        }
    }
}