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
    public interface IAccountsApi
    {
        /// <summary>
        /// Get account direct debits 
        /// </summary>
        /// <param name="accountId">__Mandatory__. The account Id of the user&#x27;s bank account.</param>
        /// <param name="consent">__Mandatory__. The &#x60;consent-token&#x60; containing the user&#x27;s authorisation to make the request.</param>
        /// <param name="xYapilyApiVersion">__Optional__. Determines the API version to use. Valid values are &#x60;1.0&#x60; or &#x60;2.0-ALPHA&#x60;. Defaults to &#x60;1.0&#x60;</param>
        /// <param name="limit">__Optional__. The maximum number of transaction records to be returned. Must be between 0 and 1000.</param>
        /// <returns>ApiListResponseOfPaymentResponse</returns>
        ApiListResponseOfPaymentResponse GetAccountDirectDebitsUsingGET (string accountId, string consent, string xYapilyApiVersion, int? limit);
        /// <summary>
        /// Get account payments detail 
        /// </summary>
        /// <param name="accountId">__Mandatory__. The account Id of the user&#x27;s bank account.</param>
        /// <param name="consent">__Mandatory__. The &#x60;consent-token&#x60; containing the user&#x27;s authorisation to make the request.</param>
        /// <param name="xYapilyApiVersion">__Optional__. Determines the API version to use. Valid values are &#x60;1.0&#x60; or &#x60;2.0-ALPHA&#x60;. Defaults to &#x60;1.0&#x60;</param>
        /// <param name="limit">__Optional__. The maximum number of transaction records to be returned. Must be between 0 and 1000.</param>
        /// <returns>ApiListResponseOfPaymentResponse</returns>
        ApiListResponseOfPaymentResponse GetAccountPeriodicPaymentsUsingGET (string accountId, string consent, string xYapilyApiVersion, int? limit);
        /// <summary>
        /// Get account scheduled payments 
        /// </summary>
        /// <param name="accountId">__Mandatory__. The account Id of the user&#x27;s bank account.</param>
        /// <param name="consent">__Mandatory__. The &#x60;consent-token&#x60; containing the user&#x27;s authorisation to make the request.</param>
        /// <param name="xYapilyApiVersion">__Optional__. Determines the API version to use. Valid values are &#x60;1.0&#x60; or &#x60;2.0-ALPHA&#x60;. Defaults to &#x60;1.0&#x60;</param>
        /// <param name="limit">__Optional__. The maximum number of transaction records to be returned. Must be between 0 and 1000.</param>
        /// <returns>ApiListResponseOfPaymentResponse</returns>
        ApiListResponseOfPaymentResponse GetAccountScheduledPaymentsUsingGET (string accountId, string consent, string xYapilyApiVersion, int? limit);
        /// <summary>
        /// Get account 
        /// </summary>
        /// <param name="accountId">__Mandatory__. The account Id of the user&#x27;s bank account.</param>
        /// <param name="consent">__Mandatory__. The &#x60;consent-token&#x60; containing the user&#x27;s authorisation to make the request.</param>
        /// <param name="xYapilyApiVersion">__Optional__. Determines the API version to use. Valid values are &#x60;1.0&#x60; or &#x60;2.0-ALPHA&#x60;. Defaults to &#x60;1.0&#x60;</param>
        /// <param name="psuId">__Conditional__. Represents the user&#x27;s login ID for the &#x60;Institution&#x60; to a personal account. &lt;br&gt;&lt;br&gt;See [PSU identifiers](https://docs.yapily.com/knowledge/psu_identifiers/) to see if this header is required.</param>
        /// <param name="psuCorporateId">__Conditional__. Represents the user&#x27;s login ID for the &#x60;Institution&#x60; to a business account. &lt;br&gt;&lt;br&gt;See [PSU identifiers](https://docs.yapily.com/knowledge/psu_identifiers/) to see if this header is required.</param>
        /// <param name="psuIpAddress">__Conditional__. The IP address of the PSU. &lt;br&gt;&lt;br&gt;See [PSU identifiers](https://docs.yapily.com/knowledge/psu_identifiers/) to see if this header is required.</param>
        /// <returns>ApiResponseOfAccount</returns>
        ApiResponseOfAccount GetAccountUsingGET (string accountId, string consent, string xYapilyApiVersion, string psuId, string psuCorporateId, string psuIpAddress);
        /// <summary>
        /// Get accounts 
        /// </summary>
        /// <param name="consent">__Mandatory__. The &#x60;consent-token&#x60; containing the user&#x27;s authorisation to make the request.</param>
        /// <param name="xYapilyApiVersion">__Optional__. Determines the API version to use. Valid values are &#x60;1.0&#x60; or &#x60;2.0-ALPHA&#x60;. Defaults to &#x60;1.0&#x60;</param>
        /// <param name="psuId">__Conditional__. Represents the user&#x27;s login ID for the &#x60;Institution&#x60; to a personal account. &lt;br&gt;&lt;br&gt;See [PSU identifiers](https://docs.yapily.com/knowledge/psu_identifiers/) to see if this header is required.</param>
        /// <param name="psuCorporateId">__Conditional__. Represents the user&#x27;s login ID for the &#x60;Institution&#x60; to a business account. &lt;br&gt;&lt;br&gt;See [PSU identifiers](https://docs.yapily.com/knowledge/psu_identifiers/) to see if this header is required.</param>
        /// <param name="psuIpAddress">__Conditional__. The IP address of the PSU. &lt;br&gt;&lt;br&gt;See [PSU identifiers](https://docs.yapily.com/knowledge/psu_identifiers/) to see if this header is required.</param>
        /// <returns>ApiListResponseOfAccount</returns>
        ApiListResponseOfAccount GetAccountsUsingGET (string consent, string xYapilyApiVersion, string psuId, string psuCorporateId, string psuIpAddress);
        /// <summary>
        /// Get Beneficiaries 
        /// </summary>
        /// <param name="accountId">__Mandatory__. The account Id of the user&#x27;s bank account.</param>
        /// <param name="consent">__Mandatory__. The &#x60;consent-token&#x60; containing the user&#x27;s authorisation to make the request.</param>
        /// <param name="xYapilyApiVersion">__Optional__. Determines the API version to use. Valid values are &#x60;1.0&#x60; or &#x60;2.0-ALPHA&#x60;. Defaults to &#x60;1.0&#x60;</param>
        /// <returns>ApiResponseOfListOfBeneficiary</returns>
        ApiResponseOfListOfBeneficiary GetBeneficiariesUsingGET (string accountId, string consent, string xYapilyApiVersion);
        /// <summary>
        /// Initiate a new account request for user to authorize 
        /// </summary>
        /// <param name="body">accountAuthRequest</param>
        /// <param name="xYapilyApiVersion">__Optional__. Determines the API version to use. Valid values are &#x60;1.0&#x60; or &#x60;2.0-ALPHA&#x60;. Defaults to &#x60;1.0&#x60;</param>
        /// <param name="psuId">__Conditional__. Represents the user&#x27;s login ID for the &#x60;Institution&#x60; to a personal account. &lt;br&gt;&lt;br&gt;See [PSU identifiers](https://docs.yapily.com/knowledge/psu_identifiers/) to see if this header is required.</param>
        /// <param name="psuCorporateId">__Conditional__. Represents the user&#x27;s login ID for the &#x60;Institution&#x60; to a business account. &lt;br&gt;&lt;br&gt;See [PSU identifiers](https://docs.yapily.com/knowledge/psu_identifiers/) to see if this header is required.</param>
        /// <param name="psuIpAddress">__Conditional__. The IP address of the PSU. &lt;br&gt;&lt;br&gt;See [PSU identifiers](https://docs.yapily.com/knowledge/psu_identifiers/) to see if this header is required.</param>
        /// <returns>ApiResponseOfAuthorisationRequestResponse</returns>
        ApiResponseOfAuthorisationRequestResponse InitiateAccountRequestUsingPOST (AccountAuthorisationRequest body, string xYapilyApiVersion, string psuId, string psuCorporateId, string psuIpAddress);
        /// <summary>
        /// Re-authorise account request 
        /// </summary>
        /// <param name="consent">__Mandatory__. The &#x60;consent-token&#x60; containing the user&#x27;s authorisation to make the request.</param>
        /// <param name="xYapilyApiVersion">__Optional__. Determines the API version to use. Valid values are &#x60;1.0&#x60; or &#x60;2.0-ALPHA&#x60;. Defaults to &#x60;1.0&#x60;</param>
        /// <param name="psuId">__Conditional__. Represents the user&#x27;s login ID for the &#x60;Institution&#x60; to a personal account. &lt;br&gt;&lt;br&gt;See [PSU identifiers](https://docs.yapily.com/knowledge/psu_identifiers/) to see if this header is required.</param>
        /// <param name="psuCorporateId">__Conditional__. Represents the user&#x27;s login ID for the &#x60;Institution&#x60; to a business account. &lt;br&gt;&lt;br&gt;See [PSU identifiers](https://docs.yapily.com/knowledge/psu_identifiers/) to see if this header is required.</param>
        /// <param name="psuIpAddress">__Conditional__. The IP address of the PSU. &lt;br&gt;&lt;br&gt;See [PSU identifiers](https://docs.yapily.com/knowledge/psu_identifiers/) to see if this header is required.</param>
        /// <returns>ApiResponseOfAuthorisationRequestResponse</returns>
        ApiResponseOfAuthorisationRequestResponse ReAuthoriseAccountUsingPATCH (string consent, string xYapilyApiVersion, string psuId, string psuCorporateId, string psuIpAddress);
        /// <summary>
        /// Update pre authorize consent for user to authorise account 
        /// </summary>
        /// <param name="body">accountAuthRequest</param>
        /// <param name="consent">__Mandatory__. The &#x60;consent-token&#x60; containing the user&#x27;s authorisation to make the request.</param>
        /// <param name="xYapilyApiVersion">__Optional__. Determines the API version to use. Valid values are &#x60;1.0&#x60; or &#x60;2.0-ALPHA&#x60;. Defaults to &#x60;1.0&#x60;</param>
        /// <param name="psuId">__Conditional__. Represents the user&#x27;s login ID for the &#x60;Institution&#x60; to a personal account. &lt;br&gt;&lt;br&gt;See [PSU identifiers](https://docs.yapily.com/knowledge/psu_identifiers/) to see if this header is required.</param>
        /// <param name="psuCorporateId">__Conditional__. Represents the user&#x27;s login ID for the &#x60;Institution&#x60; to a business account. &lt;br&gt;&lt;br&gt;See [PSU identifiers](https://docs.yapily.com/knowledge/psu_identifiers/) to see if this header is required.</param>
        /// <param name="psuIpAddress">__Conditional__. The IP address of the PSU. &lt;br&gt;&lt;br&gt;See [PSU identifiers](https://docs.yapily.com/knowledge/psu_identifiers/) to see if this header is required.</param>
        /// <returns>ApiResponseOfAuthorisationRequestResponse</returns>
        ApiResponseOfAuthorisationRequestResponse UpdatePreAuthoriseAccountConsentUsingPUT (AccountAuthorisationRequest body, string consent, string xYapilyApiVersion, string psuId, string psuCorporateId, string psuIpAddress);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class AccountsApi : IAccountsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountsApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public AccountsApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AccountsApi(String basePath)
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
        /// Get account direct debits 
        /// </summary>
        /// <param name="accountId">__Mandatory__. The account Id of the user&#x27;s bank account.</param>
        /// <param name="consent">__Mandatory__. The &#x60;consent-token&#x60; containing the user&#x27;s authorisation to make the request.</param>
        /// <param name="xYapilyApiVersion">__Optional__. Determines the API version to use. Valid values are &#x60;1.0&#x60; or &#x60;2.0-ALPHA&#x60;. Defaults to &#x60;1.0&#x60;</param>
        /// <param name="limit">__Optional__. The maximum number of transaction records to be returned. Must be between 0 and 1000.</param>
        /// <returns>ApiListResponseOfPaymentResponse</returns>
        public ApiListResponseOfPaymentResponse GetAccountDirectDebitsUsingGET (string accountId, string consent, string xYapilyApiVersion, int? limit)
        {
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling GetAccountDirectDebitsUsingGET");
            // verify the required parameter 'consent' is set
            if (consent == null) throw new ApiException(400, "Missing required parameter 'consent' when calling GetAccountDirectDebitsUsingGET");
    
            var path = "/accounts/{accountId}/direct-debits";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "accountId" + "}", ApiClient.ParameterToString(accountId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (limit != null) queryParams.Add("limit", ApiClient.ParameterToString(limit)); // query parameter
             if (xYapilyApiVersion != null) headerParams.Add("x-yapily-api-version", ApiClient.ParameterToString(xYapilyApiVersion)); // header parameter
 if (consent != null) headerParams.Add("consent", ApiClient.ParameterToString(consent)); // header parameter
            
            // authentication setting, if any
            String[] authSettings = new String[] { "basicAuth", "tokenAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetAccountDirectDebitsUsingGET: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetAccountDirectDebitsUsingGET: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ApiListResponseOfPaymentResponse) ApiClient.Deserialize(response.Content, typeof(ApiListResponseOfPaymentResponse), response.Headers);
        }
    
        /// <summary>
        /// Get account payments detail 
        /// </summary>
        /// <param name="accountId">__Mandatory__. The account Id of the user&#x27;s bank account.</param>
        /// <param name="consent">__Mandatory__. The &#x60;consent-token&#x60; containing the user&#x27;s authorisation to make the request.</param>
        /// <param name="xYapilyApiVersion">__Optional__. Determines the API version to use. Valid values are &#x60;1.0&#x60; or &#x60;2.0-ALPHA&#x60;. Defaults to &#x60;1.0&#x60;</param>
        /// <param name="limit">__Optional__. The maximum number of transaction records to be returned. Must be between 0 and 1000.</param>
        /// <returns>ApiListResponseOfPaymentResponse</returns>
        public ApiListResponseOfPaymentResponse GetAccountPeriodicPaymentsUsingGET (string accountId, string consent, string xYapilyApiVersion, int? limit)
        {
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling GetAccountPeriodicPaymentsUsingGET");
            // verify the required parameter 'consent' is set
            if (consent == null) throw new ApiException(400, "Missing required parameter 'consent' when calling GetAccountPeriodicPaymentsUsingGET");
    
            var path = "/accounts/{accountId}/periodic-payments";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "accountId" + "}", ApiClient.ParameterToString(accountId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (limit != null) queryParams.Add("limit", ApiClient.ParameterToString(limit)); // query parameter
             if (xYapilyApiVersion != null) headerParams.Add("x-yapily-api-version", ApiClient.ParameterToString(xYapilyApiVersion)); // header parameter
 if (consent != null) headerParams.Add("consent", ApiClient.ParameterToString(consent)); // header parameter
            
            // authentication setting, if any
            String[] authSettings = new String[] { "basicAuth", "tokenAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetAccountPeriodicPaymentsUsingGET: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetAccountPeriodicPaymentsUsingGET: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ApiListResponseOfPaymentResponse) ApiClient.Deserialize(response.Content, typeof(ApiListResponseOfPaymentResponse), response.Headers);
        }
    
        /// <summary>
        /// Get account scheduled payments 
        /// </summary>
        /// <param name="accountId">__Mandatory__. The account Id of the user&#x27;s bank account.</param>
        /// <param name="consent">__Mandatory__. The &#x60;consent-token&#x60; containing the user&#x27;s authorisation to make the request.</param>
        /// <param name="xYapilyApiVersion">__Optional__. Determines the API version to use. Valid values are &#x60;1.0&#x60; or &#x60;2.0-ALPHA&#x60;. Defaults to &#x60;1.0&#x60;</param>
        /// <param name="limit">__Optional__. The maximum number of transaction records to be returned. Must be between 0 and 1000.</param>
        /// <returns>ApiListResponseOfPaymentResponse</returns>
        public ApiListResponseOfPaymentResponse GetAccountScheduledPaymentsUsingGET (string accountId, string consent, string xYapilyApiVersion, int? limit)
        {
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling GetAccountScheduledPaymentsUsingGET");
            // verify the required parameter 'consent' is set
            if (consent == null) throw new ApiException(400, "Missing required parameter 'consent' when calling GetAccountScheduledPaymentsUsingGET");
    
            var path = "/accounts/{accountId}/scheduled-payments";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "accountId" + "}", ApiClient.ParameterToString(accountId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (limit != null) queryParams.Add("limit", ApiClient.ParameterToString(limit)); // query parameter
             if (xYapilyApiVersion != null) headerParams.Add("x-yapily-api-version", ApiClient.ParameterToString(xYapilyApiVersion)); // header parameter
 if (consent != null) headerParams.Add("consent", ApiClient.ParameterToString(consent)); // header parameter
            
            // authentication setting, if any
            String[] authSettings = new String[] { "basicAuth", "tokenAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetAccountScheduledPaymentsUsingGET: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetAccountScheduledPaymentsUsingGET: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ApiListResponseOfPaymentResponse) ApiClient.Deserialize(response.Content, typeof(ApiListResponseOfPaymentResponse), response.Headers);
        }
    
        /// <summary>
        /// Get account 
        /// </summary>
        /// <param name="accountId">__Mandatory__. The account Id of the user&#x27;s bank account.</param>
        /// <param name="consent">__Mandatory__. The &#x60;consent-token&#x60; containing the user&#x27;s authorisation to make the request.</param>
        /// <param name="xYapilyApiVersion">__Optional__. Determines the API version to use. Valid values are &#x60;1.0&#x60; or &#x60;2.0-ALPHA&#x60;. Defaults to &#x60;1.0&#x60;</param>
        /// <param name="psuId">__Conditional__. Represents the user&#x27;s login ID for the &#x60;Institution&#x60; to a personal account. &lt;br&gt;&lt;br&gt;See [PSU identifiers](https://docs.yapily.com/knowledge/psu_identifiers/) to see if this header is required.</param>
        /// <param name="psuCorporateId">__Conditional__. Represents the user&#x27;s login ID for the &#x60;Institution&#x60; to a business account. &lt;br&gt;&lt;br&gt;See [PSU identifiers](https://docs.yapily.com/knowledge/psu_identifiers/) to see if this header is required.</param>
        /// <param name="psuIpAddress">__Conditional__. The IP address of the PSU. &lt;br&gt;&lt;br&gt;See [PSU identifiers](https://docs.yapily.com/knowledge/psu_identifiers/) to see if this header is required.</param>
        /// <returns>ApiResponseOfAccount</returns>
        public ApiResponseOfAccount GetAccountUsingGET (string accountId, string consent, string xYapilyApiVersion, string psuId, string psuCorporateId, string psuIpAddress)
        {
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling GetAccountUsingGET");
            // verify the required parameter 'consent' is set
            if (consent == null) throw new ApiException(400, "Missing required parameter 'consent' when calling GetAccountUsingGET");
    
            var path = "/accounts/{accountId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "accountId" + "}", ApiClient.ParameterToString(accountId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                         if (consent != null) headerParams.Add("consent", ApiClient.ParameterToString(consent)); // header parameter
 if (xYapilyApiVersion != null) headerParams.Add("x-yapily-api-version", ApiClient.ParameterToString(xYapilyApiVersion)); // header parameter
 if (psuId != null) headerParams.Add("psu-id", ApiClient.ParameterToString(psuId)); // header parameter
 if (psuCorporateId != null) headerParams.Add("psu-corporate-id", ApiClient.ParameterToString(psuCorporateId)); // header parameter
 if (psuIpAddress != null) headerParams.Add("psu-ip-address", ApiClient.ParameterToString(psuIpAddress)); // header parameter
            
            // authentication setting, if any
            String[] authSettings = new String[] { "basicAuth", "tokenAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetAccountUsingGET: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetAccountUsingGET: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ApiResponseOfAccount) ApiClient.Deserialize(response.Content, typeof(ApiResponseOfAccount), response.Headers);
        }
    
        /// <summary>
        /// Get accounts 
        /// </summary>
        /// <param name="consent">__Mandatory__. The &#x60;consent-token&#x60; containing the user&#x27;s authorisation to make the request.</param>
        /// <param name="xYapilyApiVersion">__Optional__. Determines the API version to use. Valid values are &#x60;1.0&#x60; or &#x60;2.0-ALPHA&#x60;. Defaults to &#x60;1.0&#x60;</param>
        /// <param name="psuId">__Conditional__. Represents the user&#x27;s login ID for the &#x60;Institution&#x60; to a personal account. &lt;br&gt;&lt;br&gt;See [PSU identifiers](https://docs.yapily.com/knowledge/psu_identifiers/) to see if this header is required.</param>
        /// <param name="psuCorporateId">__Conditional__. Represents the user&#x27;s login ID for the &#x60;Institution&#x60; to a business account. &lt;br&gt;&lt;br&gt;See [PSU identifiers](https://docs.yapily.com/knowledge/psu_identifiers/) to see if this header is required.</param>
        /// <param name="psuIpAddress">__Conditional__. The IP address of the PSU. &lt;br&gt;&lt;br&gt;See [PSU identifiers](https://docs.yapily.com/knowledge/psu_identifiers/) to see if this header is required.</param>
        /// <returns>ApiListResponseOfAccount</returns>
        public ApiListResponseOfAccount GetAccountsUsingGET (string consent, string xYapilyApiVersion, string psuId, string psuCorporateId, string psuIpAddress)
        {
            // verify the required parameter 'consent' is set
            if (consent == null) throw new ApiException(400, "Missing required parameter 'consent' when calling GetAccountsUsingGET");
    
            var path = "/accounts";
            path = path.Replace("{format}", "json");
                
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetAccountsUsingGET: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetAccountsUsingGET: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ApiListResponseOfAccount) ApiClient.Deserialize(response.Content, typeof(ApiListResponseOfAccount), response.Headers);
        }
    
        /// <summary>
        /// Get Beneficiaries 
        /// </summary>
        /// <param name="accountId">__Mandatory__. The account Id of the user&#x27;s bank account.</param>
        /// <param name="consent">__Mandatory__. The &#x60;consent-token&#x60; containing the user&#x27;s authorisation to make the request.</param>
        /// <param name="xYapilyApiVersion">__Optional__. Determines the API version to use. Valid values are &#x60;1.0&#x60; or &#x60;2.0-ALPHA&#x60;. Defaults to &#x60;1.0&#x60;</param>
        /// <returns>ApiResponseOfListOfBeneficiary</returns>
        public ApiResponseOfListOfBeneficiary GetBeneficiariesUsingGET (string accountId, string consent, string xYapilyApiVersion)
        {
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling GetBeneficiariesUsingGET");
            // verify the required parameter 'consent' is set
            if (consent == null) throw new ApiException(400, "Missing required parameter 'consent' when calling GetBeneficiariesUsingGET");
    
            var path = "/accounts/{accountId}/beneficiaries";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "accountId" + "}", ApiClient.ParameterToString(accountId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetBeneficiariesUsingGET: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetBeneficiariesUsingGET: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ApiResponseOfListOfBeneficiary) ApiClient.Deserialize(response.Content, typeof(ApiResponseOfListOfBeneficiary), response.Headers);
        }
    
        /// <summary>
        /// Initiate a new account request for user to authorize 
        /// </summary>
        /// <param name="body">accountAuthRequest</param>
        /// <param name="xYapilyApiVersion">__Optional__. Determines the API version to use. Valid values are &#x60;1.0&#x60; or &#x60;2.0-ALPHA&#x60;. Defaults to &#x60;1.0&#x60;</param>
        /// <param name="psuId">__Conditional__. Represents the user&#x27;s login ID for the &#x60;Institution&#x60; to a personal account. &lt;br&gt;&lt;br&gt;See [PSU identifiers](https://docs.yapily.com/knowledge/psu_identifiers/) to see if this header is required.</param>
        /// <param name="psuCorporateId">__Conditional__. Represents the user&#x27;s login ID for the &#x60;Institution&#x60; to a business account. &lt;br&gt;&lt;br&gt;See [PSU identifiers](https://docs.yapily.com/knowledge/psu_identifiers/) to see if this header is required.</param>
        /// <param name="psuIpAddress">__Conditional__. The IP address of the PSU. &lt;br&gt;&lt;br&gt;See [PSU identifiers](https://docs.yapily.com/knowledge/psu_identifiers/) to see if this header is required.</param>
        /// <returns>ApiResponseOfAuthorisationRequestResponse</returns>
        public ApiResponseOfAuthorisationRequestResponse InitiateAccountRequestUsingPOST (AccountAuthorisationRequest body, string xYapilyApiVersion, string psuId, string psuCorporateId, string psuIpAddress)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling InitiateAccountRequestUsingPOST");
    
            var path = "/account-auth-requests";
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
                throw new ApiException ((int)response.StatusCode, "Error calling InitiateAccountRequestUsingPOST: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling InitiateAccountRequestUsingPOST: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ApiResponseOfAuthorisationRequestResponse) ApiClient.Deserialize(response.Content, typeof(ApiResponseOfAuthorisationRequestResponse), response.Headers);
        }
    
        /// <summary>
        /// Re-authorise account request 
        /// </summary>
        /// <param name="consent">__Mandatory__. The &#x60;consent-token&#x60; containing the user&#x27;s authorisation to make the request.</param>
        /// <param name="xYapilyApiVersion">__Optional__. Determines the API version to use. Valid values are &#x60;1.0&#x60; or &#x60;2.0-ALPHA&#x60;. Defaults to &#x60;1.0&#x60;</param>
        /// <param name="psuId">__Conditional__. Represents the user&#x27;s login ID for the &#x60;Institution&#x60; to a personal account. &lt;br&gt;&lt;br&gt;See [PSU identifiers](https://docs.yapily.com/knowledge/psu_identifiers/) to see if this header is required.</param>
        /// <param name="psuCorporateId">__Conditional__. Represents the user&#x27;s login ID for the &#x60;Institution&#x60; to a business account. &lt;br&gt;&lt;br&gt;See [PSU identifiers](https://docs.yapily.com/knowledge/psu_identifiers/) to see if this header is required.</param>
        /// <param name="psuIpAddress">__Conditional__. The IP address of the PSU. &lt;br&gt;&lt;br&gt;See [PSU identifiers](https://docs.yapily.com/knowledge/psu_identifiers/) to see if this header is required.</param>
        /// <returns>ApiResponseOfAuthorisationRequestResponse</returns>
        public ApiResponseOfAuthorisationRequestResponse ReAuthoriseAccountUsingPATCH (string consent, string xYapilyApiVersion, string psuId, string psuCorporateId, string psuIpAddress)
        {
            // verify the required parameter 'consent' is set
            if (consent == null) throw new ApiException(400, "Missing required parameter 'consent' when calling ReAuthoriseAccountUsingPATCH");
    
            var path = "/account-auth-requests";
            path = path.Replace("{format}", "json");
                
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
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PATCH, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ReAuthoriseAccountUsingPATCH: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReAuthoriseAccountUsingPATCH: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ApiResponseOfAuthorisationRequestResponse) ApiClient.Deserialize(response.Content, typeof(ApiResponseOfAuthorisationRequestResponse), response.Headers);
        }
    
        /// <summary>
        /// Update pre authorize consent for user to authorise account 
        /// </summary>
        /// <param name="body">accountAuthRequest</param>
        /// <param name="consent">__Mandatory__. The &#x60;consent-token&#x60; containing the user&#x27;s authorisation to make the request.</param>
        /// <param name="xYapilyApiVersion">__Optional__. Determines the API version to use. Valid values are &#x60;1.0&#x60; or &#x60;2.0-ALPHA&#x60;. Defaults to &#x60;1.0&#x60;</param>
        /// <param name="psuId">__Conditional__. Represents the user&#x27;s login ID for the &#x60;Institution&#x60; to a personal account. &lt;br&gt;&lt;br&gt;See [PSU identifiers](https://docs.yapily.com/knowledge/psu_identifiers/) to see if this header is required.</param>
        /// <param name="psuCorporateId">__Conditional__. Represents the user&#x27;s login ID for the &#x60;Institution&#x60; to a business account. &lt;br&gt;&lt;br&gt;See [PSU identifiers](https://docs.yapily.com/knowledge/psu_identifiers/) to see if this header is required.</param>
        /// <param name="psuIpAddress">__Conditional__. The IP address of the PSU. &lt;br&gt;&lt;br&gt;See [PSU identifiers](https://docs.yapily.com/knowledge/psu_identifiers/) to see if this header is required.</param>
        /// <returns>ApiResponseOfAuthorisationRequestResponse</returns>
        public ApiResponseOfAuthorisationRequestResponse UpdatePreAuthoriseAccountConsentUsingPUT (AccountAuthorisationRequest body, string consent, string xYapilyApiVersion, string psuId, string psuCorporateId, string psuIpAddress)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UpdatePreAuthoriseAccountConsentUsingPUT");
            // verify the required parameter 'consent' is set
            if (consent == null) throw new ApiException(400, "Missing required parameter 'consent' when calling UpdatePreAuthoriseAccountConsentUsingPUT");
    
            var path = "/account-auth-requests";
            path = path.Replace("{format}", "json");
                
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
            postBody = ApiClient.Serialize(body); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] { "basicAuth", "tokenAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdatePreAuthoriseAccountConsentUsingPUT: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdatePreAuthoriseAccountConsentUsingPUT: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ApiResponseOfAuthorisationRequestResponse) ApiClient.Deserialize(response.Content, typeof(ApiResponseOfAuthorisationRequestResponse), response.Headers);
        }
    
    }
}
