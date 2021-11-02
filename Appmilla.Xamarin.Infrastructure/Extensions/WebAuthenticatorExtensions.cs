using Xamarin.Essentials;

namespace Appmilla.Xamarin.Infrastructure.Extensions
{
    public static class WebAuthenticatorExtensions
    {
        public static string GetConsentToken(this WebAuthenticatorResult value)
        {
            return value.Get("consent");
        }
    }
}