namespace Appmilla.Xamarin.Infrastructure.Identity
{
    public interface IIdentityConfiguration
    {
        string AuthorityUri { get; set; }
        
        string RedirectUri { get; set; }
        
        string ApiUri { get; set; }
        
        string ClientId { get; set; }
        
        string Scope { get; set; }
    }
}