using System;
using System.Diagnostics;
using System.Reactive;
using System.Threading.Tasks;
using Appmilla.Xamarin.Infrastructure.Framework;
using Appmilla.Xamarin.Infrastructure.Reactive;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using Xamarin.Forms;

namespace YapilyDemo.UX.Features.Payments
{    
    public class PaymentsViewModel : ReactiveObject, INavigationAware
    {
        readonly ISchedulerProvider _schedulerProvider;

        [Reactive] public string Title { get; private set; } = "Payments";
        
        public PaymentsViewModel(
            ISchedulerProvider schedulerProvider)
        {
            _schedulerProvider = schedulerProvider;
        }

        public Task OnViewAppearing()
        {
            return Task.CompletedTask;
        }

        public Task OnViewDisappearing()
        {
            return Task.CompletedTask;
        }
    }
}
