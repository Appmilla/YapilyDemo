using System.Threading.Tasks;
using System.Collections.Generic;
using Refit;

namespace Cms
{
    public interface IBalances
    {
        /// <summary>
        /// Get account balances
        /// </summary>
        /// <param name="accountId">__Mandatory__. The account Id of the user's bank account.</param>
        /// <returns>OK</returns>
        [Get("accounts/{accountId}/balances")]
        [Headers("x-yapily-api-version","consent","psu-id","psu-corporate-id","psu-ip-address")] 
        Task<ApiResponseOfBalances> GetAccountBalancesUsingGETAsync([AliasAs("accountId")] string accountId);

    }
}