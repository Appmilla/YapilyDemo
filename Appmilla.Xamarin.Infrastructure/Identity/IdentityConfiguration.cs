namespace Appmilla.Xamarin.Infrastructure.Identity
{
    public class IdentityConfiguration : IIdentityConfiguration
    {
        public string AuthorityUri { get; set; }
        
        public string RedirectUri { get; set; }
        
        public string ApiUri { get; set; }
        
        public string ClientId { get; set; }
        
        public string Scope { get; set; }
    }
}