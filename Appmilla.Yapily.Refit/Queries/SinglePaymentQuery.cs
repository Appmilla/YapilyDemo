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

        Task<ApiResponseOfPaymentResponse> CreatePaymentRequest(string consentToken,
            PaymentRequest paymentRequest);

        Task<ApiResponseOfPaymentResponse> GetPaymentStatus(string consentToken, string paymentId);

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
        
        public async Task<ApiResponseOfPaymentResponse> CreatePaymentRequest(string consentToken, PaymentRequest paymentRequest)
        {
            IsBusy = true;

            try
            {
                var httpClient = _httpClientFactory.CreateClient();

                var paymentsApi = RestService.For<IPayments>(httpClient, _refitSettings);
                var paymentResponse = await paymentsApi.CreatePaymentUsingPOSTAsync(consentToken, paymentRequest);
                
                return paymentResponse;
            }
            finally
            {
                IsBusy = false;
            }  
        }
        
        public async Task<ApiResponseOfPaymentResponse> GetPaymentStatus(string consentToken, string paymentId)
        {
            IsBusy = true;

            try
            {
                var httpClient = _httpClientFactory.CreateClient();

                var paymentsApi = RestService.For<IPayments>(httpClient, _refitSettings);
                var paymentResponse = await paymentsApi.GetPaymentStatusUsingGETAsync(consentToken, paymentId);
                
                return paymentResponse;
            }
            finally
            {
                IsBusy = false;
            }  
        }
        
        //Task<ApiResponseOfPaymentResponse> CreatePaymentUsingPOSTAsync([Body][AliasAs("paymentRequest")] PaymentRequest paymentRequest);

    }
}