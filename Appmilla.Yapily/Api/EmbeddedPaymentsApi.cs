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
    public interface IEmbeddedPaymentsApi
    {
        /// <summary>
        /// Initiate an embedded bulk payment for user to authorise 
        /// </summary>
        /// <param name="body">bulkPaymentEmbeddedAuthorisationRequest</param>
        /// <param name="xYapilyApiVersion">__Optional__. Determines the API version to use. Valid values are &#x60;1.0&#x60; or &#x60;2.0-ALPHA&#x60;. Defaults to &#x60;1.0&#x60;</param>
        /// <param name="psuId">__Conditional__. Represents the user&#x27;s login ID for the &#x60;Institution&#x60; to a personal account. &lt;br&gt;&lt;br&gt;See [PSU identifiers](https://docs.yapily.com/knowledge/psu_identifiers/) to see if this header is required.</param>
        /// <param name="psuCorporateId">__Conditional__. Represents the user&#x27;s login ID for the &#x60;Institution&#x60; to a business account. &lt;br&gt;&lt;br&gt;See [PSU identifiers](https://docs.yapily.com/knowledge/psu_identifiers/) to see if this header is required.</param>
        /// <param name="psuIpAddress">__Conditional__. The IP address of the PSU. &lt;br&gt;&lt;br&gt;See [PSU identifiers](https://docs.yapily.com/knowledge/psu_identifiers/) to see if this header is required.</param>
        /// <returns>ApiResponseOfPaymentEmbeddedAuthorisationRequestResponse</returns>
        ApiResponseOfPaymentEmbeddedAuthorisationRequestResponse CreateEmbeddedBulkPaymentAuthorisationUsingPOST (BulkPaymentEmbeddedAuthorisationRequest body, string xYapilyApiVersion, string psuId, string psuCorporateId, string psuIpAddress);
        /// <summary>
        /// Initiate an embedded payment for user to authorise 
        /// </summary>
        /// <param name="body">paymentAuthRequest</param>
        /// <param name="xYapilyApiVersion">__Optional__. Determines the API version to use. Valid values are &#x60;1.0&#x60; or &#x60;2.0-ALPHA&#x60;. Defaults to &#x60;1.0&#x60;</param>
        /// <param name="psuId">__Conditional__. Represents the user&#x27;s login ID for the &#x60;Institution&#x60; to a personal account. &lt;br&gt;&lt;br&gt;See [PSU identifiers](https://docs.yapily.com/knowledge/psu_identifiers/) to see if this header is required.</param>
        /// <param name="psuCorporateId">__Conditional__. Represents the user&#x27;s login ID for the &#x60;Institution&#x60; to a business account. &lt;br&gt;&lt;br&gt;See [PSU identifiers](https://docs.yapily.com/knowledge/psu_identifiers/) to see if this header is required.</param>
        /// <param name="psuIpAddress">__Conditional__. The IP address of the PSU. &lt;br&gt;&lt;br&gt;See [PSU identifiers](https://docs.yapily.com/knowledge/psu_identifiers/) to see if this header is required.</param>
        /// <returns>ApiResponseOfPaymentEmbeddedAuthorisationRequestResponse</returns>
        ApiResponseOfPaymentEmbeddedAuthorisationRequestResponse CreateEmbeddedPaymentAuthorisationUsingPOST (PaymentEmbeddedAuthorisationRequest body, string xYapilyApiVersion, string psuId, string psuCorporateId, string psuIpAddress);
        /// <summary>
        /// Update an embedded bulk payment initiation with SCA info 
        /// </summary>
        /// <param name="body">bulkPaymentEmbeddedAuthorisationRequest</param>
        /// <param name="consentId">__Mandatory__. The consent Id of the &#x60;Consent&#x60; to update.</param>
        /// <param name="xYapilyApiVersion">__Optional__. Determines the API version to use. Valid values are &#x60;1.0&#x60; or &#x60;2.0-ALPHA&#x60;. Defaults to &#x60;1.0&#x60;</param>
        /// <param name="psuId">__Conditional__. Represents the user&#x27;s login ID for the &#x60;Institution&#x60; to a personal account. &lt;br&gt;&lt;br&gt;See [PSU identifiers](https://docs.yapily.com/knowledge/psu_identifiers/) to see if this header is required.</param>
        /// <param name="psuCorporateId">__Conditional__. Represents the user&#x27;s login ID for the &#x60;Institution&#x60; to a business account. &lt;br&gt;&lt;br&gt;See [PSU identifiers](https://docs.yapily.com/knowledge/psu_identifiers/) to see if this header is required.</param>
        /// <param name="psuIpAddress">__Conditional__. The IP address of the PSU. &lt;br&gt;&lt;br&gt;See [PSU identifiers](https://docs.yapily.com/knowledge/psu_identifiers/) to see if this header is required.</param>
        /// <returns>ApiResponseOfPaymentEmbeddedAuthorisationRequestResponse</returns>
        ApiResponseOfPaymentEmbeddedAuthorisationRequestResponse UpdateEmbeddedBulkPaymentAuthorisationUsingPUT (BulkPaymentEmbeddedAuthorisationRequest body, string consentId, string xYapilyApiVersion, string psuId, string psuCorporateId, string psuIpAddress);
        /// <summary>
        /// Update an embedded payment initiation with SCA info 
        /// </summary>
        /// <param name="body">paymentAuthRequest</param>
        /// <param name="consentId">__Mandatory__. The consent Id of the &#x60;Consent&#x60; to update.</param>
        /// <param name="xYapilyApiVersion">__Optional__. Determines the API version to use. Valid values are &#x60;1.0&#x60; or &#x60;2.0-ALPHA&#x60;. Defaults to &#x60;1.0&#x60;</param>
        /// <param name="psuId">__Conditional__. Represents the user&#x27;s login ID for the &#x60;Institution&#x60; to a personal account. &lt;br&gt;&lt;br&gt;See [PSU identifiers](https://docs.yapily.com/knowledge/psu_identifiers/) to see if this header is required.</param>
        /// <param name="psuCorporateId">__Conditional__. Represents the user&#x27;s login ID for the &#x60;Institution&#x60; to a business account. &lt;br&gt;&lt;br&gt;See [PSU identifiers](https://docs.yapily.com/knowledge/psu_identifiers/) to see if this header is required.</param>
        /// <param name="psuIpAddress">__Conditional__. The IP address of the PSU. &lt;br&gt;&lt;br&gt;See [PSU identifiers](https://docs.yapily.com/knowledge/psu_identifiers/) to see if this header is required.</param>
        /// <returns>ApiResponseOfPaymentEmbeddedAuthorisationRequestResponse</returns>
        ApiResponseOfPaymentEmbeddedAuthorisationRequestResponse UpdateEmbeddedPaymentAuthorisationUsingPUT (PaymentEmbeddedAuthorisationRequest body, string consentId, string xYapilyApiVersion, string psuId, string psuCorporateId, string psuIpAddress);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class EmbeddedPaymentsApi : IEmbeddedPaymentsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmbeddedPaymentsApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public EmbeddedPaymentsApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="EmbeddedPaymentsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public EmbeddedPaymentsApi(String basePath)
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
        /// Initiate an embedded bulk payment for user to authorise 
        /// </summary>
        /// <param name="body">bulkPaymentEmbeddedAuthorisationRequest</param>
        /// <param name="xYapilyApiVersion">__Optional__. Determines the API version to use. Valid values are &#x60;1.0&#x60; or &#x60;2.0-ALPHA&#x60;. Defaults to &#x60;1.0&#x60;</param>
        /// <param name="psuId">__Conditional__. Represents the user&#x27;s login ID for the &#x60;Institution&#x60; to a personal account. &lt;br&gt;&lt;br&gt;See [PSU identifiers](https://docs.yapily.com/knowledge/psu_identifiers/) to see if this header is required.</param>
        /// <param name="psuCorporateId">__Conditional__. Represents the user&#x27;s login ID for the &#x60;Institution&#x60; to a business account. &lt;br&gt;&lt;br&gt;See [PSU identifiers](https://docs.yapily.com/knowledge/psu_identifiers/) to see if this header is required.</param>
        /// <param name="psuIpAddress">__Conditional__. The IP address of the PSU. &lt;br&gt;&lt;br&gt;See [PSU identifiers](https://docs.yapily.com/knowledge/psu_identifiers/) to see if this header is required.</param>
        /// <returns>ApiResponseOfPaymentEmbeddedAuthorisationRequestResponse</returns>
        public ApiResponseOfPaymentEmbeddedAuthorisationRequestResponse CreateEmbeddedBulkPaymentAuthorisationUsingPOST (BulkPaymentEmbeddedAuthorisationRequest body, string xYapilyApiVersion, string psuId, string psuCorporateId, string psuIpAddress)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling CreateEmbeddedBulkPaymentAuthorisationUsingPOST");
    
            var path = "/embedded-bulk-payment-auth-requests";
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
                throw new ApiException ((int)response.StatusCode, "Error calling CreateEmbeddedBulkPaymentAuthorisationUsingPOST: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateEmbeddedBulkPaymentAuthorisationUsingPOST: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ApiResponseOfPaymentEmbeddedAuthorisationRequestResponse) ApiClient.Deserialize(response.Content, typeof(ApiResponseOfPaymentEmbeddedAuthorisationRequestResponse), response.Headers);
        }
    
        /// <summary>
        /// Initiate an embedded payment for user to authorise 
        /// </summary>
        /// <param name="body">paymentAuthRequest</param>
        /// <param name="xYapilyApiVersion">__Optional__. Determines the API version to use. Valid values are &#x60;1.0&#x60; or &#x60;2.0-ALPHA&#x60;. Defaults to &#x60;1.0&#x60;</param>
        /// <param name="psuId">__Conditional__. Represents the user&#x27;s login ID for the &#x60;Institution&#x60; to a personal account. &lt;br&gt;&lt;br&gt;See [PSU identifiers](https://docs.yapily.com/knowledge/psu_identifiers/) to see if this header is required.</param>
        /// <param name="psuCorporateId">__Conditional__. Represents the user&#x27;s login ID for the &#x60;Institution&#x60; to a business account. &lt;br&gt;&lt;br&gt;See [PSU identifiers](https://docs.yapily.com/knowledge/psu_identifiers/) to see if this header is required.</param>
        /// <param name="psuIpAddress">__Conditional__. The IP address of the PSU. &lt;br&gt;&lt;br&gt;See [PSU identifiers](https://docs.yapily.com/knowledge/psu_identifiers/) to see if this header is required.</param>
        /// <returns>ApiResponseOfPaymentEmbeddedAuthorisationRequestResponse</returns>
        public ApiResponseOfPaymentEmbeddedAuthorisationRequestResponse CreateEmbeddedPaymentAuthorisationUsingPOST (PaymentEmbeddedAuthorisationRequest body, string xYapilyApiVersion, string psuId, string psuCorporateId, string psuIpAddress)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling CreateEmbeddedPaymentAuthorisationUsingPOST");
    
            var path = "/embedded-payment-auth-requests";
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
                throw new ApiException ((int)response.StatusCode, "Error calling CreateEmbeddedPaymentAuthorisationUsingPOST: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateEmbeddedPaymentAuthorisationUsingPOST: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ApiResponseOfPaymentEmbeddedAuthorisationRequestResponse) ApiClient.Deserialize(response.Content, typeof(ApiResponseOfPaymentEmbeddedAuthorisationRequestResponse), response.Headers);
        }
    
        /// <summary>
        /// Update an embedded bulk payment initiation with SCA info 
        /// </summary>
        /// <param name="body">bulkPaymentEmbeddedAuthorisationRequest</param>
        /// <param name="consentId">__Mandatory__. The consent Id of the &#x60;Consent&#x60; to update.</param>
        /// <param name="xYapilyApiVersion">__Optional__. Determines the API version to use. Valid values are &#x60;1.0&#x60; or &#x60;2.0-ALPHA&#x60;. Defaults to &#x60;1.0&#x60;</param>
        /// <param name="psuId">__Conditional__. Represents the user&#x27;s login ID for the &#x60;Institution&#x60; to a personal account. &lt;br&gt;&lt;br&gt;See [PSU identifiers](https://docs.yapily.com/knowledge/psu_identifiers/) to see if this header is required.</param>
        /// <param name="psuCorporateId">__Conditional__. Represents the user&#x27;s login ID for the &#x60;Institution&#x60; to a business account. &lt;br&gt;&lt;br&gt;See [PSU identifiers](https://docs.yapily.com/knowledge/psu_identifiers/) to see if this header is required.</param>
        /// <param name="psuIpAddress">__Conditional__. The IP address of the PSU. &lt;br&gt;&lt;br&gt;See [PSU identifiers](https://docs.yapily.com/knowledge/psu_identifiers/) to see if this header is required.</param>
        /// <returns>ApiResponseOfPaymentEmbeddedAuthorisationRequestResponse</returns>
        public ApiResponseOfPaymentEmbeddedAuthorisationRequestResponse UpdateEmbeddedBulkPaymentAuthorisationUsingPUT (BulkPaymentEmbeddedAuthorisationRequest body, string consentId, string xYapilyApiVersion, string psuId, string psuCorporateId, string psuIpAddress)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UpdateEmbeddedBulkPaymentAuthorisationUsingPUT");
            // verify the required parameter 'consentId' is set
            if (consentId == null) throw new ApiException(400, "Missing required parameter 'consentId' when calling UpdateEmbeddedBulkPaymentAuthorisationUsingPUT");
    
            var path = "/embedded-bulk-payment-auth-requests/{consentId}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateEmbeddedBulkPaymentAuthorisationUsingPUT: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateEmbeddedBulkPaymentAuthorisationUsingPUT: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ApiResponseOfPaymentEmbeddedAuthorisationRequestResponse) ApiClient.Deserialize(response.Content, typeof(ApiResponseOfPaymentEmbeddedAuthorisationRequestResponse), response.Headers);
        }
    
        /// <summary>
        /// Update an embedded payment initiation with SCA info 
        /// </summary>
        /// <param name="body">paymentAuthRequest</param>
        /// <param name="consentId">__Mandatory__. The consent Id of the &#x60;Consent&#x60; to update.</param>
        /// <param name="xYapilyApiVersion">__Optional__. Determines the API version to use. Valid values are &#x60;1.0&#x60; or &#x60;2.0-ALPHA&#x60;. Defaults to &#x60;1.0&#x60;</param>
        /// <param name="psuId">__Conditional__. Represents the user&#x27;s login ID for the &#x60;Institution&#x60; to a personal account. &lt;br&gt;&lt;br&gt;See [PSU identifiers](https://docs.yapily.com/knowledge/psu_identifiers/) to see if this header is required.</param>
        /// <param name="psuCorporateId">__Conditional__. Represents the user&#x27;s login ID for the &#x60;Institution&#x60; to a business account. &lt;br&gt;&lt;br&gt;See [PSU identifiers](https://docs.yapily.com/knowledge/psu_identifiers/) to see if this header is required.</param>
        /// <param name="psuIpAddress">__Conditional__. The IP address of the PSU. &lt;br&gt;&lt;br&gt;See [PSU identifiers](https://docs.yapily.com/knowledge/psu_identifiers/) to see if this header is required.</param>
        /// <returns>ApiResponseOfPaymentEmbeddedAuthorisationRequestResponse</returns>
        public ApiResponseOfPaymentEmbeddedAuthorisationRequestResponse UpdateEmbeddedPaymentAuthorisationUsingPUT (PaymentEmbeddedAuthorisationRequest body, string consentId, string xYapilyApiVersion, string psuId, string psuCorporateId, string psuIpAddress)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UpdateEmbeddedPaymentAuthorisationUsingPUT");
            // verify the required parameter 'consentId' is set
            if (consentId == null) throw new ApiException(400, "Missing required parameter 'consentId' when calling UpdateEmbeddedPaymentAuthorisationUsingPUT");
    
            var path = "/embedded-payment-auth-requests/{consentId}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateEmbeddedPaymentAuthorisationUsingPUT: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateEmbeddedPaymentAuthorisationUsingPUT: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ApiResponseOfPaymentEmbeddedAuthorisationRequestResponse) ApiClient.Deserialize(response.Content, typeof(ApiResponseOfPaymentEmbeddedAuthorisationRequestResponse), response.Headers);
        }
    
    }
}
