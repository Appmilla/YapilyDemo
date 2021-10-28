using System.Threading.Tasks;
using Appmilla.Yapily.Refit.Models;
using Refit;

namespace Appmilla.Yapily.Refit.Apis
{
    public interface IApplication
    {
        /// <summary>
        /// Returns the details of the application that owns the request credentials
        /// </summary>
        /// <returns>OK</returns>
        [Get("/me")]
        [Headers("x-yapily-api-version: 1.0","Authorization: Basic")] 
        Task<Application> GetApplicationMeUsingGETAsync();

    }
}