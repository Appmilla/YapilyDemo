using System;
using System.Threading.Tasks;
using IdentityModel.OidcClient;
using Xamarin.Essentials.Interfaces;

namespace Appmilla.Xamarin.Infrastructure.Identity
{
    public class IdentityService : IIdentityService
    {
        readonly IIdentityConfiguration _identityConfiguration;
        readonly ISecureStorage _secureStorage;
        
        OidcClient _oidcClient;
        LoginResult _loginResult;
        
        public IdentityService(
            IIdentityConfiguration identityConfiguration,
            ISecureStorage secureStorage)
        {
            _identityConfiguration = identityConfiguration;
            _secureStorage = secureStorage;
        }
        
        public async Task<bool> Login()
        {
            var result = false;
            
            var options = new OidcClientOptions
            {
                Authority = _identityConfiguration.AuthorityUri,
                ClientId = _identityConfiguration.ClientId,
                Scope = _identityConfiguration.Scope,
                RedirectUri = _identityConfiguration.RedirectUri,
                ResponseMode = OidcClientOptions.AuthorizeResponseMode.Redirect,
                Browser = new Browser(_identityConfiguration)
            };

            _oidcClient = new OidcClient(options);
            _loginResult = await _oidcClient.LoginAsync(new LoginRequest());
            if (!_loginResult.IsError)
            {
                try
                {
                    ClearStore();

                    await _secureStorage.SetAsync(IdentityKeys.AccessToken, _loginResult.AccessToken);
                    await _secureStorage.SetAsync(IdentityKeys.RefreshToken, _loginResult.RefreshToken);
                    await _secureStorage.SetAsync(IdentityKeys.ExpiryDateTime, _loginResult.AuthenticationTime.Ticks.ToString());
                    await _secureStorage.SetAsync(IdentityKeys.TokenType, _loginResult.TokenResponse.TokenType);
                    await _secureStorage.SetAsync(IdentityKeys.IdToken, _loginResult.IdentityToken);
                }
                catch (Exception ex)
                {
                    //_errorReporter.TrackError(ex);
                }
            }

            result = !_loginResult.IsError;
            
            return result;
        }
        
        public void ClearStore()
        {
            _secureStorage.Remove(IdentityKeys.IdToken);
            _secureStorage.Remove(IdentityKeys.AccessToken);
            _secureStorage.Remove(IdentityKeys.RefreshToken);
            _secureStorage.Remove(IdentityKeys.TokenType);
            _secureStorage.Remove(IdentityKeys.ExpiryDateTime);
        }
    }
}