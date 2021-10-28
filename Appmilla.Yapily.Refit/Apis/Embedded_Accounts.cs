using System.Threading.Tasks;
using Appmilla.Yapily.Refit.Models;
using Refit;

namespace Appmilla.Yapily.Refit.Apis
{
    public interface IEmbedded_Accounts
    {
        /// <summary>
        /// Initiate a new embedded account request for user to authorize
        /// </summary>
        /// <param name="accountAuthRequest">accountAuthRequest</param>
        /// <returns>OK</returns>
        [Post("/embedded-account-auth-requests")]
        [Headers("x-yapily-api-version: 1.0", "Authorization: Basic", "psu-id","psu-corporate-id","psu-ip-address")] 
        Task<ApiResponseOfAuthorisationEmbeddedRequestResponse> InitiateEmbeddedAccountRequestUsingPOSTAsync([Body][AliasAs("accountAuthRequest")] AccountEmbeddedAuthorisationRequest accountAuthRequest);

        /// <summary>
        /// Update an embedded account request with SCA info
        /// </summary>
        /// <param name="consentId">__Mandatory__. The consent Id of the `Consent` to update.</param>
        /// <param name="accountAuthRequest">accountAuthRequest</param>
        /// <returns>OK</returns>
        [Put("/embedded-account-auth-requests/{consentId}")]
        [Headers("x-yapily-api-version: 1.0", "Authorization: Basic", "psu-id","psu-corporate-id","psu-ip-address")] 
        Task<ApiResponseOfAuthorisationEmbeddedRequestResponse> UpdateEmbeddedAccountRequestUsingPUTAsync([AliasAs("consentId")] string consentId,[Body][AliasAs("accountAuthRequest")] AccountEmbeddedAuthorisationRequest accountAuthRequest);

    }
}