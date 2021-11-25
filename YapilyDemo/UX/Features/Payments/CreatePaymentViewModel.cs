using System.Threading.Tasks;
using Appmilla.Xamarin.Infrastructure.Framework;
using Appmilla.Xamarin.Infrastructure.Reactive;
using Appmilla.Yapily.Refit.Queries;
using ReactiveUI;
using YapilyDemo.Framework;

namespace YapilyDemo.UX.Features.Payments
{
    public class CreatePaymentViewModel : ReactiveObject, IViewModel, INavigationAware
    {
        readonly ISchedulerProvider _schedulerProvider;
        readonly ISinglePaymentQuery _singlePaymentQuery;
        
        public string Id => NavigationPageKeys.ChooseBankPageKey;
        
        public CreatePaymentViewModel(
            ISchedulerProvider schedulerProvider,
            ISinglePaymentQuery singlePaymentQuery)
        {
            _schedulerProvider = schedulerProvider;
            _singlePaymentQuery = singlePaymentQuery;
            
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