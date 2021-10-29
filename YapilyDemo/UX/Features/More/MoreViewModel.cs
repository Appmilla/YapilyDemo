using System.Threading.Tasks;
using Appmilla.Xamarin.Infrastructure.Framework;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;

namespace YapilyDemo.UX.Features.More
{    
    public class MoreViewModel : ReactiveObject, INavigationAware
    {
        [Reactive]
        public string Title { get; private set; } = "More page";

        public MoreViewModel()
        {
        }

        public Task OnViewAppearing()
        {
            //Observable.Return(Unit.Default).InvokeCommand(Load);

            return Task.CompletedTask;
        }

        public Task OnViewDisappearing()
        {
            return Task.CompletedTask;
        }
    }
}
