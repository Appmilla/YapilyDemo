using System.Reactive.Concurrency;
using System.Reactive.Disposables;
using System.Threading.Tasks;
using Appmilla.Xamarin.Infrastructure.Reactive;
using Xamarin.Forms;
using CommonServiceLocator;

namespace Appmilla.Xamarin.Infrastructure.Framework
{
    public class BaseView : ContentPage
    {
        readonly ISchedulerProvider _schedulerProvider;
     
        public BaseView()
        {
            _schedulerProvider = ServiceLocator.Current.GetInstance<ISchedulerProvider>();
        }
        
        public void SendOnAppearing()
        {
            OnAppearing();
        }

        public void SendOnDisappearing()
        {
            OnDisappearing();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            
            _schedulerProvider.MainThread.ScheduleAsync(async (ctrl, ct) =>
            {
                await ((BindingContext as INavigationAware)?.OnViewAppearing() ?? Task.CompletedTask);
                
                return Disposable.Empty;
            });
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();

            _schedulerProvider.MainThread.ScheduleAsync(async (ctrl, ct) =>
            {
                await ((BindingContext as INavigationAware)?.OnViewDisappearing() ?? Task.CompletedTask);
                
                return Disposable.Empty;
            });
        }
    }
}