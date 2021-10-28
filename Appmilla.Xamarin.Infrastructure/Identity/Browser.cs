using System;
using System.Threading;
using System.Threading.Tasks;
using IdentityModel.OidcClient.Browser;
using Xamarin.Essentials;

namespace Appmilla.Xamarin.Infrastructure.Identity
{
    public class Browser : IBrowser
    {
        private readonly IIdentityConfiguration _identityConfiguration;
        
        public Browser(
            IIdentityConfiguration identityConfiguration)
        {
            _identityConfiguration = identityConfiguration;
        }
        
        public async Task<BrowserResult> InvokeAsync(BrowserOptions options, CancellationToken cancellationToken = default)
        {
            WebAuthenticatorResult authResult = await WebAuthenticator.AuthenticateAsync(
                new Uri(options.StartUrl),
                new Uri(_identityConfiguration.RedirectUri));
            return new BrowserResult()
            {
                Response = ParseAuthenticatorResult(authResult)
            };
        }

        string ParseAuthenticatorResult(WebAuthenticatorResult result)
        {
            string code = result?.Properties["code"];
            string scope = result?.Properties["scope"];
            string state = result?.Properties["state"];
            string sessionState = result?.Properties["session_state"];
            return $"{_identityConfiguration.RedirectUri}#code={code}&scope={scope}&state={state}&session_state={sessionState}";
        }
    }
}