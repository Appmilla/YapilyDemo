using System.Threading.Tasks;
using Appmilla.Yapily.Refit.Models;
using Refit;

namespace Appmilla.Yapily.Refit.Apis
{
    public interface ICategories
    {
        /// <summary>
        /// Retrieves a list of categories returned by the Yapily Categorisation engine for a given locale
        /// </summary>
        /// <param name="country">__Mandatory__. The 2 letter country code e.g. 'GB'.</param>
        /// <returns>OK</returns>
        [Get("/categories/{country}")]
        [Headers("x-yapily-api-version: 1.0", "Authorization: Basic")] 
        Task<ApiListResponseOfCategory> GetCategoriesUsingGETAsync([AliasAs("country")] string country);

    }
}