using System.Threading.Tasks;
using System.Collections.Generic;
using Refit;

namespace Cms
{
    public interface IInstitutions
    {
        /// <summary>
        /// Retrieve details for Yapily's institution features
        /// </summary>
        /// <returns>OK</returns>
        [Get("features")]
        [Headers("x-yapily-api-version")] 
        Task<ApiListResponseOfFeatureDetails> GetFeatureDetailsUsingGETAsync();

        /// <summary>
        /// Retrieves the list of institutions available in Yapily
        /// </summary>
        /// <returns>OK</returns>
        [Get("institutions")]
        [Headers("x-yapily-api-version")] 
        Task<ApiListResponseOfInstitution> GetInstitutionsUsingGETAsync();

        /// <summary>
        /// Retrieves details of a specific institution available in Yapily
        /// </summary>
        /// <param name="institutionId">__Mandatory__. The Yapily institution Id for the `Institution`.</param>
        /// <returns>OK</returns>
        [Get("institutions/{institutionId}")]
        [Headers("x-yapily-api-version",)] 
        Task<Institution> GetInstitutionUsingGETAsync([AliasAs("institutionId")] string institutionId);

    }
}