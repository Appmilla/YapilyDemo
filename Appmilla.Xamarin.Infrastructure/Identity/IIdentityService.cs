using System.Threading.Tasks;

namespace Appmilla.Xamarin.Infrastructure.Identity
{
    public interface IIdentityService
    {
        Task<bool> Login();
    }
}