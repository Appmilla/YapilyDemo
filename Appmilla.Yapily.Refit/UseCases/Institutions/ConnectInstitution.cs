using System;
using System.Diagnostics;
using System.Reactive.Linq;
using System.Threading.Tasks;
using Appmilla.Yapily.Refit.Caches;
using Appmilla.Yapily.Refit.Models;
using Appmilla.Yapily.Refit.Queries;
using Appmilla.Yapily.Refit.Storage;
using Xamarin.Essentials;
using Xamarin.Essentials.Interfaces;
using Xamarin.Forms;

namespace Appmilla.Yapily.Refit.UseCases.Institutions
{
    public interface IConnectInstitution
    {
        Task<bool> ConnectBank(string institutionId);
    }
    
    public class ConnectInstitution : IConnectInstitution
    {
        readonly IAccountsQuery _accountsQuery;
        readonly ISecureStorage _secureStorage;
        readonly IConnectedInstitutionsCache _connectedInstitutionsCache;
        
        public ConnectInstitution(
            IAccountsQuery accountsQuery,
            ISecureStorage secureStorage,
            IConnectedInstitutionsCache connectedInstitutionsCache)
        {
            _accountsQuery = accountsQuery;
            _secureStorage = secureStorage;
            _connectedInstitutionsCache = connectedInstitutionsCache;
        }
        
        public async Task<bool> ConnectBank(string institutionId)
        {
            bool connected = false;
            
            try
            {
                var applicationUserId = await _secureStorage.GetAsync(StorageKeys.ApplicationUserId);
                var userUuid = await _secureStorage.GetAsync(StorageKeys.UserUuid);
               
                var authRequest = new AccountAuthorisationRequest()
                {
                    UserUuid = userUuid,
                    ApplicationUserId = applicationUserId,
                    InstitutionId = institutionId,
                    Callback = "com.intuitive.yapilydemo://callback"
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
                        await _secureStorage.SetAsync($"{institutionId}-consent-token", consentToken);
                        
                        await _connectedInstitutionsCache.Refresh.Execute();

                        connected = true;
                    }
                }
            }
            catch (Exception exception)
            {
                Debug.WriteLine($"Error {exception.Message}");
                throw;
            }

            return connected;
        }
    }
}