using System.Threading.Tasks;
using IdentityModel.OidcClient;

namespace Appmilla.Xamarin.Infrastructure.Identity
{
    public interface IIdentityService
    {
        Task<LoginResult> Login();
    }
}