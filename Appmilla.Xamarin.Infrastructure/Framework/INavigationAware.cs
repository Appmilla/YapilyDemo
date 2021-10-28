using System.Threading.Tasks;

namespace Appmilla.Xamarin.Infrastructure.Framework
{
    public interface INavigationAware
    {
        Task OnViewAppearing();

        Task OnViewDisappearing();
    }
}