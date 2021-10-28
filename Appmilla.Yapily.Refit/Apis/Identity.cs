using System.Threading.Tasks;
using Appmilla.Yapily.Refit.Models;
using Refit;

namespace Appmilla.Yapily.Refit.Apis
{
    public interface IIdentity
    {
        /// <summary>
        /// Get identity
        /// </summary>
        /// <returns>OK</returns>
        [Get("/identity")]
        [Headers("x-yapily-api-version: 1.0", "Authorization: Basic", "consent")] 
        Task<ApiResponseOfIdentity> GetIdentityUsingGETAsync();

    }
}