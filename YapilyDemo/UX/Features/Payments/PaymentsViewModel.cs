using System.Threading.Tasks;
using Appmilla.Xamarin.Infrastructure.Framework;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;

namespace YapilyDemo.UX.Features.Payments
{    
    public class PaymentsViewModel : ReactiveObject, INavigationAware
    {
        [Reactive]
        public string Title { get; private set; } = "Payments page";

        public PaymentsViewModel()
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
