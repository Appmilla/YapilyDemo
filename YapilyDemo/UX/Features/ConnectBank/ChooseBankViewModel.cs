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
using Appmilla.Yapily.Refit.Caches;
using Appmilla.Yapily.Refit.Database;
using Appmilla.Yapily.Refit.Models;
using Appmilla.Yapily.Refit.Queries;
using DynamicData;
using DynamicData.Binding;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using Xamarin.Essentials;
using Xamarin.Essentials.Interfaces;
using Xamarin.Forms;
using YapilyDemo.Framework;
using YapilyDemo.UX.Features.Shared;

namespace YapilyDemo.UX.Features.ConnectBank
{
    public class ChooseBankViewModel : ReactiveObject, IViewModel, INavigationAware
    {
        readonly ISchedulerProvider _schedulerProvider;
        readonly IInstituitionsQuery _instituitionsQuery;
        readonly IAccountsQuery _accountsQuery;
        readonly ITransactionsQuery _transactionsQuery;
        //readonly IConnectedInstitutionsDb _connectedInstitutionsDb;
        readonly ISecureStorage _secureStorage;
        readonly IConnectedInstitutionsCache _connectedInstitutionsCache;
        
        public string Id => NavigationPageKeys.ChooseBankPageKey;

        ReadOnlyObservableCollection<InstitutionViewModel> _institutions;

        public ReadOnlyObservableCollection<InstitutionViewModel> Institutions
        {
            get => _institutions;
            set => this.RaiseAndSetIfChanged(ref _institutions, value);
        }

        private static readonly Func<InstitutionViewModel, Guid> KeySelector = group => group.CacheKey;
        readonly SourceCache<InstitutionViewModel, Guid> _institutionsCache = new SourceCache<InstitutionViewModel, Guid>(KeySelector);

        [ObservableAsProperty]
        // ReSharper disable once UnassignedGetOnlyAutoProperty
        public bool IsBusy { get; }
        
        public ReactiveCommand<Unit, ApiListResponseOfInstitution> Load { get; }

        public ReactiveCommand<Unit, ApiListResponseOfInstitution> Refresh { get; }

        public ReactiveCommand<Unit, Unit> CancelInFlightQueries { get; }

        public ReactiveCommand<InstitutionViewModel, bool> ConnectBank { get; protected set; }

        public ChooseBankViewModel(
            ISchedulerProvider schedulerProvider,
            IApplicationQuery applicationQuery,
            IInstituitionsQuery instituitionsQuery,
            IAccountsQuery accountsQuery,
            ITransactionsQuery transactionsQuery,
            //IConnectedInstitutionsDb connectedInstitutionsDb,
            ISecureStorage secureStorage,
            IConnectedInstitutionsCache connectedInstitutionsCache)
        {
            _schedulerProvider = schedulerProvider;
            _instituitionsQuery = instituitionsQuery;
            _accountsQuery = accountsQuery;
            _transactionsQuery = transactionsQuery;
            //_connectedInstitutionsDb = connectedInstitutionsDb;
            _secureStorage = secureStorage;
            _connectedInstitutionsCache = connectedInstitutionsCache;
            
            this.WhenAnyValue(x => x._instituitionsQuery.IsBusy)
                .ObserveOn(schedulerProvider.MainThread)
                .ToPropertyEx(this, x => x.IsBusy, scheduler: _schedulerProvider.MainThread);

            Load = ReactiveCommand.CreateFromObservable(
                () => _instituitionsQuery.GetInstitutions(GetCacheKey()).TakeUntil(CancelInFlightQueries),
                this.WhenAnyValue(x => x.IsBusy).Select(x => !x),
                outputScheduler: _schedulerProvider.ThreadPool);
            Load.ThrownExceptions.Subscribe(Institutions_OnError);
            Load.Subscribe(Institutions_OnNext);

            Refresh = ReactiveCommand.CreateFromObservable(
                () => _instituitionsQuery.GetInstitutions(GetCacheKey()).TakeUntil(CancelInFlightQueries),
                this.WhenAnyValue(x => x.IsBusy).Select(x => !x),
                outputScheduler: _schedulerProvider.ThreadPool);
            Refresh.ThrownExceptions.Subscribe(Institutions_OnError);
            Refresh.Subscribe(Institutions_OnNext);

            CancelInFlightQueries = ReactiveCommand.Create(
                () => { },
                this.WhenAnyObservable(x => x.Load.IsExecuting, y => y.Refresh.IsExecuting, (x, y) => x || y));

            var institutionsSort = SortExpressionComparer<InstitutionViewModel>
                .Ascending(i => i.Name);

            _ = _institutionsCache.Connect()
                .Sort(institutionsSort)
                .Bind(out _institutions)
                .ObserveOn(schedulerProvider.MainThread)        //ensure operation is on the UI thread;
                .DisposeMany()                              //automatic disposal
                .Subscribe();

            ConnectBank = ReactiveCommand.CreateFromTask<InstitutionViewModel, bool>(OnConnectBank, outputScheduler: _schedulerProvider.MainThread);
            ConnectBank.ThrownExceptions.Subscribe(OnError);
        }
        
        private async Task<bool> OnConnectBank(InstitutionViewModel institutionViewModel)
        {
            try
            {
                var applicationUserId = await _secureStorage.GetAsync(StorageKeys.ApplicationUserId);
                var userUuid = await _secureStorage.GetAsync(StorageKeys.UserUuid);
               
                var authRequest = new AccountAuthorisationRequest()
                {
                    UserUuid = userUuid,
                    ApplicationUserId = applicationUserId,
                    InstitutionId = institutionViewModel.Id,
                    Callback = "com.appmilla.yapilydemo://callback"
                };
                
                /*
                var authRequest = new AccountAuthorisationRequest()
                {
                    UserUuid = "f9817f34-6a2e-4186-ba6b-41c71ba0d123",
                    ApplicationUserId = "user-1299560",
                    InstitutionId = institutionViewModel.Id,
                    //Callback = "https://display-parameters.com/"
                    Callback = "com.appmilla.yapilydemo://callback"
                };
                */
                
                var authResponse = await _accountsQuery.InitiateAccountRequest(authRequest);

                Debug.WriteLine(authResponse);
                
                var authResult = await WebAuthenticator.AuthenticateAsync(new Uri(authResponse.Data.AuthorisationUrl), new Uri(authRequest.Callback));
                
                Debug.WriteLine(authResult);

                if (authResult.Properties.ContainsKey("consent"))
                {
                    string consentToken;
                    if (authResult.Properties.TryGetValue("consent", out consentToken))
                    {
                        //await _secureStorage.SetAsync($"{institutionViewModel.Id}-consent-token", consentToken);
                        //await SaveInstitutionConnection(consentToken, institutionViewModel);
                        
                        await _connectedInstitutionsCache.Refresh.Execute();
                        
                        await Shell.Current.GoToAsync("//main");
                    }
                }
            }
            catch (Exception exception)
            {
                Debug.WriteLine($"Error {exception.Message}");
                throw;
            }
            
            return true;
        }
        
        /*
        private async Task SaveInstitutionConnection(string consentToken, InstitutionViewModel institutionViewModel)
        {
            var saved = await _connectedInstitutionsDb.SaveInstitutionAsync(new ConnectedInstitution
            {
                InstitutionId = institutionViewModel.Id,
                FullName = institutionViewModel.FullName,
                Name = institutionViewModel.Name,
                ImageUrl = institutionViewModel.ImageUrl
            });
            
            
            try
            {
                //web authenticator modelo
                //"com.appmilla.yapilydemo://callback?application-user-id=user-1299560&user-uuid=f9817f34-6a2e-4186-ba6b-41c71ba0d123&institution=modelo-sandbox&error=access_denied&error-source=user&error-description=aW5jb3JyZWN0IGNyZWRlbnRpYWxzLiBDb3VsZCBub3QgZmluZCBhIGN1c3RvbWVyIHdpdGggdXNl%0AciBuYW1lIE1pdHMgYW5kIHBhc3N3b3JkIG1pdHM%3D";
                //var consentToken =
                //    "com.appmilla.yapilydemo://callback?application-user-id=user-1299560&user-uuid=f9817f34-6a2e-4186-ba6b-41c71ba0d123&institution=modelo-sandbox&error=access_denied&error-source=user&error-description=aW5jb3JyZWN0IGNyZWRlbnRpYWxzLiBDb3VsZCBub3QgZmluZCBhIGN1c3RvbWVyIHdpdGggdXNl%0AciBuYW1lIE1pdHMgYW5kIHBhc3N3b3JkIG1pdHM%3D";
                //modelo
                //var consentToken = "eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzUxMiJ9.eyJJTlNUSVRVVElPTiI6Im1vZGVsby1zYW5kYm94IiwiQ09OU0VOVCI6IjJiNWM0OTMwLTU4ZjItNGY4OS1iOTA0LTgzMmQ3NzliNDkzMCIsIkFQUExJQ0FUSU9OX1VTRVJfSUQiOiJ1c2VyLTEyOTk1NjAiLCJVU0VSIjoiZjk4MTdmMzQtNmEyZS00MTg2LWJhNmItNDFjNzFiYTBkMTIzIn0.0d1GvfT1PApZPS27fm99nWgGUvOuSq8fiZotzeqSc_z4IE2g_gjjuZlJGmWE7fFk7NkfABMWClQZZpiVnw_Jaw";
                
                //barclays
                //var consentToken =
                //    "eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzUxMiJ9.eyJJTlNUSVRVVElPTiI6ImJhcmNsYXlzLXNhbmRib3giLCJDT05TRU5UIjoiNTEyNjVkM2QtOTBjMS00MTJlLTg0NjQtN2UzZjdhN2QzYjI4IiwiQVBQTElDQVRJT05fVVNFUl9JRCI6InVzZXItMTI5OTU2MCIsIlVTRVIiOiJmOTgxN2YzNC02YTJlLTQxODYtYmE2Yi00MWM3MWJhMGQxMjMifQ.amcw-1famOOiOAuNGpMoIusmrSHnpZc6TaQo3WQMTfuF8UqiwzTqUSBO3LISjejY6sVUgg0dEfg_YPTo2tLNIA";
                await _secureStorage.SetAsync($"{institutionViewModel.Id}-consent-token", consentToken);
            }
            catch (Exception exception)
            {
                Debug.WriteLine($"Error {exception.Message}");
                throw;
            }
        }
        */
        
        /*
        private async Task<bool> OnConnectBank(InstitutionViewModel institutionViewModel)
        {
            await SaveInstitutionConnection(institutionViewModel);
            
            //modelo
            //var consentToken =
            //    "eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzUxMiJ9.eyJJTlNUSVRVVElPTiI6Im1vZGVsby1zYW5kYm94IiwiQ09OU0VOVCI6IjJiNWM0OTMwLTU4ZjItNGY4OS1iOTA0LTgzMmQ3NzliNDkzMCIsIkFQUExJQ0FUSU9OX1VTRVJfSUQiOiJ1c2VyLTEyOTk1NjAiLCJVU0VSIjoiZjk4MTdmMzQtNmEyZS00MTg2LWJhNmItNDFjNzFiYTBkMTIzIn0.0d1GvfT1PApZPS27fm99nWgGUvOuSq8fiZotzeqSc_z4IE2g_gjjuZlJGmWE7fFk7NkfABMWClQZZpiVnw_Jaw";
            
            //barclays
            var consentToken =
                "eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzUxMiJ9.eyJJTlNUSVRVVElPTiI6ImJhcmNsYXlzLXNhbmRib3giLCJDT05TRU5UIjoiNTEyNjVkM2QtOTBjMS00MTJlLTg0NjQtN2UzZjdhN2QzYjI4IiwiQVBQTElDQVRJT05fVVNFUl9JRCI6InVzZXItMTI5OTU2MCIsIlVTRVIiOiJmOTgxN2YzNC02YTJlLTQxODYtYmE2Yi00MWM3MWJhMGQxMjMifQ.amcw-1famOOiOAuNGpMoIusmrSHnpZc6TaQo3WQMTfuF8UqiwzTqUSBO3LISjejY6sVUgg0dEfg_YPTo2tLNIA";
            
            var accounts = await _accountsQuery.GetAccounts(consentToken, $"{institutionViewModel.Id}--accounts");
            
                var transactionTest =
                    await _transactionsQuery.GetTransactions("1234000000000010", "1234000000000010--transactions");

            foreach (var account in accounts.Data)
            {
                var transactions =
                    await _transactionsQuery.GetTransactions(account.Id, $"{account.Id}--transactions");
                
                Debug.WriteLine(transactions);
            }
            return true;
        }
        */
        
        /*
        private async Task<bool> OnConnectBank(InstitutionViewModel institutionViewModel)
        {

            var url = "https://ob19-auth1-ui.o3bank.co.uk/auth?client_id=1d84906b-9a71-4ed3-88e1-c71347defb6e&response_type=code+id_token&state=077a7da9cdcf4958964526322e9eae07&nonce=077a7da9cdcf4958964526322e9eae07&scope=openid+accounts&redirect_uri=https%3A%2F%2Fauth.yapily.com%2F&request=eyJraWQiOiJnRTRvU3VaZDl4TVpUNXZDdTNWYy1mdktNak0iLCJhbGciOiJQUzI1NiJ9.eyJhdWQiOiJodHRwczovL29iMTktYXV0aDEtdWkubzNiYW5rLmNvLnVrIiwic2NvcGUiOiJvcGVuaWQgYWNjb3VudHMiLCJpc3MiOiIxZDg0OTA2Yi05YTcxLTRlZDMtODhlMS1jNzEzNDdkZWZiNmUiLCJjbGllbnRfaWQiOiIxZDg0OTA2Yi05YTcxLTRlZDMtODhlMS1jNzEzNDdkZWZiNmUiLCJyZXNwb25zZV90eXBlIjoiY29kZSBpZF90b2tlbiIsInJlZGlyZWN0X3VyaSI6Imh0dHBzOi8vYXV0aC55YXBpbHkuY29tLyIsInN0YXRlIjoiMDc3YTdkYTljZGNmNDk1ODk2NDUyNjMyMmU5ZWFlMDciLCJjbGFpbXMiOnsiaWRfdG9rZW4iOnsiYWNyIjp7InZhbHVlIjoidXJuOm9wZW5iYW5raW5nOnBzZDI6c2NhIiwiZXNzZW50aWFsIjp0cnVlfSwib3BlbmJhbmtpbmdfaW50ZW50X2lkIjp7InZhbHVlIjoiYWFjLThhOWZkNmFiLTY0OGItNGFiYS04NGIzLTU1ODU1ZjJmMzBjMSIsImVzc2VudGlhbCI6dHJ1ZX19LCJ1c2VyaW5mbyI6eyJvcGVuYmFua2luZ19pbnRlbnRfaWQiOnsidmFsdWUiOiJhYWMtOGE5ZmQ2YWItNjQ4Yi00YWJhLTg0YjMtNTU4NTVmMmYzMGMxIiwiZXNzZW50aWFsIjp0cnVlfX19LCJub25jZSI6IjA3N2E3ZGE5Y2RjZjQ5NTg5NjQ1MjYzMjJlOWVhZTA3IiwianRpIjoiZjM0NWY5YjgtYWFkMC00YWU3LWIxNWItZTE0NmY4ZDMxYTFiIiwiaWF0IjoxNjM1MDgxNzA5LCJleHAiOjE2MzUwODM1MDl9.bBklfzYo4CjiSTa4w35v-VVI3JQ75p6q0PJvQiLkOSFTp_8E-YjqGER1hmXhSyTFOtJWwCZQAUY8nqFD66mfalWqq3dPAp58cB7yXNNe0Nnxul20WHr35WvVkfSeFxqtwIByq5rJ58QU-CcVgJiko-Wai2hGsCIpXqmvdhcrB4cnINo0hffeGvZiFhY6xRy00SumBF8R_JbzMkBURxGtZWC-q_OcQMGC5vEr8MUk4aO3SoXke-ImBOq9Ih3SOIx9R9fAO7pXbU5qLyOPSlFvlo0eijtU1ECA5RiFcrdr7RBZ3N4-oJ0OqPKdiHyqcSSxOx2nSr0-_0W9Wi6Wv5J3RQ";

            var authResult = await WebAuthenticator.AuthenticateAsync(new Uri(url), new Uri("https://app.walldo.com/callback"));

            return true;
        }
        */

        string GetCacheKey()
        {
            return $"yapily/institutions";
        }
        
        /*
        private async Task<bool> OnInstitutions()
        {
            //var institutions = _instituitionsQuery.GetInstitutions(GetCacheKey("Rich")).Subscribe(OnInstitutionsNext, OnError);

            var institutions = await _instituitionsQuery.GetInstitutions(GetCacheKey("institutions")).FirstAsync();

            return true;
        }
        */
        
        public void Institutions_OnNext(ApiListResponseOfInstitution institutionsList)
        {
            var results = institutionsList.Data.Select(i => new InstitutionViewModel()
            {
                CacheKey = GuidUtility.GetDeterministicGuid($"{i.Id}"),
                Countries = i.Countries,
                CredentialsType = i.CredentialsType,
                EnvironmentType = i.EnvironmentType,
                Features = i.Features,
                FullName = i.FullName,
                Id = i.Id,
                Media = i.Media,
                Monitoring = i.Monitoring,
                Name = i.Name,
                ImageUrl = i.Media.SingleOrDefault(m => m.Type == "logo")?.Source
            });
            
            _schedulerProvider.MainThread.Schedule(_ =>
            {
                _institutionsCache.UpdateCache(results, KeySelector);
            });
        }
        
        void Institutions_OnError(Exception exception)
        {
            Debug.WriteLine($"Error {exception.Message}");
        }

        public Task OnViewAppearing()
        {
            Observable.Return(Unit.Default).InvokeCommand(Load);
            
            return Task.CompletedTask;
        }

        public Task OnViewDisappearing()
        {
            return Task.CompletedTask;
        }
        
        void OnError(Exception exception)
        {
            Debug.WriteLine($"Error {exception.Message}");
        }
    }
}