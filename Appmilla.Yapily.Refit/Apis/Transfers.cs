using System.Threading.Tasks;
using System.Collections.Generic;
using Refit;

namespace Cms
{
    public interface ITransfers
    {
        /// <summary>
        /// Transfer money from one account to another account accessible with the same consent
        /// </summary>
        /// <param name="accountId">__Mandatory__. The account Id of the user's bank account.</param>
        /// <param name="transferRequest">transferRequest</param>
        /// <returns>OK</returns>
        [Put("accounts/{accountId}/transfer")]
        [Headers("x-yapily-api-version","consent",)] 
        Task<ApiResponseOfTransferResponse> TransferUsingPUTAsync([AliasAs("accountId")] string accountId,[Body][AliasAs("transferRequest")] TransferRequest transferRequest);

    }
}