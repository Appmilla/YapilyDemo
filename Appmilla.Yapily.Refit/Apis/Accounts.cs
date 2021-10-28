using System.Threading.Tasks;
using Appmilla.Yapily.Refit.Models;
using Refit;

namespace Appmilla.Yapily.Refit.Apis
{
    public interface IAccounts
    {
        /// <summary>
        /// Initiate a new account request for user to authorize
        /// </summary>
        /// <param name="accountAuthRequest">accountAuthRequest</param>
        /// <returns>OK</returns>
        [Post("/account-auth-requests")]
        [Headers("x-yapily-api-version: 1.0", "Authorization: Basic", "psu-id","psu-corporate-id","psu-ip-address")] 
        Task<ApiResponseOfAuthorisationRequestResponse> InitiateAccountRequestUsingPOSTAsync([Body][AliasAs("accountAuthRequest")] AccountAuthorisationRequest accountAuthRequest);

        /// <summary>
        /// Update pre authorize consent for user to authorise account
        /// </summary>
        /// <param name="accountAuthRequest">accountAuthRequest</param>
        /// <returns>OK</returns>
        [Put("/account-auth-requests")]
        [Headers("x-yapily-api-version: 1.0", "Authorization: Basic", "consent","psu-id","psu-corporate-id","psu-ip-address")] 
        Task<ApiResponseOfAuthorisationRequestResponse> UpdatePreAuthoriseAccountConsentUsingPUTAsync([Body][AliasAs("accountAuthRequest")] AccountAuthorisationRequest accountAuthRequest);

        /// <summary>
        /// Re-authorise account request
        /// </summary>
        /// <returns>OK</returns>

        [Headers("x-yapily-api-version: 1.0", "Authorization: Basic", "consent","psu-id","psu-corporate-id","psu-ip-address")] 
        Task<ApiResponseOfAuthorisationRequestResponse> ReAuthoriseAccountUsingPATCHAsync();

        /// <summary>
        /// Get accounts
        /// </summary>
        /// <returns>OK</returns>
        /*
        [Get("/accounts")]
        [Headers("x-yapily-api-version: 1.0", "Authorization: Basic", "consent:","psu-id","psu-corporate-id","psu-ip-address")] 
        Task<ApiListResponseOfAccount> GetAccountsUsingGETAsync();
        */
        
        [Get("/accounts")]
        [Headers("x-yapily-api-version: 1.0", "Authorization: Basic", "psu-id","psu-corporate-id","psu-ip-address")] 
        Task<ApiListResponseOfAccount> GetAccountsUsingGETAsync([Header("consent")] string consentToken);
        
        /// <summary>
        /// Get account
        /// </summary>
        /// <param name="accountId">__Mandatory__. The account Id of the user's bank account.</param>
        /// <returns>OK</returns>
        [Get("/accounts/{accountId}")]
        [Headers("consent","x-yapily-api-version", "Authorization: Basic", "psu-id","psu-corporate-id","psu-ip-address")] 
        Task<ApiResponseOfAccount> GetAccountUsingGETAsync([AliasAs("accountId")] string accountId);

        /// <summary>
        /// Get Beneficiaries
        /// </summary>
        /// <param name="accountId">__Mandatory__. The account Id of the user's bank account.</param>
        /// <returns>OK</returns>
        [Get("/accounts/{accountId}/beneficiaries")]
        [Headers("x-yapily-api-version: 1.0", "Authorization: Basic", "consent")] 
        Task<ApiResponseOfListOfBeneficiary> GetBeneficiariesUsingGETAsync([AliasAs("accountId")] string accountId);

        /// <summary>
        /// Get account direct debits
        /// </summary>
        /// <param name="accountId">__Mandatory__. The account Id of the user's bank account.</param>
        /// <param name="limit">__Optional__. The maximum number of transaction records to be returned. Must be between 0 and 1000.</param>
        /// <returns>OK</returns>
        [Get("/accounts/{accountId}/direct-debits")]
        [Headers("x-yapily-api-version: 1.0", "Authorization: Basic", "consent")] 
        Task<ApiListResponseOfPaymentResponse> GetAccountDirectDebitsUsingGETAsync([AliasAs("accountId")] string accountId,[Query][AliasAs("limit")] int? limit);

        /// <summary>
        /// Get account payments detail
        /// </summary>
        /// <param name="accountId">__Mandatory__. The account Id of the user's bank account.</param>
        /// <param name="limit">__Optional__. The maximum number of transaction records to be returned. Must be between 0 and 1000.</param>
        /// <returns>OK</returns>
        [Get("/accounts/{accountId}/periodic-payments")]
        [Headers("x-yapily-api-version: 1.0", "Authorization: Basic", "consent")] 
        Task<ApiListResponseOfPaymentResponse> GetAccountPeriodicPaymentsUsingGETAsync([AliasAs("accountId")] string accountId,[Query][AliasAs("limit")] int? limit);

        /// <summary>
        /// Get account scheduled payments
        /// </summary>
        /// <param name="accountId">__Mandatory__. The account Id of the user's bank account.</param>
        /// <param name="limit">__Optional__. The maximum number of transaction records to be returned. Must be between 0 and 1000.</param>
        /// <returns>OK</returns>
        [Get("/accounts/{accountId}/scheduled-payments")]
        [Headers("x-yapily-api-version: 1.0", "Authorization: Basic", "consent")] 
        Task<ApiListResponseOfPaymentResponse> GetAccountScheduledPaymentsUsingGETAsync([AliasAs("accountId")] string accountId,[Query][AliasAs("limit")] int? limit);

    }
}