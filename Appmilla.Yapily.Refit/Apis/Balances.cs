using System.Threading.Tasks;
using Appmilla.Yapily.Refit.Models;
using Refit;

namespace Appmilla.Yapily.Refit.Apis
{
    public interface IBalances
    {
        /// <summary>
        /// Get account balances
        /// </summary>
        /// <param name="accountId">__Mandatory__. The account Id of the user's bank account.</param>
        /// <returns>OK</returns>
        [Get("/accounts/{accountId}/balances")]
        [Headers("x-yapily-api-version: 1.0", "Authorization: Basic", "consent","psu-id","psu-corporate-id","psu-ip-address")] 
        Task<ApiResponseOfBalances> GetAccountBalancesUsingGETAsync([AliasAs("accountId")] string accountId);

    }
}