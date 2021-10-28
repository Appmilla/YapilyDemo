using System.Threading.Tasks;
using System.Collections.Generic;
using Refit;

namespace Cms
{
    public interface IConsents
    {
        /// <summary>
        /// Post auth-code and auth-state
        /// </summary>
        /// <param name="consentByAuthCode">consentByAuthCode</param>
        /// <returns>OK</returns>
        [Post("consent-auth-code")]
        [Headers("x-yapily-api-version",)] 
        Task<Consent> CreateConsentWithCodeUsingPOSTAsync([Body][AliasAs("consentByAuthCode")] ConsentAuthCodeRequest consentByAuthCode);

        /// <summary>
        /// Post one time token
        /// </summary>
        /// <param name="oneTimeToken">oneTimeToken</param>
        /// <returns>OK</returns>
        [Post("consent-one-time-token")]
        [Headers("x-yapily-api-version",)] 
        Task<Consent> GetConsentBySingleAccessConsentUsingPOSTAsync([Body][AliasAs("oneTimeToken")] OneTimeTokenRequest oneTimeToken);

        /// <summary>
        /// Get consents sorted by creation date
        /// </summary>
        /// <param name="filterapplicationUserId">__Optional__. Filter records based on the list of `applicationUserId` users provided.</param>
        /// <param name="filteruserUuid">__Optional__. Filter records based on the list of `userUuid` users provided.</param>
        /// <param name="filterinstitution">__Optional__. Filter records based on the list of `Institution` provided.</param>
        /// <param name="filterstatus">__Optional__. Filter records based on the list of `Consent` [statuses](https://docs.yapily.com/api/#tocS_AuthorisationStatus).</param>
        /// <param name="from">__Optional__. Returned transactions will be on or after this date (yyyy-MM-dd'T'HH:mm:ss.SSSZ).</param>
        /// <param name="before">__Optional__. Returned transactions will be on or before this date (yyyy-MM-dd'T'HH:mm:ss.SSSZ).</param>
        /// <param name="limit">Use this parameter to limit consent results, max limit is 20</param>
        /// <param name="offset">__Optional__. The number of transaction records to be skipped. Used primarily with paginated results.</param>
        /// <returns>OK</returns>
        [Get("consents")]
        [Headers("x-yapily-api-version",)] 
        Task<ApiListResponseOfConsent> GetConsentsUsingGETAsync([Query][AliasAs("filterapplicationUserId")] IEnumerable<string> filterapplicationUserId,[Query][AliasAs("filteruserUuid")] IEnumerable<string> filteruserUuid,[Query][AliasAs("filterinstitution")] IEnumerable<string> filterinstitution,[Query][AliasAs("filterstatus")] IEnumerable<string> filterstatus,[Query][AliasAs("from")] string from,[Query][AliasAs("before")] string before,[Query][AliasAs("limit")] int? limit,[Query][AliasAs("offset")] int offset);

        /// <summary>
        /// Get consent
        /// </summary>
        /// <param name="consentId">__Mandatory__. The consent Id of the `Consent` to update.</param>
        /// <returns>OK</returns>
        [Get("consents/{consentId}")]
        [Headers("x-yapily-api-version",)] 
        Task<ApiResponseOfConsent> GetConsentByIdUsingGETAsync([AliasAs("consentId")] string consentId);

        /// <summary>
        /// Delete consent
        /// </summary>
        /// <param name="consentId">__Mandatory__. The consent Id of the `Consent` to update.</param>
        /// <param name="forceDelete">__Optional__. Whether to force the deletion.</param>
        /// <returns>OK</returns>
        [Delete("consents/{consentId}")]
        [Headers("x-yapily-api-version",)] 
        Task<ApiResponseOfConsentDeleteResponse> DeleteUsingDELETEAsync([AliasAs("consentId")] string consentId,[Query][AliasAs("forceDelete")] bool forceDelete);

        /// <summary>
        /// Initiate request for user to pre authorise
        /// </summary>
        /// <param name="preAuthorisationRequest">preAuthorisationRequest</param>
        /// <returns>OK</returns>
        [Post("pre-auth-requests")]
        [Headers("x-yapily-api-version",)] 
        Task<ApiResponseOfAuthorisationRequestResponse> CreatePreAuthorisationRequestUsingPOSTAsync([Body][AliasAs("preAuthorisationRequest")] PreAuthorisationRequest preAuthorisationRequest);

        /// <summary>
        /// Get latest user consents
        /// </summary>
        /// <param name="userUuid">__Mandatory__. The Yapily generated UUID for the user.</param>
        /// <param name="institutionId">Use this parameter to filter consent by institution, using the Yapily institution Id. This replaces the deprecated `institutionId` query param.</param>
        /// <param name="limit">Use this parameter to limit consent results, max limit is 20</param>
        /// <returns>OK</returns>
        [System.Obsolete]
        [Get("users/{userUuid}/consents")]
        [Headers("x-yapily-api-version",)] 
        Task<ICollection<Consent>> GetUserConsentsUsingGETAsync([AliasAs("userUuid")] string userUuid,[Query][AliasAs("institutionId")] string institutionId,[Query][AliasAs("limit")] int? limit);

        /// <summary>
        /// Post consent
        /// </summary>
        /// <param name="userUuid">__Mandatory__. The Yapily generated UUID for the user.</param>
        /// <param name="createConsentAccessToken">createConsentAccessToken</param>
        /// <returns>OK</returns>
        [Post("users/{userUuid}/consents")]
        [Headers("x-yapily-api-version",)] 
        Task<Consent> AddConsentUsingPOSTAsync([AliasAs("userUuid")] string userUuid,[Body][AliasAs("createConsentAccessToken")] CreateConsentAccessToken createConsentAccessToken);

    }
}