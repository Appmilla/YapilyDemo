using System.Threading.Tasks;
using Appmilla.Yapily.Refit.Models;
using Refit;

namespace Appmilla.Yapily.Refit.Apis
{
    public interface ITransfers
    {
        /// <summary>
        /// Transfer money from one account to another account accessible with the same consent
        /// </summary>
        /// <param name="accountId">__Mandatory__. The account Id of the user's bank account.</param>
        /// <param name="transferRequest">transferRequest</param>
        /// <returns>OK</returns>
        [Put("/accounts/{accountId}/transfer")]
        [Headers("x-yapily-api-version: 1.0", "Authorization: Basic", "consent")] 
        Task<ApiResponseOfTransferResponse> TransferUsingPUTAsync([AliasAs("accountId")] string accountId,[Body][AliasAs("transferRequest")] TransferRequest transferRequest);

    }
}