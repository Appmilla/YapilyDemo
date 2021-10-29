using System.Collections.Generic;
using System.Threading.Tasks;
using Appmilla.Yapily.Refit.Models;
using Refit;

namespace Appmilla.Yapily.Refit.Apis
{
    public class TransactionsQueryParams
    {
        [Query]
        [AliasAs("with")]
        public IEnumerable<string> With { get; set; }

        [Query]
        [AliasAs("from")]
        public string From { get; set; }

        [Query]
        [AliasAs("before")]
        public string Before { get; set; }

        [Query]
        [AliasAs("limit")]
        public int? Limit { get; set; }

        [Query]
        [AliasAs("sort")]
        public Sort2? Sort { get; set; }

        [Query][AliasAs("offset")]
        public int? Offset { get; set; }

        [Query][AliasAs("cursor")]
        public string Cursor { get; set; }
    }

    public interface ITransactions
    {
        /*
        [Get("/accounts/{accountId}/transactions")]
        [Headers("x-yapily-api-version: 1.0", "Authorization: Basic", "consent", "psu-id", "psu-corporate-id", "psu-ip-address")]
        Task<ApiListResponseOfTransaction> GetTransactionsUsingGETAsync([AliasAs("accountId")] string accountId, TransactionsQueryParams transactionsQueryParams = null);
        */
        
        [Get("/accounts/{accountId}/transactions")]
        [Headers("x-yapily-api-version: 1.0", "Authorization: Basic", "psu-id", "psu-corporate-id", "psu-ip-address")]
        Task<ApiListResponseOfTransaction> GetTransactionsUsingGETAsync([Header("consent")] string consentToken, [AliasAs("accountId")] string accountId, TransactionsQueryParams transactionsQueryParams = null);
        
        /*
        /// <summary>
        /// Get account transactions
        /// </summary>
        /// <param name="accountId">__Mandatory__. The account Id of the user's bank account.</param>
        /// <param name="with">__Optional__. Can be `categories`, `categories-business` or `merchant`. When set, will include enrichment data in the transactions returned. &lt;br&gt;&lt;br&gt;Enrichment data is optional, e.g. when 'merchant' enrichment data is requested, the enrichment response will include merchant data only if it can be evaluated from the transaction.</param>
        /// <param name="from">__Optional__. Returned transactions will be on or after this date (yyyy-MM-dd'T'HH:mm:ss.SSSZ).</param>
        /// <param name="before">__Optional__. Returned transactions will be on or before this date (yyyy-MM-dd'T'HH:mm:ss.SSSZ).</param>
        /// <param name="limit">__Optional__. The maximum number of transaction records to be returned. Must be between 0 and 1000.</param>
        /// <param name="sort">__Optional__. Sort transaction records by date ascending with 'date' or descending with '-date'. The default sort order is descending</param>
        /// <param name="offset">__Optional__. The number of transaction records to be skipped. Used primarily with paginated results.</param>
        /// <param name="cursor">__Optional__. This property is not currently in use.</param>
        /// <returns>OK</returns>
        [Get("/accounts/{accountId}/transactions")]
        [Headers("x-yapily-api-version: 1.0", "Authorization: Basic", "consent","psu-id","psu-corporate-id","psu-ip-address")] 
        Task<ApiListResponseOfTransaction> GetTransactionsUsingGETAsync([AliasAs("accountId")] string accountId,[Query][AliasAs("with")] IEnumerable<string> with,[Query][AliasAs("from")] string from,[Query][AliasAs("before")] string before,[Query][AliasAs("limit")] int? limit,[Query][AliasAs("sort")] Sort2? sort,[Query][AliasAs("offset")] int? offset,[Query][AliasAs("cursor")] string cursor);
        */
    }
}