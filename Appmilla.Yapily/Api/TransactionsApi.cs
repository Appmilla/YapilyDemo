using System;
using System.Collections.Generic;
using Appmilla.Yapily.Client;
using Appmilla.Yapily.Model;
using RestSharp;

namespace Appmilla.Yapily.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ITransactionsApi
    {
        /// <summary>
        /// Get account transactions 
        /// </summary>
        /// <param name="accountId">__Mandatory__. The account Id of the user&#x27;s bank account.</param>
        /// <param name="consent">__Mandatory__. The &#x60;consent-token&#x60; containing the user&#x27;s authorisation to make the request.</param>
        /// <param name="xYapilyApiVersion">__Optional__. Determines the API version to use. Valid values are &#x60;1.0&#x60; or &#x60;2.0-ALPHA&#x60;. Defaults to &#x60;1.0&#x60;</param>
        /// <param name="psuId">__Conditional__. Represents the user&#x27;s login ID for the &#x60;Institution&#x60; to a personal account. &lt;br&gt;&lt;br&gt;See [PSU identifiers](https://docs.yapily.com/knowledge/psu_identifiers/) to see if this header is required.</param>
        /// <param name="psuCorporateId">__Conditional__. Represents the user&#x27;s login ID for the &#x60;Institution&#x60; to a business account. &lt;br&gt;&lt;br&gt;See [PSU identifiers](https://docs.yapily.com/knowledge/psu_identifiers/) to see if this header is required.</param>
        /// <param name="psuIpAddress">__Conditional__. The IP address of the PSU. &lt;br&gt;&lt;br&gt;See [PSU identifiers](https://docs.yapily.com/knowledge/psu_identifiers/) to see if this header is required.</param>
        /// <param name="with">__Optional__. Can be &#x60;categories&#x60;, &#x60;categories-business&#x60; or &#x60;merchant&#x60;. When set, will include enrichment data in the transactions returned. &lt;br&gt;&lt;br&gt;Enrichment data is optional, e.g. when &#x27;merchant&#x27; enrichment data is requested, the enrichment response will include merchant data only if it can be evaluated from the transaction.</param>
        /// <param name="from">__Optional__. Returned transactions will be on or after this date (yyyy-MM-dd&#x27;T&#x27;HH:mm:ss.SSSZ). </param>
        /// <param name="before">__Optional__. Returned transactions will be on or before this date (yyyy-MM-dd&#x27;T&#x27;HH:mm:ss.SSSZ).</param>
        /// <param name="limit">__Optional__. The maximum number of transaction records to be returned. Must be between 0 and 1000.</param>
        /// <param name="sort">__Optional__. Sort transaction records by date ascending with &#x27;date&#x27; or descending with &#x27;-date&#x27;. The default sort order is descending</param>
        /// <param name="offset">__Optional__. The number of transaction records to be skipped. Used primarily with paginated results.</param>
        /// <param name="cursor">__Optional__. This property is not currently in use.</param>
        /// <returns>ApiListResponseOfTransaction</returns>
        ApiListResponseOfTransaction GetTransactionsUsingGET (string accountId, string consent, string xYapilyApiVersion, string psuId, string psuCorporateId, string psuIpAddress, List<string> with, string from, string before, int? limit, string sort, int? offset, string cursor);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class TransactionsApi : ITransactionsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionsApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public TransactionsApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public TransactionsApi(String basePath)
        {
            this.ApiClient = new ApiClient(basePath);
        }
    
        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <param name="basePath">The base path</param>
        /// <value>The base path</value>
        public void SetBasePath(String basePath)
        {
            this.ApiClient.BasePath = basePath;
        }
    
        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <param name="basePath">The base path</param>
        /// <value>The base path</value>
        public String GetBasePath(String basePath)
        {
            return this.ApiClient.BasePath;
        }
    
        /// <summary>
        /// Gets or sets the API client.
        /// </summary>
        /// <value>An instance of the ApiClient</value>
        public ApiClient ApiClient {get; set;}
    
        /// <summary>
        /// Get account transactions 
        /// </summary>
        /// <param name="accountId">__Mandatory__. The account Id of the user&#x27;s bank account.</param>
        /// <param name="consent">__Mandatory__. The &#x60;consent-token&#x60; containing the user&#x27;s authorisation to make the request.</param>
        /// <param name="xYapilyApiVersion">__Optional__. Determines the API version to use. Valid values are &#x60;1.0&#x60; or &#x60;2.0-ALPHA&#x60;. Defaults to &#x60;1.0&#x60;</param>
        /// <param name="psuId">__Conditional__. Represents the user&#x27;s login ID for the &#x60;Institution&#x60; to a personal account. &lt;br&gt;&lt;br&gt;See [PSU identifiers](https://docs.yapily.com/knowledge/psu_identifiers/) to see if this header is required.</param>
        /// <param name="psuCorporateId">__Conditional__. Represents the user&#x27;s login ID for the &#x60;Institution&#x60; to a business account. &lt;br&gt;&lt;br&gt;See [PSU identifiers](https://docs.yapily.com/knowledge/psu_identifiers/) to see if this header is required.</param>
        /// <param name="psuIpAddress">__Conditional__. The IP address of the PSU. &lt;br&gt;&lt;br&gt;See [PSU identifiers](https://docs.yapily.com/knowledge/psu_identifiers/) to see if this header is required.</param>
        /// <param name="with">__Optional__. Can be &#x60;categories&#x60;, &#x60;categories-business&#x60; or &#x60;merchant&#x60;. When set, will include enrichment data in the transactions returned. &lt;br&gt;&lt;br&gt;Enrichment data is optional, e.g. when &#x27;merchant&#x27; enrichment data is requested, the enrichment response will include merchant data only if it can be evaluated from the transaction.</param>
        /// <param name="from">__Optional__. Returned transactions will be on or after this date (yyyy-MM-dd&#x27;T&#x27;HH:mm:ss.SSSZ). </param>
        /// <param name="before">__Optional__. Returned transactions will be on or before this date (yyyy-MM-dd&#x27;T&#x27;HH:mm:ss.SSSZ).</param>
        /// <param name="limit">__Optional__. The maximum number of transaction records to be returned. Must be between 0 and 1000.</param>
        /// <param name="sort">__Optional__. Sort transaction records by date ascending with &#x27;date&#x27; or descending with &#x27;-date&#x27;. The default sort order is descending</param>
        /// <param name="offset">__Optional__. The number of transaction records to be skipped. Used primarily with paginated results.</param>
        /// <param name="cursor">__Optional__. This property is not currently in use.</param>
        /// <returns>ApiListResponseOfTransaction</returns>
        public ApiListResponseOfTransaction GetTransactionsUsingGET (string accountId, string consent, string xYapilyApiVersion, string psuId, string psuCorporateId, string psuIpAddress, List<string> with, string from, string before, int? limit, string sort, int? offset, string cursor)
        {
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling GetTransactionsUsingGET");
            // verify the required parameter 'consent' is set
            if (consent == null) throw new ApiException(400, "Missing required parameter 'consent' when calling GetTransactionsUsingGET");
    
            var path = "/accounts/{accountId}/transactions";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "accountId" + "}", ApiClient.ParameterToString(accountId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (with != null) queryParams.Add("with", ApiClient.ParameterToString(with)); // query parameter
 if (from != null) queryParams.Add("from", ApiClient.ParameterToString(from)); // query parameter
 if (before != null) queryParams.Add("before", ApiClient.ParameterToString(before)); // query parameter
 if (limit != null) queryParams.Add("limit", ApiClient.ParameterToString(limit)); // query parameter
 if (sort != null) queryParams.Add("sort", ApiClient.ParameterToString(sort)); // query parameter
 if (offset != null) queryParams.Add("offset", ApiClient.ParameterToString(offset)); // query parameter
 if (cursor != null) queryParams.Add("cursor", ApiClient.ParameterToString(cursor)); // query parameter
             if (xYapilyApiVersion != null) headerParams.Add("x-yapily-api-version", ApiClient.ParameterToString(xYapilyApiVersion)); // header parameter
 if (consent != null) headerParams.Add("consent", ApiClient.ParameterToString(consent)); // header parameter
 if (psuId != null) headerParams.Add("psu-id", ApiClient.ParameterToString(psuId)); // header parameter
 if (psuCorporateId != null) headerParams.Add("psu-corporate-id", ApiClient.ParameterToString(psuCorporateId)); // header parameter
 if (psuIpAddress != null) headerParams.Add("psu-ip-address", ApiClient.ParameterToString(psuIpAddress)); // header parameter
            
            // authentication setting, if any
            String[] authSettings = new String[] { "basicAuth", "tokenAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetTransactionsUsingGET: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetTransactionsUsingGET: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ApiListResponseOfTransaction) ApiClient.Deserialize(response.Content, typeof(ApiListResponseOfTransaction), response.Headers);
        }
    
    }
}
