using System;
using System.Diagnostics;
using System.Linq;
using System.Reactive;
using System.Reactive.Linq;
using System.Threading.Tasks;
using Appmilla.Xamarin.Infrastructure.Reactive;
using Appmilla.Yapily.Refit.Models;
using Appmilla.Yapily.Refit.Queries;
using ReactiveUI;
using YapilyDemo.Framework;

namespace YapilyDemo.UX
{
    public class MainViewModel : ReactiveObject, IViewModel
    {
        readonly ISchedulerProvider _schedulerProvider;
        readonly IApplicationQuery _applicationQuery;
        readonly IInstituitionsQuery _instituitionsQuery;
        readonly IAccountsQuery _accountsQuery;
        
        public string Id => NavigationPageKeys.MainPageKey;
        
        public ReactiveCommand<Unit, bool> Application { get; protected set; }
        
        public ReactiveCommand<Unit, bool> Institutions { get; protected set; }
        
        public MainViewModel(
            ISchedulerProvider schedulerProvider,
            IApplicationQuery applicationQuery,
            IInstituitionsQuery instituitionsQuery,
            IAccountsQuery accountsQuery)
        {
            _schedulerProvider = schedulerProvider;
            _applicationQuery = applicationQuery;
            _instituitionsQuery = instituitionsQuery;
            _accountsQuery = accountsQuery;
            
            Application = ReactiveCommand.CreateFromTask(_ => OnApplication(), outputScheduler: _schedulerProvider.MainThread);
            Application.ThrownExceptions.Subscribe(OnError);
            
            Institutions = ReactiveCommand.CreateFromTask(_ => OnInstitutions(), outputScheduler: _schedulerProvider.MainThread);
            Institutions.ThrownExceptions.Subscribe(OnError);
        }
        
        string GetCacheKey(string id)
        {
            return $"{id}-yapily/application";
        }
        
        private async Task<bool> OnApplication()
        {
            var application = await _applicationQuery.GetApplication(GetCacheKey("application"));

            return true;
        }

        private async Task<bool> OnInstitutions()
        {
            var institutions = await _instituitionsQuery.GetInstitutions(GetCacheKey("institutions")).FirstAsync();

            var institutionId = institutions.Data.First().Id;
            var institution = await _instituitionsQuery.GetInstitution(institutionId, GetCacheKey($"institution--{institutionId}")).FirstAsync();
    
            return true;
        }

        public void OnInstitutionsNext(ApiListResponseOfInstitution institutionsList)
        {
            
        }
        
        void OnError(Exception exception)
        {
            Debug.WriteLine("Error {exception.Message}");
        }
    }
}