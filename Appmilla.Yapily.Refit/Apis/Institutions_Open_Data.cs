using System.Threading.Tasks;
using System.Collections.Generic;
using Refit;

namespace Cms
{
    public interface IInstitutions_Open_Data
    {
        /// <summary>
        /// Retrieves data about all ATMs of the selected institution
        /// </summary>
        /// <param name="institutionId">institutionId</param>
        /// <returns>OK</returns>
        [Get("institutions/{institutionId}/atms")]
        [Headers()] 
        Task<ApiResponseOfListOfATMOpenDataResponse> GetATMDataUsingGETAsync([AliasAs("institutionId")] string institutionId);

        /// <summary>
        /// Retrieves details of personal current accounts for an institution
        /// </summary>
        /// <param name="institutionId">institutionId</param>
        /// <returns>OK</returns>
        [Get("institutions/{institutionId}/personal-current-accounts")]
        [Headers()] 
        Task<ApiResponseOfListOfPersonalCurrentAccountData> GetPersonalCurrentAccountsUsingGETAsync([AliasAs("institutionId")] string institutionId);

    }
}