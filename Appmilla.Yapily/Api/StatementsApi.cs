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
    public interface IStatementsApi
    {
        /// <summary>
        /// Get account statement file 
        /// </summary>
        /// <param name="consent">__Mandatory__. The &#x60;consent-token&#x60; containing the user&#x27;s authorisation to make the request.</param>
        /// <param name="accountId">__Mandatory__. The account Id of the user&#x27;s bank account.</param>
        /// <param name="statementId">__Mandatory__. The statement Id of the statement file.</param>
        /// <param name="xYapilyApiVersion">__Optional__. Determines the API version to use. Valid values are &#x60;1.0&#x60; or &#x60;2.0-ALPHA&#x60;. Defaults to &#x60;1.0&#x60;</param>
        /// <returns>string</returns>
        string GetStatementFileUsingGET (string consent, string accountId, string statementId, string xYapilyApiVersion);
        /// <summary>
        /// Get account statement 
        /// </summary>
        /// <param name="consent">__Mandatory__. The &#x60;consent-token&#x60; containing the user&#x27;s authorisation to make the request.</param>
        /// <param name="accountId">__Mandatory__. The account Id of the user&#x27;s bank account.</param>
        /// <param name="statementId">__Mandatory__. The statement Id of the statement file.</param>
        /// <param name="xYapilyApiVersion">__Optional__. Determines the API version to use. Valid values are &#x60;1.0&#x60; or &#x60;2.0-ALPHA&#x60;. Defaults to &#x60;1.0&#x60;</param>
        /// <returns>ApiResponseOfAccountStatement</returns>
        ApiResponseOfAccountStatement GetStatementUsingGET (string consent, string accountId, string statementId, string xYapilyApiVersion);
        /// <summary>
        /// Get account statements 
        /// </summary>
        /// <param name="consent">__Mandatory__. The &#x60;consent-token&#x60; containing the user&#x27;s authorisation to make the request.</param>
        /// <param name="accountId">__Mandatory__. The account Id of the user&#x27;s bank account.</param>
        /// <param name="xYapilyApiVersion">__Optional__. Determines the API version to use. Valid values are &#x60;1.0&#x60; or &#x60;2.0-ALPHA&#x60;. Defaults to &#x60;1.0&#x60;</param>
        /// <param name="from">__Optional__. Returned transactions will be on or after this date (yyyy-MM-dd&#x27;T&#x27;HH:mm:ss.SSSZ). </param>
        /// <param name="before">__Optional__. Returned transactions will be on or before this date (yyyy-MM-dd&#x27;T&#x27;HH:mm:ss.SSSZ).</param>
        /// <param name="limit">__Optional__. The maximum number of transaction records to be returned. Must be between 0 and 1000.</param>
        /// <param name="sort">__Optional__. Sort transaction records by date ascending with &#x27;date&#x27; or descending with &#x27;-date&#x27;. The default sort order is descending</param>
        /// <param name="offset">__Optional__. The number of transaction records to be skipped. Used primarily with paginated results.</param>
        /// <returns>ApiListResponseOfAccountStatement</returns>
        ApiListResponseOfAccountStatement GetStatementsUsingGET (string consent, string accountId, string xYapilyApiVersion, string from, string before, int? limit, string sort, int? offset);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class StatementsApi : IStatementsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StatementsApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public StatementsApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="StatementsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public StatementsApi(String basePath)
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
        /// Get account statement file 
        /// </summary>
        /// <param name="consent">__Mandatory__. The &#x60;consent-token&#x60; containing the user&#x27;s authorisation to make the request.</param>
        /// <param name="accountId">__Mandatory__. The account Id of the user&#x27;s bank account.</param>
        /// <param name="statementId">__Mandatory__. The statement Id of the statement file.</param>
        /// <param name="xYapilyApiVersion">__Optional__. Determines the API version to use. Valid values are &#x60;1.0&#x60; or &#x60;2.0-ALPHA&#x60;. Defaults to &#x60;1.0&#x60;</param>
        /// <returns>string</returns>
        public string GetStatementFileUsingGET (string consent, string accountId, string statementId, string xYapilyApiVersion)
        {
            // verify the required parameter 'consent' is set
            if (consent == null) throw new ApiException(400, "Missing required parameter 'consent' when calling GetStatementFileUsingGET");
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling GetStatementFileUsingGET");
            // verify the required parameter 'statementId' is set
            if (statementId == null) throw new ApiException(400, "Missing required parameter 'statementId' when calling GetStatementFileUsingGET");
    
            var path = "/accounts/{accountId}/statements/{statementId}/file";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "accountId" + "}", ApiClient.ParameterToString(accountId));
path = path.Replace("{" + "statementId" + "}", ApiClient.ParameterToString(statementId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                         if (xYapilyApiVersion != null) headerParams.Add("x-yapily-api-version", ApiClient.ParameterToString(xYapilyApiVersion)); // header parameter
 if (consent != null) headerParams.Add("consent", ApiClient.ParameterToString(consent)); // header parameter
            
            // authentication setting, if any
            String[] authSettings = new String[] { "basicAuth", "tokenAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetStatementFileUsingGET: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetStatementFileUsingGET: " + response.ErrorMessage, response.ErrorMessage);
    
            return (string) ApiClient.Deserialize(response.Content, typeof(string), response.Headers);
        }
    
        /// <summary>
        /// Get account statement 
        /// </summary>
        /// <param name="consent">__Mandatory__. The &#x60;consent-token&#x60; containing the user&#x27;s authorisation to make the request.</param>
        /// <param name="accountId">__Mandatory__. The account Id of the user&#x27;s bank account.</param>
        /// <param name="statementId">__Mandatory__. The statement Id of the statement file.</param>
        /// <param name="xYapilyApiVersion">__Optional__. Determines the API version to use. Valid values are &#x60;1.0&#x60; or &#x60;2.0-ALPHA&#x60;. Defaults to &#x60;1.0&#x60;</param>
        /// <returns>ApiResponseOfAccountStatement</returns>
        public ApiResponseOfAccountStatement GetStatementUsingGET (string consent, string accountId, string statementId, string xYapilyApiVersion)
        {
            // verify the required parameter 'consent' is set
            if (consent == null) throw new ApiException(400, "Missing required parameter 'consent' when calling GetStatementUsingGET");
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling GetStatementUsingGET");
            // verify the required parameter 'statementId' is set
            if (statementId == null) throw new ApiException(400, "Missing required parameter 'statementId' when calling GetStatementUsingGET");
    
            var path = "/accounts/{accountId}/statements/{statementId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "accountId" + "}", ApiClient.ParameterToString(accountId));
path = path.Replace("{" + "statementId" + "}", ApiClient.ParameterToString(statementId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                         if (xYapilyApiVersion != null) headerParams.Add("x-yapily-api-version", ApiClient.ParameterToString(xYapilyApiVersion)); // header parameter
 if (consent != null) headerParams.Add("consent", ApiClient.ParameterToString(consent)); // header parameter
            
            // authentication setting, if any
            String[] authSettings = new String[] { "basicAuth", "tokenAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetStatementUsingGET: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetStatementUsingGET: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ApiResponseOfAccountStatement) ApiClient.Deserialize(response.Content, typeof(ApiResponseOfAccountStatement), response.Headers);
        }
    
        /// <summary>
        /// Get account statements 
        /// </summary>
        /// <param name="consent">__Mandatory__. The &#x60;consent-token&#x60; containing the user&#x27;s authorisation to make the request.</param>
        /// <param name="accountId">__Mandatory__. The account Id of the user&#x27;s bank account.</param>
        /// <param name="xYapilyApiVersion">__Optional__. Determines the API version to use. Valid values are &#x60;1.0&#x60; or &#x60;2.0-ALPHA&#x60;. Defaults to &#x60;1.0&#x60;</param>
        /// <param name="from">__Optional__. Returned transactions will be on or after this date (yyyy-MM-dd&#x27;T&#x27;HH:mm:ss.SSSZ). </param>
        /// <param name="before">__Optional__. Returned transactions will be on or before this date (yyyy-MM-dd&#x27;T&#x27;HH:mm:ss.SSSZ).</param>
        /// <param name="limit">__Optional__. The maximum number of transaction records to be returned. Must be between 0 and 1000.</param>
        /// <param name="sort">__Optional__. Sort transaction records by date ascending with &#x27;date&#x27; or descending with &#x27;-date&#x27;. The default sort order is descending</param>
        /// <param name="offset">__Optional__. The number of transaction records to be skipped. Used primarily with paginated results.</param>
        /// <returns>ApiListResponseOfAccountStatement</returns>
        public ApiListResponseOfAccountStatement GetStatementsUsingGET (string consent, string accountId, string xYapilyApiVersion, string from, string before, int? limit, string sort, int? offset)
        {
            // verify the required parameter 'consent' is set
            if (consent == null) throw new ApiException(400, "Missing required parameter 'consent' when calling GetStatementsUsingGET");
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling GetStatementsUsingGET");
    
            var path = "/accounts/{accountId}/statements";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "accountId" + "}", ApiClient.ParameterToString(accountId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (from != null) queryParams.Add("from", ApiClient.ParameterToString(from)); // query parameter
 if (before != null) queryParams.Add("before", ApiClient.ParameterToString(before)); // query parameter
 if (limit != null) queryParams.Add("limit", ApiClient.ParameterToString(limit)); // query parameter
 if (sort != null) queryParams.Add("sort", ApiClient.ParameterToString(sort)); // query parameter
 if (offset != null) queryParams.Add("offset", ApiClient.ParameterToString(offset)); // query parameter
             if (xYapilyApiVersion != null) headerParams.Add("x-yapily-api-version", ApiClient.ParameterToString(xYapilyApiVersion)); // header parameter
 if (consent != null) headerParams.Add("consent", ApiClient.ParameterToString(consent)); // header parameter
            
            // authentication setting, if any
            String[] authSettings = new String[] { "basicAuth", "tokenAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetStatementsUsingGET: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetStatementsUsingGET: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ApiListResponseOfAccountStatement) ApiClient.Deserialize(response.Content, typeof(ApiListResponseOfAccountStatement), response.Headers);
        }
    
    }
}
