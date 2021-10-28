using System.Threading.Tasks;
using Appmilla.Yapily.Refit.Models;
using Refit;

namespace Appmilla.Yapily.Refit.Apis
{
    public interface IPayments
    {
        /// <summary>
        /// Initiate bulk payment for user to authorise
        /// </summary>
        /// <param name="paymentAuthRequest">paymentAuthRequest</param>
        /// <returns>OK</returns>
        [Post("/bulk-payment-auth-requests")]
        [Headers("x-yapily-api-version: 1.0", "Authorization: Basic", "psu-id","psu-corporate-id","psu-ip-address")] 
        Task<ApiResponseOfPaymentAuthorisationRequestResponse> CreateBulkPaymentAuthorisationUsingPOSTAsync([Body][AliasAs("paymentAuthRequest")] BulkPaymentAuthorisationRequest paymentAuthRequest);

        /// <summary>
        /// Create bulk payment
        /// </summary>
        /// <param name="paymentRequest">paymentRequest</param>
        /// <returns>OK</returns>
        [Post("/bulk-payments")]
        [Headers("x-yapily-api-version: 1.0", "Authorization: Basic", "consent","psu-id","psu-corporate-id","psu-ip-address")] 
        Task<ApiResponseOfPaymentResponse> CreateBulkPaymentUsingPOSTAsync([Body][AliasAs("paymentRequest")] BulkPaymentRequest paymentRequest);

        /// <summary>
        /// Initiate a payment for user to authorise
        /// </summary>
        /// <param name="paymentAuthRequest">paymentAuthRequest</param>
        /// <returns>OK</returns>
        [Post("/payment-auth-requests")]
        [Headers("x-yapily-api-version: 1.0", "Authorization: Basic", "psu-id","psu-corporate-id","psu-ip-address")] 
        Task<ApiResponseOfPaymentAuthorisationRequestResponse> CreatePaymentAuthorisationUsingPOSTAsync([Body][AliasAs("paymentAuthRequest")] PaymentAuthorisationRequest paymentAuthRequest);

        /// <summary>
        /// Update pre authorize consent for user to authorise payment
        /// </summary>
        /// <param name="paymentAuthRequest">paymentAuthRequest</param>
        /// <returns>OK</returns>
        [Put("/payment-auth-requests")]
        [Headers("x-yapily-api-version: 1.0", "Authorization: Basic", "psu-id","psu-corporate-id","psu-ip-address","consent")] 
        Task<ApiResponseOfPaymentAuthorisationRequestResponse> UpdatePaymentAuthorisationUsingPUTAsync([Body][AliasAs("paymentAuthRequest")] PaymentAuthorisationRequest paymentAuthRequest);

        /// <summary>
        /// Create a new single payment
        /// </summary>
        /// <param name="paymentRequest">paymentRequest</param>
        /// <returns>OK</returns>
        [System.Obsolete]
        [Post("/payment-sortcode")]
        [Headers("x-yapily-api-version: 1.0", "Authorization: Basic", "consent","psu-id","psu-corporate-id","psu-ip-address")] 
        Task<ApiResponseOfPaymentResponse> CreatePaymentWithSortCodeUsingPOSTAsync([Body][AliasAs("paymentRequest")] SortCodePaymentRequest paymentRequest);

        /// <summary>
        /// Initiate a new single payment for user to authorise
        /// </summary>
        /// <param name="paymentAuthRequest">paymentAuthRequest</param>
        /// <returns>OK</returns>
        [System.Obsolete]
        [Post("/payment-sortcode-auth-requests")]
        [Headers("x-yapily-api-version: 1.0", "Authorization: Basic", "psu-id","psu-corporate-id","psu-ip-address")] 
        Task<ApiResponseOfAuthorisationRequestResponse> CreatePaymentAuthorisationWithSortCodeUsingPOSTAsync([Body][AliasAs("paymentAuthRequest")] SortCodePaymentAuthRequest paymentAuthRequest);

        /// <summary>
        /// Create a payment
        /// </summary>
        /// <param name="paymentRequest">paymentRequest</param>
        /// <returns>OK</returns>
        [Post("/payments")]
        [Headers("x-yapily-api-version: 1.0", "Authorization: Basic", "consent","psu-id","psu-corporate-id","psu-ip-address")] 
        Task<ApiResponseOfPaymentResponse> CreatePaymentUsingPOSTAsync([Body][AliasAs("paymentRequest")] PaymentRequest paymentRequest);

        /// <summary>
        /// Get status of a payment
        /// </summary>
        /// <param name="paymentId">__Mandatory__. The payment Id of the payment.</param>
        /// <returns>OK</returns>
        [Get("/payments/{paymentId}")]
        [Headers("x-yapily-api-version: 1.0", "Authorization: Basic", "consent","psu-id","psu-corporate-id","psu-ip-address")] 
        Task<ApiResponseOfPaymentResponse> GetPaymentStatusUsingGETAsync([AliasAs("paymentId")] string paymentId);

        /// <summary>
        /// Get payments details
        /// </summary>
        /// <param name="paymentId">__Mandatory__. The payment Id of the payment.</param>
        /// <returns>OK</returns>
        [Get("/payments/{paymentId}/details")]
        [Headers("x-yapily-api-version: 1.0", "Authorization: Basic", "consent","psu-id","psu-corporate-id","psu-ip-address")] 
        Task<ApiResponseOfPaymentResponses> GetPaymentsUsingGETAsync([AliasAs("paymentId")] string paymentId);

    }
}