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
    public interface IBalancesApi
    {
        /// <summary>
        /// Get account balances 
        /// </summary>
        /// <param name="accountId">__Mandatory__. The account Id of the user&#x27;s bank account.</param>
        /// <param name="xYapilyApiVersion">__Optional__. Determines the API version to use. Valid values are &#x60;1.0&#x60; or &#x60;2.0-ALPHA&#x60;. Defaults to &#x60;1.0&#x60;</param>
        /// <param name="consent">__Mandatory__. The &#x60;consent-token&#x60; containing the user&#x27;s authorisation to make the request.</param>
        /// <param name="psuId">__Conditional__. Represents the user&#x27;s login ID for the &#x60;Institution&#x60; to a personal account. &lt;br&gt;&lt;br&gt;See [PSU identifiers](https://docs.yapily.com/knowledge/psu_identifiers/) to see if this header is required.</param>
        /// <param name="psuCorporateId">__Conditional__. Represents the user&#x27;s login ID for the &#x60;Institution&#x60; to a business account. &lt;br&gt;&lt;br&gt;See [PSU identifiers](https://docs.yapily.com/knowledge/psu_identifiers/) to see if this header is required.</param>
        /// <param name="psuIpAddress">__Conditional__. The IP address of the PSU. &lt;br&gt;&lt;br&gt;See [PSU identifiers](https://docs.yapily.com/knowledge/psu_identifiers/) to see if this header is required.</param>
        /// <returns>ApiResponseOfBalances</returns>
        ApiResponseOfBalances GetAccountBalancesUsingGET (string accountId, string xYapilyApiVersion, string consent, string psuId, string psuCorporateId, string psuIpAddress);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class BalancesApi : IBalancesApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BalancesApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public BalancesApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="BalancesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public BalancesApi(String basePath)
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
        /// Get account balances 
        /// </summary>
        /// <param name="accountId">__Mandatory__. The account Id of the user&#x27;s bank account.</param>
        /// <param name="xYapilyApiVersion">__Optional__. Determines the API version to use. Valid values are &#x60;1.0&#x60; or &#x60;2.0-ALPHA&#x60;. Defaults to &#x60;1.0&#x60;</param>
        /// <param name="consent">__Mandatory__. The &#x60;consent-token&#x60; containing the user&#x27;s authorisation to make the request.</param>
        /// <param name="psuId">__Conditional__. Represents the user&#x27;s login ID for the &#x60;Institution&#x60; to a personal account. &lt;br&gt;&lt;br&gt;See [PSU identifiers](https://docs.yapily.com/knowledge/psu_identifiers/) to see if this header is required.</param>
        /// <param name="psuCorporateId">__Conditional__. Represents the user&#x27;s login ID for the &#x60;Institution&#x60; to a business account. &lt;br&gt;&lt;br&gt;See [PSU identifiers](https://docs.yapily.com/knowledge/psu_identifiers/) to see if this header is required.</param>
        /// <param name="psuIpAddress">__Conditional__. The IP address of the PSU. &lt;br&gt;&lt;br&gt;See [PSU identifiers](https://docs.yapily.com/knowledge/psu_identifiers/) to see if this header is required.</param>
        /// <returns>ApiResponseOfBalances</returns>
        public ApiResponseOfBalances GetAccountBalancesUsingGET (string accountId, string xYapilyApiVersion, string consent, string psuId, string psuCorporateId, string psuIpAddress)
        {
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling GetAccountBalancesUsingGET");
    
            var path = "/accounts/{accountId}/balances";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "accountId" + "}", ApiClient.ParameterToString(accountId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetAccountBalancesUsingGET: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetAccountBalancesUsingGET: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ApiResponseOfBalances) ApiClient.Deserialize(response.Content, typeof(ApiResponseOfBalances), response.Headers);
        }
    
    }
}
