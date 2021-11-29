using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Reactive;
using System.Reactive.Linq;
using System.Threading.Tasks;
using Appmilla.Xamarin.Infrastructure.Identity;
using Appmilla.Xamarin.Infrastructure.Reactive;
using Appmilla.Yapily.Refit.Caches;
using Appmilla.Yapily.Refit.Models;
using Appmilla.Yapily.Refit.Queries;
using Appmilla.Yapily.Refit.Storage;
using DynamicData;
using DynamicData.Binding;
using ReactiveUI;
using Xamarin.Essentials.Interfaces;
using Xamarin.Forms;
using YapilyDemo.UX.Features.Shared;

namespace YapilyDemo.UX.Features.AuthenticateLogin
{
    public class WelcomeViewModel : ReactiveObject
    {
        readonly ISchedulerProvider _schedulerProvider;
        readonly IIdentityService _identityService;
        readonly IConnectedInstitutionsCache _connectedInstitutionsCache;
        readonly IUsersQuery _usersQuery;
        readonly ISecureStorage _secureStorage;
        
        ReadOnlyObservableCollection<InstitutionViewModel> _institutions;

        public ReadOnlyObservableCollection<InstitutionViewModel> Institutions
        {
            get => _institutions;
            set => this.RaiseAndSetIfChanged(ref _institutions, value);
        }
        
        private static readonly Func<InstitutionViewModel, Guid> KeySelector = group => group.CacheKey;
        readonly SourceCache<InstitutionViewModel, Guid> _institutionsCache = new SourceCache<InstitutionViewModel, Guid>(KeySelector);

        public ReactiveCommand<Unit, Unit> Login { get; protected set; }

        public WelcomeViewModel(
            ISchedulerProvider schedulerProvider,
            IIdentityService identityService,
            IConnectedInstitutionsCache connectedInstitutionsCache,
            IUsersQuery usersQuery,
            ISecureStorage secureStorage)
        {
            _schedulerProvider = schedulerProvider;
            _identityService = identityService;
            _connectedInstitutionsCache = connectedInstitutionsCache;
            _usersQuery = usersQuery;
            _secureStorage = secureStorage;
            
            Login = ReactiveCommand.CreateFromTask(_ => OnLogin(), outputScheduler: _schedulerProvider.MainThread);
            Login.ThrownExceptions.Subscribe(OnLoginError);
            
            var institutionsSort = SortExpressionComparer<InstitutionViewModel>
                .Ascending(i => i.Name);

            _ = _institutionsCache.Connect()
                .Sort(institutionsSort)
                .Bind(out _institutions)
                .ObserveOn(schedulerProvider.MainThread)        //ensure operation is on the UI thread;
                .DisposeMany()                              //automatic disposal
                .Subscribe();
        }

        /*
        private async Task<Unit> OnLogin()
        {
            var loginResult = await _identityService.Login();

            if (!loginResult.IsError)
            {
                try
                {
                    // create user name from claims info
                    var user_email = loginResult.User.Claims.SingleOrDefault(c => c.Type == "email");
                
                    //see if user exists inyapily
                    if (user_email != null)
                    {
                        string applicationUserId;
                        string userUuid;

                        string userId = user_email.Value;
                        
                        //userId = "alice-smith-appmilla";
                        
                        var filteredUsers = await _usersQuery.GetUsers(new List<string>());
                        
                        if (filteredUsers.All(u => u.ApplicationUserId != userId))
                        {
                            // create user in yapily
                            var createUser = await _usersQuery.AddUser(new NewApplicationUser()
                            {
                                ApplicationUserId = userId
                            });

                            applicationUserId = createUser.ApplicationUserId;
                            userUuid = createUser.Uuid;
                        }
                        else
                        {
                            var existingUser = filteredUsers.Single(u => u.ApplicationUserId == userId);
                        
                            applicationUserId = existingUser.ApplicationUserId;
                            userUuid = existingUser.Uuid;
                        }

                        // store yapily username in secure storage
                        await _secureStorage.SetAsync(StorageKeys.ApplicationUserId, applicationUserId);
                        await _secureStorage.SetAsync(StorageKeys.UserUuid, userUuid);
                    }

                }
                catch (Exception exception)
                {
                    Debug.WriteLine($"Error {exception.Message}");
                    throw;
                }

                if (Institutions.Count > 0)
                {
                    await Shell.Current.GoToAsync("//main");
                }
                else
                {
                    await Shell.Current.GoToAsync("//chooseBank"); 
                }
            }

            return Unit.Default;
        }
        */
        
        private async Task<Unit> OnLogin()
        {
            var loginResult = await _identityService.Login();

            if (!loginResult.IsError)
            {
                try
                {
                    // store yapily username in secure storage
                    await _secureStorage.SetAsync(StorageKeys.ApplicationUserId, "user-1299560");
                    await _secureStorage.SetAsync(StorageKeys.UserUuid, "f9817f34-6a2e-4186-ba6b-41c71ba0d123");
                    
                    Observable.Return(Unit.Default).InvokeCommand(_connectedInstitutionsCache.Load);
                }
                catch (Exception exception)
                {
                    Debug.WriteLine($"Error {exception.Message}");
                    throw;
                }

                await Shell.Current.GoToAsync("//main");
                
                /*
                if (Institutions.Count > 0)
                {
                    await Shell.Current.GoToAsync("//main");
                }
                else
                {
                    await Shell.Current.GoToAsync("//chooseBank"); 
                }
                */
            }

            return Unit.Default;
        }
        void OnLoginError(Exception exception)
        {
            Debug.WriteLine($"Login Error {exception.Message}");
        }
    }
}