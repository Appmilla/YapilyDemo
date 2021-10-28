using System.Threading.Tasks;
using System.Collections.Generic;
using Refit;

namespace Cms
{
    public interface IEmbedded_Payments
    {
        /// <summary>
        /// Initiate an embedded bulk payment for user to authorise
        /// </summary>
        /// <param name="bulkPaymentEmbeddedAuthorisationRequest">bulkPaymentEmbeddedAuthorisationRequest</param>
        /// <returns>OK</returns>
        [Post("embedded-bulk-payment-auth-requests")]
        [Headers("x-yapily-api-version","psu-id","psu-corporate-id","psu-ip-address",)] 
        Task<ApiResponseOfPaymentEmbeddedAuthorisationRequestResponse> CreateEmbeddedBulkPaymentAuthorisationUsingPOSTAsync([Body][AliasAs("bulkPaymentEmbeddedAuthorisationRequest")] BulkPaymentEmbeddedAuthorisationRequest bulkPaymentEmbeddedAuthorisationRequest);

        /// <summary>
        /// Update an embedded bulk payment initiation with SCA info
        /// </summary>
        /// <param name="consentId">__Mandatory__. The consent Id of the `Consent` to update.</param>
        /// <param name="bulkPaymentEmbeddedAuthorisationRequest">bulkPaymentEmbeddedAuthorisationRequest</param>
        /// <returns>OK</returns>
        [Put("embedded-bulk-payment-auth-requests/{consentId}")]
        [Headers("x-yapily-api-version","psu-id","psu-corporate-id","psu-ip-address",)] 
        Task<ApiResponseOfPaymentEmbeddedAuthorisationRequestResponse> UpdateEmbeddedBulkPaymentAuthorisationUsingPUTAsync([AliasAs("consentId")] string consentId,[Body][AliasAs("bulkPaymentEmbeddedAuthorisationRequest")] BulkPaymentEmbeddedAuthorisationRequest bulkPaymentEmbeddedAuthorisationRequest);

        /// <summary>
        /// Initiate an embedded payment for user to authorise
        /// </summary>
        /// <param name="paymentAuthRequest">paymentAuthRequest</param>
        /// <returns>OK</returns>
        [Post("embedded-payment-auth-requests")]
        [Headers("x-yapily-api-version","psu-id","psu-corporate-id","psu-ip-address",)] 
        Task<ApiResponseOfPaymentEmbeddedAuthorisationRequestResponse> CreateEmbeddedPaymentAuthorisationUsingPOSTAsync([Body][AliasAs("paymentAuthRequest")] PaymentEmbeddedAuthorisationRequest paymentAuthRequest);

        /// <summary>
        /// Update an embedded payment initiation with SCA info
        /// </summary>
        /// <param name="consentId">__Mandatory__. The consent Id of the `Consent` to update.</param>
        /// <param name="paymentAuthRequest">paymentAuthRequest</param>
        /// <returns>OK</returns>
        [Put("embedded-payment-auth-requests/{consentId}")]
        [Headers("x-yapily-api-version","psu-id","psu-corporate-id","psu-ip-address",)] 
        Task<ApiResponseOfPaymentEmbeddedAuthorisationRequestResponse> UpdateEmbeddedPaymentAuthorisationUsingPUTAsync([AliasAs("consentId")] string consentId,[Body][AliasAs("paymentAuthRequest")] PaymentEmbeddedAuthorisationRequest paymentAuthRequest);

    }
}