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
    public interface IEmbeddedAccountsApi
    {
        /// <summary>
        /// Initiate a new embedded account request for user to authorize 
        /// </summary>
        /// <param name="body">accountAuthRequest</param>
        /// <param name="xYapilyApiVersion">__Optional__. Determines the API version to use. Valid values are &#x60;1.0&#x60; or &#x60;2.0-ALPHA&#x60;. Defaults to &#x60;1.0&#x60;</param>
        /// <param name="psuId">__Conditional__. Represents the user&#x27;s login ID for the &#x60;Institution&#x60; to a personal account. &lt;br&gt;&lt;br&gt;See [PSU identifiers](https://docs.yapily.com/knowledge/psu_identifiers/) to see if this header is required.</param>
        /// <param name="psuCorporateId">__Conditional__. Represents the user&#x27;s login ID for the &#x60;Institution&#x60; to a business account. &lt;br&gt;&lt;br&gt;See [PSU identifiers](https://docs.yapily.com/knowledge/psu_identifiers/) to see if this header is required.</param>
        /// <param name="psuIpAddress">__Conditional__. The IP address of the PSU. &lt;br&gt;&lt;br&gt;See [PSU identifiers](https://docs.yapily.com/knowledge/psu_identifiers/) to see if this header is required.</param>
        /// <returns>ApiResponseOfAuthorisationEmbeddedRequestResponse</returns>
        ApiResponseOfAuthorisationEmbeddedRequestResponse InitiateEmbeddedAccountRequestUsingPOST (AccountEmbeddedAuthorisationRequest body, string xYapilyApiVersion, string psuId, string psuCorporateId, string psuIpAddress);
        /// <summary>
        /// Update an embedded account request with SCA info 
        /// </summary>
        /// <param name="body">accountAuthRequest</param>
        /// <param name="consentId">__Mandatory__. The consent Id of the &#x60;Consent&#x60; to update.</param>
        /// <param name="xYapilyApiVersion">__Optional__. Determines the API version to use. Valid values are &#x60;1.0&#x60; or &#x60;2.0-ALPHA&#x60;. Defaults to &#x60;1.0&#x60;</param>
        /// <param name="psuId">__Conditional__. Represents the user&#x27;s login ID for the &#x60;Institution&#x60; to a personal account. &lt;br&gt;&lt;br&gt;See [PSU identifiers](https://docs.yapily.com/knowledge/psu_identifiers/) to see if this header is required.</param>
        /// <param name="psuCorporateId">__Conditional__. Represents the user&#x27;s login ID for the &#x60;Institution&#x60; to a business account. &lt;br&gt;&lt;br&gt;See [PSU identifiers](https://docs.yapily.com/knowledge/psu_identifiers/) to see if this header is required.</param>
        /// <param name="psuIpAddress">__Conditional__. The IP address of the PSU. &lt;br&gt;&lt;br&gt;See [PSU identifiers](https://docs.yapily.com/knowledge/psu_identifiers/) to see if this header is required.</param>
        /// <returns>ApiResponseOfAuthorisationEmbeddedRequestResponse</returns>
        ApiResponseOfAuthorisationEmbeddedRequestResponse UpdateEmbeddedAccountRequestUsingPUT (AccountEmbeddedAuthorisationRequest body, string consentId, string xYapilyApiVersion, string psuId, string psuCorporateId, string psuIpAddress);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class EmbeddedAccountsApi : IEmbeddedAccountsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmbeddedAccountsApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public EmbeddedAccountsApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="EmbeddedAccountsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public EmbeddedAccountsApi(String basePath)
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
        /// Initiate a new embedded account request for user to authorize 
        /// </summary>
        /// <param name="body">accountAuthRequest</param>
        /// <param name="xYapilyApiVersion">__Optional__. Determines the API version to use. Valid values are &#x60;1.0&#x60; or &#x60;2.0-ALPHA&#x60;. Defaults to &#x60;1.0&#x60;</param>
        /// <param name="psuId">__Conditional__. Represents the user&#x27;s login ID for the &#x60;Institution&#x60; to a personal account. &lt;br&gt;&lt;br&gt;See [PSU identifiers](https://docs.yapily.com/knowledge/psu_identifiers/) to see if this header is required.</param>
        /// <param name="psuCorporateId">__Conditional__. Represents the user&#x27;s login ID for the &#x60;Institution&#x60; to a business account. &lt;br&gt;&lt;br&gt;See [PSU identifiers](https://docs.yapily.com/knowledge/psu_identifiers/) to see if this header is required.</param>
        /// <param name="psuIpAddress">__Conditional__. The IP address of the PSU. &lt;br&gt;&lt;br&gt;See [PSU identifiers](https://docs.yapily.com/knowledge/psu_identifiers/) to see if this header is required.</param>
        /// <returns>ApiResponseOfAuthorisationEmbeddedRequestResponse</returns>
        public ApiResponseOfAuthorisationEmbeddedRequestResponse InitiateEmbeddedAccountRequestUsingPOST (AccountEmbeddedAuthorisationRequest body, string xYapilyApiVersion, string psuId, string psuCorporateId, string psuIpAddress)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling InitiateEmbeddedAccountRequestUsingPOST");
    
            var path = "/embedded-account-auth-requests";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                         if (xYapilyApiVersion != null) headerParams.Add("x-yapily-api-version", ApiClient.ParameterToString(xYapilyApiVersion)); // header parameter
 if (psuId != null) headerParams.Add("psu-id", ApiClient.ParameterToString(psuId)); // header parameter
 if (psuCorporateId != null) headerParams.Add("psu-corporate-id", ApiClient.ParameterToString(psuCorporateId)); // header parameter
 if (psuIpAddress != null) headerParams.Add("psu-ip-address", ApiClient.ParameterToString(psuIpAddress)); // header parameter
            postBody = ApiClient.Serialize(body); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] { "basicAuth", "tokenAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling InitiateEmbeddedAccountRequestUsingPOST: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling InitiateEmbeddedAccountRequestUsingPOST: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ApiResponseOfAuthorisationEmbeddedRequestResponse) ApiClient.Deserialize(response.Content, typeof(ApiResponseOfAuthorisationEmbeddedRequestResponse), response.Headers);
        }
    
        /// <summary>
        /// Update an embedded account request with SCA info 
        /// </summary>
        /// <param name="body">accountAuthRequest</param>
        /// <param name="consentId">__Mandatory__. The consent Id of the &#x60;Consent&#x60; to update.</param>
        /// <param name="xYapilyApiVersion">__Optional__. Determines the API version to use. Valid values are &#x60;1.0&#x60; or &#x60;2.0-ALPHA&#x60;. Defaults to &#x60;1.0&#x60;</param>
        /// <param name="psuId">__Conditional__. Represents the user&#x27;s login ID for the &#x60;Institution&#x60; to a personal account. &lt;br&gt;&lt;br&gt;See [PSU identifiers](https://docs.yapily.com/knowledge/psu_identifiers/) to see if this header is required.</param>
        /// <param name="psuCorporateId">__Conditional__. Represents the user&#x27;s login ID for the &#x60;Institution&#x60; to a business account. &lt;br&gt;&lt;br&gt;See [PSU identifiers](https://docs.yapily.com/knowledge/psu_identifiers/) to see if this header is required.</param>
        /// <param name="psuIpAddress">__Conditional__. The IP address of the PSU. &lt;br&gt;&lt;br&gt;See [PSU identifiers](https://docs.yapily.com/knowledge/psu_identifiers/) to see if this header is required.</param>
        /// <returns>ApiResponseOfAuthorisationEmbeddedRequestResponse</returns>
        public ApiResponseOfAuthorisationEmbeddedRequestResponse UpdateEmbeddedAccountRequestUsingPUT (AccountEmbeddedAuthorisationRequest body, string consentId, string xYapilyApiVersion, string psuId, string psuCorporateId, string psuIpAddress)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UpdateEmbeddedAccountRequestUsingPUT");
            // verify the required parameter 'consentId' is set
            if (consentId == null) throw new ApiException(400, "Missing required parameter 'consentId' when calling UpdateEmbeddedAccountRequestUsingPUT");
    
            var path = "/embedded-account-auth-requests/{consentId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "consentId" + "}", ApiClient.ParameterToString(consentId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                         if (xYapilyApiVersion != null) headerParams.Add("x-yapily-api-version", ApiClient.ParameterToString(xYapilyApiVersion)); // header parameter
 if (psuId != null) headerParams.Add("psu-id", ApiClient.ParameterToString(psuId)); // header parameter
 if (psuCorporateId != null) headerParams.Add("psu-corporate-id", ApiClient.ParameterToString(psuCorporateId)); // header parameter
 if (psuIpAddress != null) headerParams.Add("psu-ip-address", ApiClient.ParameterToString(psuIpAddress)); // header parameter
            postBody = ApiClient.Serialize(body); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] { "basicAuth", "tokenAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateEmbeddedAccountRequestUsingPUT: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateEmbeddedAccountRequestUsingPUT: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ApiResponseOfAuthorisationEmbeddedRequestResponse) ApiClient.Deserialize(response.Content, typeof(ApiResponseOfAuthorisationEmbeddedRequestResponse), response.Headers);
        }
    
    }
}
