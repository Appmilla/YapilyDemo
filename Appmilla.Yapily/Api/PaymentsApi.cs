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
    public interface IPaymentsApi
    {
        /// <summary>
        /// Initiate bulk payment for user to authorise 
        /// </summary>
        /// <param name="body">paymentAuthRequest</param>
        /// <param name="xYapilyApiVersion">__Optional__. Determines the API version to use. Valid values are &#x60;1.0&#x60; or &#x60;2.0-ALPHA&#x60;. Defaults to &#x60;1.0&#x60;</param>
        /// <param name="psuId">__Conditional__. Represents the user&#x27;s login ID for the &#x60;Institution&#x60; to a personal account. &lt;br&gt;&lt;br&gt;See [PSU identifiers](https://docs.yapily.com/knowledge/psu_identifiers/) to see if this header is required.</param>
        /// <param name="psuCorporateId">__Conditional__. Represents the user&#x27;s login ID for the &#x60;Institution&#x60; to a business account. &lt;br&gt;&lt;br&gt;See [PSU identifiers](https://docs.yapily.com/knowledge/psu_identifiers/) to see if this header is required.</param>
        /// <param name="psuIpAddress">__Conditional__. The IP address of the PSU. &lt;br&gt;&lt;br&gt;See [PSU identifiers](https://docs.yapily.com/knowledge/psu_identifiers/) to see if this header is required.</param>
        /// <returns>ApiResponseOfPaymentAuthorisationRequestResponse</returns>
        ApiResponseOfPaymentAuthorisationRequestResponse CreateBulkPaymentAuthorisationUsingPOST (BulkPaymentAuthorisationRequest body, string xYapilyApiVersion, string psuId, string psuCorporateId, string psuIpAddress);
        /// <summary>
        /// Create bulk payment 
        /// </summary>
        /// <param name="body">paymentRequest</param>
        /// <param name="consent">__Mandatory__. The &#x60;consent-token&#x60; containing the user&#x27;s authorisation to make the request.</param>
        /// <param name="xYapilyApiVersion">__Optional__. Determines the API version to use. Valid values are &#x60;1.0&#x60; or &#x60;2.0-ALPHA&#x60;. Defaults to &#x60;1.0&#x60;</param>
        /// <param name="psuId">__Conditional__. Represents the user&#x27;s login ID for the &#x60;Institution&#x60; to a personal account. &lt;br&gt;&lt;br&gt;See [PSU identifiers](https://docs.yapily.com/knowledge/psu_identifiers/) to see if this header is required.</param>
        /// <param name="psuCorporateId">__Conditional__. Represents the user&#x27;s login ID for the &#x60;Institution&#x60; to a business account. &lt;br&gt;&lt;br&gt;See [PSU identifiers](https://docs.yapily.com/knowledge/psu_identifiers/) to see if this header is required.</param>
        /// <param name="psuIpAddress">__Conditional__. The IP address of the PSU. &lt;br&gt;&lt;br&gt;See [PSU identifiers](https://docs.yapily.com/knowledge/psu_identifiers/) to see if this header is required.</param>
        /// <returns>ApiResponseOfPaymentResponse</returns>
        ApiResponseOfPaymentResponse CreateBulkPaymentUsingPOST (BulkPaymentRequest body, string consent, string xYapilyApiVersion, string psuId, string psuCorporateId, string psuIpAddress);
        /// <summary>
        /// Initiate a payment for user to authorise 
        /// </summary>
        /// <param name="body">paymentAuthRequest</param>
        /// <param name="xYapilyApiVersion">__Optional__. Determines the API version to use. Valid values are &#x60;1.0&#x60; or &#x60;2.0-ALPHA&#x60;. Defaults to &#x60;1.0&#x60;</param>
        /// <param name="psuId">__Conditional__. Represents the user&#x27;s login ID for the &#x60;Institution&#x60; to a personal account. &lt;br&gt;&lt;br&gt;See [PSU identifiers](https://docs.yapily.com/knowledge/psu_identifiers/) to see if this header is required.</param>
        /// <param name="psuCorporateId">__Conditional__. Represents the user&#x27;s login ID for the &#x60;Institution&#x60; to a business account. &lt;br&gt;&lt;br&gt;See [PSU identifiers](https://docs.yapily.com/knowledge/psu_identifiers/) to see if this header is required.</param>
        /// <param name="psuIpAddress">__Conditional__. The IP address of the PSU. &lt;br&gt;&lt;br&gt;See [PSU identifiers](https://docs.yapily.com/knowledge/psu_identifiers/) to see if this header is required.</param>
        /// <returns>ApiResponseOfPaymentAuthorisationRequestResponse</returns>
        ApiResponseOfPaymentAuthorisationRequestResponse CreatePaymentAuthorisationUsingPOST (PaymentAuthorisationRequest body, string xYapilyApiVersion, string psuId, string psuCorporateId, string psuIpAddress);
        /// <summary>
        /// Initiate a new single payment for user to authorise 
        /// </summary>
        /// <param name="body">paymentAuthRequest</param>
        /// <param name="xYapilyApiVersion">__Optional__. Determines the API version to use. Valid values are &#x60;1.0&#x60; or &#x60;2.0-ALPHA&#x60;. Defaults to &#x60;1.0&#x60;</param>
        /// <param name="psuId">__Conditional__. Represents the user&#x27;s login ID for the &#x60;Institution&#x60; to a personal account. &lt;br&gt;&lt;br&gt;See [PSU identifiers](https://docs.yapily.com/knowledge/psu_identifiers/) to see if this header is required.</param>
        /// <param name="psuCorporateId">__Conditional__. Represents the user&#x27;s login ID for the &#x60;Institution&#x60; to a business account. &lt;br&gt;&lt;br&gt;See [PSU identifiers](https://docs.yapily.com/knowledge/psu_identifiers/) to see if this header is required.</param>
        /// <param name="psuIpAddress">__Conditional__. The IP address of the PSU. &lt;br&gt;&lt;br&gt;See [PSU identifiers](https://docs.yapily.com/knowledge/psu_identifiers/) to see if this header is required.</param>
        /// <returns>ApiResponseOfAuthorisationRequestResponse</returns>
        ApiResponseOfAuthorisationRequestResponse CreatePaymentAuthorisationWithSortCodeUsingPOST (SortCodePaymentAuthRequest body, string xYapilyApiVersion, string psuId, string psuCorporateId, string psuIpAddress);
        /// <summary>
        /// Create a payment 
        /// </summary>
        /// <param name="body">paymentRequest</param>
        /// <param name="consent">__Mandatory__. The &#x60;consent-token&#x60; containing the user&#x27;s authorisation to make the request.</param>
        /// <param name="xYapilyApiVersion">__Optional__. Determines the API version to use. Valid values are &#x60;1.0&#x60; or &#x60;2.0-ALPHA&#x60;. Defaults to &#x60;1.0&#x60;</param>
        /// <param name="psuId">__Conditional__. Represents the user&#x27;s login ID for the &#x60;Institution&#x60; to a personal account. &lt;br&gt;&lt;br&gt;See [PSU identifiers](https://docs.yapily.com/knowledge/psu_identifiers/) to see if this header is required.</param>
        /// <param name="psuCorporateId">__Conditional__. Represents the user&#x27;s login ID for the &#x60;Institution&#x60; to a business account. &lt;br&gt;&lt;br&gt;See [PSU identifiers](https://docs.yapily.com/knowledge/psu_identifiers/) to see if this header is required.</param>
        /// <param name="psuIpAddress">__Conditional__. The IP address of the PSU. &lt;br&gt;&lt;br&gt;See [PSU identifiers](https://docs.yapily.com/knowledge/psu_identifiers/) to see if this header is required.</param>
        /// <returns>ApiResponseOfPaymentResponse</returns>
        ApiResponseOfPaymentResponse CreatePaymentUsingPOST (PaymentRequest body, string consent, string xYapilyApiVersion, string psuId, string psuCorporateId, string psuIpAddress);
        /// <summary>
        /// Create a new single payment 
        /// </summary>
        /// <param name="body">paymentRequest</param>
        /// <param name="consent">__Mandatory__. The &#x60;consent-token&#x60; containing the user&#x27;s authorisation to make the request.</param>
        /// <param name="xYapilyApiVersion">__Optional__. Determines the API version to use. Valid values are &#x60;1.0&#x60; or &#x60;2.0-ALPHA&#x60;. Defaults to &#x60;1.0&#x60;</param>
        /// <param name="psuId">__Conditional__. Represents the user&#x27;s login ID for the &#x60;Institution&#x60; to a personal account. &lt;br&gt;&lt;br&gt;See [PSU identifiers](https://docs.yapily.com/knowledge/psu_identifiers/) to see if this header is required.</param>
        /// <param name="psuCorporateId">__Conditional__. Represents the user&#x27;s login ID for the &#x60;Institution&#x60; to a business account. &lt;br&gt;&lt;br&gt;See [PSU identifiers](https://docs.yapily.com/knowledge/psu_identifiers/) to see if this header is required.</param>
        /// <param name="psuIpAddress">__Conditional__. The IP address of the PSU. &lt;br&gt;&lt;br&gt;See [PSU identifiers](https://docs.yapily.com/knowledge/psu_identifiers/) to see if this header is required.</param>
        /// <returns>ApiResponseOfPaymentResponse</returns>
        ApiResponseOfPaymentResponse CreatePaymentWithSortCodeUsingPOST (SortCodePaymentRequest body, string consent, string xYapilyApiVersion, string psuId, string psuCorporateId, string psuIpAddress);
        /// <summary>
        /// Get status of a payment 
        /// </summary>
        /// <param name="paymentId">__Mandatory__. The payment Id of the payment.</param>
        /// <param name="consent">__Mandatory__. The &#x60;consent-token&#x60; containing the user&#x27;s authorisation to make the request.</param>
        /// <param name="xYapilyApiVersion">__Optional__. Determines the API version to use. Valid values are &#x60;1.0&#x60; or &#x60;2.0-ALPHA&#x60;. Defaults to &#x60;1.0&#x60;</param>
        /// <param name="psuId">__Conditional__. Represents the user&#x27;s login ID for the &#x60;Institution&#x60; to a personal account. &lt;br&gt;&lt;br&gt;See [PSU identifiers](https://docs.yapily.com/knowledge/psu_identifiers/) to see if this header is required.</param>
        /// <param name="psuCorporateId">__Conditional__. Represents the user&#x27;s login ID for the &#x60;Institution&#x60; to a business account. &lt;br&gt;&lt;br&gt;See [PSU identifiers](https://docs.yapily.com/knowledge/psu_identifiers/) to see if this header is required.</param>
        /// <param name="psuIpAddress">__Conditional__. The IP address of the PSU. &lt;br&gt;&lt;br&gt;See [PSU identifiers](https://docs.yapily.com/knowledge/psu_identifiers/) to see if this header is required.</param>
        /// <returns>ApiResponseOfPaymentResponse</returns>
        ApiResponseOfPaymentResponse GetPaymentStatusUsingGET (string paymentId, string consent, string xYapilyApiVersion, string psuId, string psuCorporateId, string psuIpAddress);
        /// <summary>
        /// Get payments details 
        /// </summary>
        /// <param name="paymentId">__Mandatory__. The payment Id of the payment.</param>
        /// <param name="consent">__Mandatory__. The &#x60;consent-token&#x60; containing the user&#x27;s authorisation to make the request.</param>
        /// <param name="xYapilyApiVersion">__Optional__. Determines the API version to use. Valid values are &#x60;1.0&#x60; or &#x60;2.0-ALPHA&#x60;. Defaults to &#x60;1.0&#x60;</param>
        /// <param name="psuId">__Conditional__. Represents the user&#x27;s login ID for the &#x60;Institution&#x60; to a personal account. &lt;br&gt;&lt;br&gt;See [PSU identifiers](https://docs.yapily.com/knowledge/psu_identifiers/) to see if this header is required.</param>
        /// <param name="psuCorporateId">__Conditional__. Represents the user&#x27;s login ID for the &#x60;Institution&#x60; to a business account. &lt;br&gt;&lt;br&gt;See [PSU identifiers](https://docs.yapily.com/knowledge/psu_identifiers/) to see if this header is required.</param>
        /// <param name="psuIpAddress">__Conditional__. The IP address of the PSU. &lt;br&gt;&lt;br&gt;See [PSU identifiers](https://docs.yapily.com/knowledge/psu_identifiers/) to see if this header is required.</param>
        /// <returns>ApiResponseOfPaymentResponses</returns>
        ApiResponseOfPaymentResponses GetPaymentsUsingGET (string paymentId, string consent, string xYapilyApiVersion, string psuId, string psuCorporateId, string psuIpAddress);
        /// <summary>
        /// Update pre authorize consent for user to authorise payment 
        /// </summary>
        /// <param name="body">paymentAuthRequest</param>
        /// <param name="consent">__Mandatory__. The &#x60;consent-token&#x60; containing the user&#x27;s authorisation to make the request.</param>
        /// <param name="xYapilyApiVersion">__Optional__. Determines the API version to use. Valid values are &#x60;1.0&#x60; or &#x60;2.0-ALPHA&#x60;. Defaults to &#x60;1.0&#x60;</param>
        /// <param name="psuId">__Conditional__. Represents the user&#x27;s login ID for the &#x60;Institution&#x60; to a personal account. &lt;br&gt;&lt;br&gt;See [PSU identifiers](https://docs.yapily.com/knowledge/psu_identifiers/) to see if this header is required.</param>
        /// <param name="psuCorporateId">__Conditional__. Represents the user&#x27;s login ID for the &#x60;Institution&#x60; to a business account. &lt;br&gt;&lt;br&gt;See [PSU identifiers](https://docs.yapily.com/knowledge/psu_identifiers/) to see if this header is required.</param>
        /// <param name="psuIpAddress">__Conditional__. The IP address of the PSU. &lt;br&gt;&lt;br&gt;See [PSU identifiers](https://docs.yapily.com/knowledge/psu_identifiers/) to see if this header is required.</param>
        /// <returns>ApiResponseOfPaymentAuthorisationRequestResponse</returns>
        ApiResponseOfPaymentAuthorisationRequestResponse UpdatePaymentAuthorisationUsingPUT (PaymentAuthorisationRequest body, string consent, string xYapilyApiVersion, string psuId, string psuCorporateId, string psuIpAddress);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class PaymentsApi : IPaymentsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentsApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public PaymentsApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public PaymentsApi(String basePath)
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
        /// Initiate bulk payment for user to authorise 
        /// </summary>
        /// <param name="body">paymentAuthRequest</param>
        /// <param name="xYapilyApiVersion">__Optional__. Determines the API version to use. Valid values are &#x60;1.0&#x60; or &#x60;2.0-ALPHA&#x60;. Defaults to &#x60;1.0&#x60;</param>
        /// <param name="psuId">__Conditional__. Represents the user&#x27;s login ID for the &#x60;Institution&#x60; to a personal account. &lt;br&gt;&lt;br&gt;See [PSU identifiers](https://docs.yapily.com/knowledge/psu_identifiers/) to see if this header is required.</param>
        /// <param name="psuCorporateId">__Conditional__. Represents the user&#x27;s login ID for the &#x60;Institution&#x60; to a business account. &lt;br&gt;&lt;br&gt;See [PSU identifiers](https://docs.yapily.com/knowledge/psu_identifiers/) to see if this header is required.</param>
        /// <param name="psuIpAddress">__Conditional__. The IP address of the PSU. &lt;br&gt;&lt;br&gt;See [PSU identifiers](https://docs.yapily.com/knowledge/psu_identifiers/) to see if this header is required.</param>
        /// <returns>ApiResponseOfPaymentAuthorisationRequestResponse</returns>
        public ApiResponseOfPaymentAuthorisationRequestResponse CreateBulkPaymentAuthorisationUsingPOST (BulkPaymentAuthorisationRequest body, string xYapilyApiVersion, string psuId, string psuCorporateId, string psuIpAddress)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling CreateBulkPaymentAuthorisationUsingPOST");
    
            var path = "/bulk-payment-auth-requests";
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
                throw new ApiException ((int)response.StatusCode, "Error calling CreateBulkPaymentAuthorisationUsingPOST: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateBulkPaymentAuthorisationUsingPOST: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ApiResponseOfPaymentAuthorisationRequestResponse) ApiClient.Deserialize(response.Content, typeof(ApiResponseOfPaymentAuthorisationRequestResponse), response.Headers);
        }
    
        /// <summary>
        /// Create bulk payment 
        /// </summary>
        /// <param name="body">paymentRequest</param>
        /// <param name="consent">__Mandatory__. The &#x60;consent-token&#x60; containing the user&#x27;s authorisation to make the request.</param>
        /// <param name="xYapilyApiVersion">__Optional__. Determines the API version to use. Valid values are &#x60;1.0&#x60; or &#x60;2.0-ALPHA&#x60;. Defaults to &#x60;1.0&#x60;</param>
        /// <param name="psuId">__Conditional__. Represents the user&#x27;s login ID for the &#x60;Institution&#x60; to a personal account. &lt;br&gt;&lt;br&gt;See [PSU identifiers](https://docs.yapily.com/knowledge/psu_identifiers/) to see if this header is required.</param>
        /// <param name="psuCorporateId">__Conditional__. Represents the user&#x27;s login ID for the &#x60;Institution&#x60; to a business account. &lt;br&gt;&lt;br&gt;See [PSU identifiers](https://docs.yapily.com/knowledge/psu_identifiers/) to see if this header is required.</param>
        /// <param name="psuIpAddress">__Conditional__. The IP address of the PSU. &lt;br&gt;&lt;br&gt;See [PSU identifiers](https://docs.yapily.com/knowledge/psu_identifiers/) to see if this header is required.</param>
        /// <returns>ApiResponseOfPaymentResponse</returns>
        public ApiResponseOfPaymentResponse CreateBulkPaymentUsingPOST (BulkPaymentRequest body, string consent, string xYapilyApiVersion, string psuId, string psuCorporateId, string psuIpAddress)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling CreateBulkPaymentUsingPOST");
            // verify the required parameter 'consent' is set
            if (consent == null) throw new ApiException(400, "Missing required parameter 'consent' when calling CreateBulkPaymentUsingPOST");
    
            var path = "/bulk-payments";
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
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateBulkPaymentUsingPOST: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateBulkPaymentUsingPOST: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ApiResponseOfPaymentResponse) ApiClient.Deserialize(response.Content, typeof(ApiResponseOfPaymentResponse), response.Headers);
        }
    
        /// <summary>
        /// Initiate a payment for user to authorise 
        /// </summary>
        /// <param name="body">paymentAuthRequest</param>
        /// <param name="xYapilyApiVersion">__Optional__. Determines the API version to use. Valid values are &#x60;1.0&#x60; or &#x60;2.0-ALPHA&#x60;. Defaults to &#x60;1.0&#x60;</param>
        /// <param name="psuId">__Conditional__. Represents the user&#x27;s login ID for the &#x60;Institution&#x60; to a personal account. &lt;br&gt;&lt;br&gt;See [PSU identifiers](https://docs.yapily.com/knowledge/psu_identifiers/) to see if this header is required.</param>
        /// <param name="psuCorporateId">__Conditional__. Represents the user&#x27;s login ID for the &#x60;Institution&#x60; to a business account. &lt;br&gt;&lt;br&gt;See [PSU identifiers](https://docs.yapily.com/knowledge/psu_identifiers/) to see if this header is required.</param>
        /// <param name="psuIpAddress">__Conditional__. The IP address of the PSU. &lt;br&gt;&lt;br&gt;See [PSU identifiers](https://docs.yapily.com/knowledge/psu_identifiers/) to see if this header is required.</param>
        /// <returns>ApiResponseOfPaymentAuthorisationRequestResponse</returns>
        public ApiResponseOfPaymentAuthorisationRequestResponse CreatePaymentAuthorisationUsingPOST (PaymentAuthorisationRequest body, string xYapilyApiVersion, string psuId, string psuCorporateId, string psuIpAddress)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling CreatePaymentAuthorisationUsingPOST");
    
            var path = "/payment-auth-requests";
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
                throw new ApiException ((int)response.StatusCode, "Error calling CreatePaymentAuthorisationUsingPOST: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CreatePaymentAuthorisationUsingPOST: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ApiResponseOfPaymentAuthorisationRequestResponse) ApiClient.Deserialize(response.Content, typeof(ApiResponseOfPaymentAuthorisationRequestResponse), response.Headers);
        }
    
        /// <summary>
        /// Initiate a new single payment for user to authorise 
        /// </summary>
        /// <param name="body">paymentAuthRequest</param>
        /// <param name="xYapilyApiVersion">__Optional__. Determines the API version to use. Valid values are &#x60;1.0&#x60; or &#x60;2.0-ALPHA&#x60;. Defaults to &#x60;1.0&#x60;</param>
        /// <param name="psuId">__Conditional__. Represents the user&#x27;s login ID for the &#x60;Institution&#x60; to a personal account. &lt;br&gt;&lt;br&gt;See [PSU identifiers](https://docs.yapily.com/knowledge/psu_identifiers/) to see if this header is required.</param>
        /// <param name="psuCorporateId">__Conditional__. Represents the user&#x27;s login ID for the &#x60;Institution&#x60; to a business account. &lt;br&gt;&lt;br&gt;See [PSU identifiers](https://docs.yapily.com/knowledge/psu_identifiers/) to see if this header is required.</param>
        /// <param name="psuIpAddress">__Conditional__. The IP address of the PSU. &lt;br&gt;&lt;br&gt;See [PSU identifiers](https://docs.yapily.com/knowledge/psu_identifiers/) to see if this header is required.</param>
        /// <returns>ApiResponseOfAuthorisationRequestResponse</returns>
        public ApiResponseOfAuthorisationRequestResponse CreatePaymentAuthorisationWithSortCodeUsingPOST (SortCodePaymentAuthRequest body, string xYapilyApiVersion, string psuId, string psuCorporateId, string psuIpAddress)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling CreatePaymentAuthorisationWithSortCodeUsingPOST");
    
            var path = "/payment-sortcode-auth-requests";
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
                throw new ApiException ((int)response.StatusCode, "Error calling CreatePaymentAuthorisationWithSortCodeUsingPOST: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CreatePaymentAuthorisationWithSortCodeUsingPOST: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ApiResponseOfAuthorisationRequestResponse) ApiClient.Deserialize(response.Content, typeof(ApiResponseOfAuthorisationRequestResponse), response.Headers);
        }
    
        /// <summary>
        /// Create a payment 
        /// </summary>
        /// <param name="body">paymentRequest</param>
        /// <param name="consent">__Mandatory__. The &#x60;consent-token&#x60; containing the user&#x27;s authorisation to make the request.</param>
        /// <param name="xYapilyApiVersion">__Optional__. Determines the API version to use. Valid values are &#x60;1.0&#x60; or &#x60;2.0-ALPHA&#x60;. Defaults to &#x60;1.0&#x60;</param>
        /// <param name="psuId">__Conditional__. Represents the user&#x27;s login ID for the &#x60;Institution&#x60; to a personal account. &lt;br&gt;&lt;br&gt;See [PSU identifiers](https://docs.yapily.com/knowledge/psu_identifiers/) to see if this header is required.</param>
        /// <param name="psuCorporateId">__Conditional__. Represents the user&#x27;s login ID for the &#x60;Institution&#x60; to a business account. &lt;br&gt;&lt;br&gt;See [PSU identifiers](https://docs.yapily.com/knowledge/psu_identifiers/) to see if this header is required.</param>
        /// <param name="psuIpAddress">__Conditional__. The IP address of the PSU. &lt;br&gt;&lt;br&gt;See [PSU identifiers](https://docs.yapily.com/knowledge/psu_identifiers/) to see if this header is required.</param>
        /// <returns>ApiResponseOfPaymentResponse</returns>
        public ApiResponseOfPaymentResponse CreatePaymentUsingPOST (PaymentRequest body, string consent, string xYapilyApiVersion, string psuId, string psuCorporateId, string psuIpAddress)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling CreatePaymentUsingPOST");
            // verify the required parameter 'consent' is set
            if (consent == null) throw new ApiException(400, "Missing required parameter 'consent' when calling CreatePaymentUsingPOST");
    
            var path = "/payments";
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
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling CreatePaymentUsingPOST: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CreatePaymentUsingPOST: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ApiResponseOfPaymentResponse) ApiClient.Deserialize(response.Content, typeof(ApiResponseOfPaymentResponse), response.Headers);
        }
    
        /// <summary>
        /// Create a new single payment 
        /// </summary>
        /// <param name="body">paymentRequest</param>
        /// <param name="consent">__Mandatory__. The &#x60;consent-token&#x60; containing the user&#x27;s authorisation to make the request.</param>
        /// <param name="xYapilyApiVersion">__Optional__. Determines the API version to use. Valid values are &#x60;1.0&#x60; or &#x60;2.0-ALPHA&#x60;. Defaults to &#x60;1.0&#x60;</param>
        /// <param name="psuId">__Conditional__. Represents the user&#x27;s login ID for the &#x60;Institution&#x60; to a personal account. &lt;br&gt;&lt;br&gt;See [PSU identifiers](https://docs.yapily.com/knowledge/psu_identifiers/) to see if this header is required.</param>
        /// <param name="psuCorporateId">__Conditional__. Represents the user&#x27;s login ID for the &#x60;Institution&#x60; to a business account. &lt;br&gt;&lt;br&gt;See [PSU identifiers](https://docs.yapily.com/knowledge/psu_identifiers/) to see if this header is required.</param>
        /// <param name="psuIpAddress">__Conditional__. The IP address of the PSU. &lt;br&gt;&lt;br&gt;See [PSU identifiers](https://docs.yapily.com/knowledge/psu_identifiers/) to see if this header is required.</param>
        /// <returns>ApiResponseOfPaymentResponse</returns>
        public ApiResponseOfPaymentResponse CreatePaymentWithSortCodeUsingPOST (SortCodePaymentRequest body, string consent, string xYapilyApiVersion, string psuId, string psuCorporateId, string psuIpAddress)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling CreatePaymentWithSortCodeUsingPOST");
            // verify the required parameter 'consent' is set
            if (consent == null) throw new ApiException(400, "Missing required parameter 'consent' when calling CreatePaymentWithSortCodeUsingPOST");
    
            var path = "/payment-sortcode";
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
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling CreatePaymentWithSortCodeUsingPOST: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CreatePaymentWithSortCodeUsingPOST: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ApiResponseOfPaymentResponse) ApiClient.Deserialize(response.Content, typeof(ApiResponseOfPaymentResponse), response.Headers);
        }
    
        /// <summary>
        /// Get status of a payment 
        /// </summary>
        /// <param name="paymentId">__Mandatory__. The payment Id of the payment.</param>
        /// <param name="consent">__Mandatory__. The &#x60;consent-token&#x60; containing the user&#x27;s authorisation to make the request.</param>
        /// <param name="xYapilyApiVersion">__Optional__. Determines the API version to use. Valid values are &#x60;1.0&#x60; or &#x60;2.0-ALPHA&#x60;. Defaults to &#x60;1.0&#x60;</param>
        /// <param name="psuId">__Conditional__. Represents the user&#x27;s login ID for the &#x60;Institution&#x60; to a personal account. &lt;br&gt;&lt;br&gt;See [PSU identifiers](https://docs.yapily.com/knowledge/psu_identifiers/) to see if this header is required.</param>
        /// <param name="psuCorporateId">__Conditional__. Represents the user&#x27;s login ID for the &#x60;Institution&#x60; to a business account. &lt;br&gt;&lt;br&gt;See [PSU identifiers](https://docs.yapily.com/knowledge/psu_identifiers/) to see if this header is required.</param>
        /// <param name="psuIpAddress">__Conditional__. The IP address of the PSU. &lt;br&gt;&lt;br&gt;See [PSU identifiers](https://docs.yapily.com/knowledge/psu_identifiers/) to see if this header is required.</param>
        /// <returns>ApiResponseOfPaymentResponse</returns>
        public ApiResponseOfPaymentResponse GetPaymentStatusUsingGET (string paymentId, string consent, string xYapilyApiVersion, string psuId, string psuCorporateId, string psuIpAddress)
        {
            // verify the required parameter 'paymentId' is set
            if (paymentId == null) throw new ApiException(400, "Missing required parameter 'paymentId' when calling GetPaymentStatusUsingGET");
            // verify the required parameter 'consent' is set
            if (consent == null) throw new ApiException(400, "Missing required parameter 'consent' when calling GetPaymentStatusUsingGET");
    
            var path = "/payments/{paymentId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "paymentId" + "}", ApiClient.ParameterToString(paymentId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetPaymentStatusUsingGET: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetPaymentStatusUsingGET: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ApiResponseOfPaymentResponse) ApiClient.Deserialize(response.Content, typeof(ApiResponseOfPaymentResponse), response.Headers);
        }
    
        /// <summary>
        /// Get payments details 
        /// </summary>
        /// <param name="paymentId">__Mandatory__. The payment Id of the payment.</param>
        /// <param name="consent">__Mandatory__. The &#x60;consent-token&#x60; containing the user&#x27;s authorisation to make the request.</param>
        /// <param name="xYapilyApiVersion">__Optional__. Determines the API version to use. Valid values are &#x60;1.0&#x60; or &#x60;2.0-ALPHA&#x60;. Defaults to &#x60;1.0&#x60;</param>
        /// <param name="psuId">__Conditional__. Represents the user&#x27;s login ID for the &#x60;Institution&#x60; to a personal account. &lt;br&gt;&lt;br&gt;See [PSU identifiers](https://docs.yapily.com/knowledge/psu_identifiers/) to see if this header is required.</param>
        /// <param name="psuCorporateId">__Conditional__. Represents the user&#x27;s login ID for the &#x60;Institution&#x60; to a business account. &lt;br&gt;&lt;br&gt;See [PSU identifiers](https://docs.yapily.com/knowledge/psu_identifiers/) to see if this header is required.</param>
        /// <param name="psuIpAddress">__Conditional__. The IP address of the PSU. &lt;br&gt;&lt;br&gt;See [PSU identifiers](https://docs.yapily.com/knowledge/psu_identifiers/) to see if this header is required.</param>
        /// <returns>ApiResponseOfPaymentResponses</returns>
        public ApiResponseOfPaymentResponses GetPaymentsUsingGET (string paymentId, string consent, string xYapilyApiVersion, string psuId, string psuCorporateId, string psuIpAddress)
        {
            // verify the required parameter 'paymentId' is set
            if (paymentId == null) throw new ApiException(400, "Missing required parameter 'paymentId' when calling GetPaymentsUsingGET");
            // verify the required parameter 'consent' is set
            if (consent == null) throw new ApiException(400, "Missing required parameter 'consent' when calling GetPaymentsUsingGET");
    
            var path = "/payments/{paymentId}/details";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "paymentId" + "}", ApiClient.ParameterToString(paymentId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetPaymentsUsingGET: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetPaymentsUsingGET: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ApiResponseOfPaymentResponses) ApiClient.Deserialize(response.Content, typeof(ApiResponseOfPaymentResponses), response.Headers);
        }
    
        /// <summary>
        /// Update pre authorize consent for user to authorise payment 
        /// </summary>
        /// <param name="body">paymentAuthRequest</param>
        /// <param name="consent">__Mandatory__. The &#x60;consent-token&#x60; containing the user&#x27;s authorisation to make the request.</param>
        /// <param name="xYapilyApiVersion">__Optional__. Determines the API version to use. Valid values are &#x60;1.0&#x60; or &#x60;2.0-ALPHA&#x60;. Defaults to &#x60;1.0&#x60;</param>
        /// <param name="psuId">__Conditional__. Represents the user&#x27;s login ID for the &#x60;Institution&#x60; to a personal account. &lt;br&gt;&lt;br&gt;See [PSU identifiers](https://docs.yapily.com/knowledge/psu_identifiers/) to see if this header is required.</param>
        /// <param name="psuCorporateId">__Conditional__. Represents the user&#x27;s login ID for the &#x60;Institution&#x60; to a business account. &lt;br&gt;&lt;br&gt;See [PSU identifiers](https://docs.yapily.com/knowledge/psu_identifiers/) to see if this header is required.</param>
        /// <param name="psuIpAddress">__Conditional__. The IP address of the PSU. &lt;br&gt;&lt;br&gt;See [PSU identifiers](https://docs.yapily.com/knowledge/psu_identifiers/) to see if this header is required.</param>
        /// <returns>ApiResponseOfPaymentAuthorisationRequestResponse</returns>
        public ApiResponseOfPaymentAuthorisationRequestResponse UpdatePaymentAuthorisationUsingPUT (PaymentAuthorisationRequest body, string consent, string xYapilyApiVersion, string psuId, string psuCorporateId, string psuIpAddress)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UpdatePaymentAuthorisationUsingPUT");
            // verify the required parameter 'consent' is set
            if (consent == null) throw new ApiException(400, "Missing required parameter 'consent' when calling UpdatePaymentAuthorisationUsingPUT");
    
            var path = "/payment-auth-requests";
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
 if (consent != null) headerParams.Add("consent", ApiClient.ParameterToString(consent)); // header parameter
            postBody = ApiClient.Serialize(body); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] { "basicAuth", "tokenAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdatePaymentAuthorisationUsingPUT: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdatePaymentAuthorisationUsingPUT: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ApiResponseOfPaymentAuthorisationRequestResponse) ApiClient.Deserialize(response.Content, typeof(ApiResponseOfPaymentAuthorisationRequestResponse), response.Headers);
        }
    
    }
}
