using System.Threading.Tasks;
using System.Collections.Generic;
using Refit;

namespace Cms
{
    public interface IIdentity
    {
        /// <summary>
        /// Get identity
        /// </summary>
        /// <returns>OK</returns>
        [Get("identity")]
        [Headers("x-yapily-api-version","consent")] 
        Task<ApiResponseOfIdentity> GetIdentityUsingGETAsync();

    }
}