using System.Threading.Tasks;
using Appmilla.Xamarin.Infrastructure.Reactive;
using Appmilla.Yapily.Refit.Apis;
using Appmilla.Yapily.Refit.Http;
using Appmilla.Yapily.Refit.Models;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using Refit;

namespace Appmilla.Yapily.Refit.Queries
{
    public interface ISinglePaymentQuery
    {
        Task<ApiResponseOfPaymentAuthorisationRequestResponse> CreatePaymentAuthorisationRequest(
            PaymentAuthorisationRequest paymentAuthRequest);
        
    }
    
    public class SinglePaymentQuery : ReactiveObject, ISinglePaymentQuery
    {
        readonly IYapilyHttpClientFactory _httpClientFactory;
        readonly ISchedulerProvider _schedulerProvider;
        readonly RefitSettings _refitSettings;
        
        [Reactive] public bool IsBusy { get; set; }
        
        public SinglePaymentQuery(IYapilyHttpClientFactory httpClientFactory,
            ISchedulerProvider schedulerProvider,
            RefitSettings refitSettings)
        {
            _httpClientFactory = httpClientFactory;
            _schedulerProvider = schedulerProvider;
            _refitSettings = refitSettings;
        }
        
        public async Task<ApiResponseOfPaymentAuthorisationRequestResponse> CreatePaymentAuthorisationRequest(PaymentAuthorisationRequest paymentAuthRequest)
        {
            IsBusy = true;

            try
            {
                var httpClient = _httpClientFactory.CreateClient();

                var paymentsApi = RestService.For<IPayments>(httpClient, _refitSettings);
                var paymentAuthorisationResponse = await paymentsApi.CreatePaymentAuthorisationUsingPOSTAsync(paymentAuthRequest);
                
                return paymentAuthorisationResponse;
            }
            finally
            {
                IsBusy = false;
            }  
        }
    }
}