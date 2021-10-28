using System.Threading.Tasks;
using Appmilla.Yapily.Refit.Models;
using Refit;

namespace Appmilla.Yapily.Refit.Apis
{
    public interface IStatements
    {
        /// <summary>
        /// Get account statements
        /// </summary>
        /// <param name="accountId">__Mandatory__. The account Id of the user's bank account.</param>
        /// <param name="from">__Optional__. Returned transactions will be on or after this date (yyyy-MM-dd'T'HH:mm:ss.SSSZ).</param>
        /// <param name="before">__Optional__. Returned transactions will be on or before this date (yyyy-MM-dd'T'HH:mm:ss.SSSZ).</param>
        /// <param name="limit">__Optional__. The maximum number of transaction records to be returned. Must be between 0 and 1000.</param>
        /// <param name="sort">__Optional__. Sort transaction records by date ascending with 'date' or descending with '-date'. The default sort order is descending</param>
        /// <param name="offset">__Optional__. The number of transaction records to be skipped. Used primarily with paginated results.</param>
        /// <returns>OK</returns>
        [Get("/accounts/{accountId}/statements")]
        [Headers("x-yapily-api-version: 1.0", "Authorization: Basic", "consent")] 
        Task<ApiListResponseOfAccountStatement> GetStatementsUsingGETAsync([AliasAs("accountId")] string accountId,[Query][AliasAs("from")] string from,[Query][AliasAs("before")] string before,[Query][AliasAs("limit")] int? limit,[Query][AliasAs("sort")] Sort? sort,[Query][AliasAs("offset")] int? offset);

        /// <summary>
        /// Get account statement
        /// </summary>
        /// <param name="accountId">__Mandatory__. The account Id of the user's bank account.</param>
        /// <param name="statementId">__Mandatory__. The statement Id of the statement file.</param>
        /// <returns>OK</returns>
        [Get("/accounts/{accountId}/statements/{statementId}")]
        [Headers("x-yapily-api-version: 1.0", "Authorization: Basic", "consent")] 
        Task<ApiResponseOfAccountStatement> GetStatementUsingGETAsync([AliasAs("accountId")] string accountId,[AliasAs("statementId")] string statementId);

        /// <summary>
        /// Get account statement file
        /// </summary>
        /// <param name="accountId">__Mandatory__. The account Id of the user's bank account.</param>
        /// <param name="statementId">__Mandatory__. The statement Id of the statement file.</param>
        /// <returns>OK</returns>
        [Get("/accounts/{accountId}/statements/{statementId}/file")]
        [Headers("x-yapily-api-version: 1.0", "Authorization: Basic", "consent")] 
        Task<string> GetStatementFileUsingGETAsync([AliasAs("accountId")] string accountId,[AliasAs("statementId")] string statementId);

    }
}