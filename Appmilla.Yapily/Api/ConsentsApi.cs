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
    public interface IConsentsApi
    {
        /// <summary>
        /// Post consent 
        /// </summary>
        /// <param name="body">createConsentAccessToken</param>
        /// <param name="userUuid">__Mandatory__. The Yapily generated UUID for the user.</param>
        /// <param name="xYapilyApiVersion">__Optional__. Determines the API version to use. Valid values are &#x60;1.0&#x60; or &#x60;2.0-ALPHA&#x60;. Defaults to &#x60;1.0&#x60;</param>
        /// <returns>Consent</returns>
        Consent AddConsentUsingPOST (CreateConsentAccessToken body, string userUuid, string xYapilyApiVersion);
        /// <summary>
        /// Post auth-code and auth-state 
        /// </summary>
        /// <param name="body">consentByAuthCode</param>
        /// <param name="xYapilyApiVersion">__Optional__. Determines the API version to use. Valid values are &#x60;1.0&#x60; or &#x60;2.0-ALPHA&#x60;. Defaults to &#x60;1.0&#x60;</param>
        /// <returns>Consent</returns>
        Consent CreateConsentWithCodeUsingPOST (ConsentAuthCodeRequest body, string xYapilyApiVersion);
        /// <summary>
        /// Initiate request for user to pre authorise 
        /// </summary>
        /// <param name="body">preAuthorisationRequest</param>
        /// <param name="xYapilyApiVersion">__Optional__. Determines the API version to use. Valid values are &#x60;1.0&#x60; or &#x60;2.0-ALPHA&#x60;. Defaults to &#x60;1.0&#x60;</param>
        /// <returns>ApiResponseOfAuthorisationRequestResponse</returns>
        ApiResponseOfAuthorisationRequestResponse CreatePreAuthorisationRequestUsingPOST (PreAuthorisationRequest body, string xYapilyApiVersion);
        /// <summary>
        /// Delete consent 
        /// </summary>
        /// <param name="consentId">__Mandatory__. The consent Id of the &#x60;Consent&#x60; to update.</param>
        /// <param name="xYapilyApiVersion">__Optional__. Determines the API version to use. Valid values are &#x60;1.0&#x60; or &#x60;2.0-ALPHA&#x60;. Defaults to &#x60;1.0&#x60;</param>
        /// <param name="forceDelete">__Optional__. Whether to force the deletion.</param>
        /// <returns>ApiResponseOfConsentDeleteResponse</returns>
        ApiResponseOfConsentDeleteResponse DeleteUsingDELETE (string consentId, string xYapilyApiVersion, bool? forceDelete);
        /// <summary>
        /// Get consent 
        /// </summary>
        /// <param name="consentId">__Mandatory__. The consent Id of the &#x60;Consent&#x60; to update.</param>
        /// <param name="xYapilyApiVersion">__Optional__. Determines the API version to use. Valid values are &#x60;1.0&#x60; or &#x60;2.0-ALPHA&#x60;. Defaults to &#x60;1.0&#x60;</param>
        /// <returns>ApiResponseOfConsent</returns>
        ApiResponseOfConsent GetConsentByIdUsingGET (string consentId, string xYapilyApiVersion);
        /// <summary>
        /// Post one time token 
        /// </summary>
        /// <param name="body">oneTimeToken</param>
        /// <param name="xYapilyApiVersion">__Optional__. Determines the API version to use. Valid values are &#x60;1.0&#x60; or &#x60;2.0-ALPHA&#x60;. Defaults to &#x60;1.0&#x60;</param>
        /// <returns>Consent</returns>
        Consent GetConsentBySingleAccessConsentUsingPOST (OneTimeTokenRequest body, string xYapilyApiVersion);
        /// <summary>
        /// Get consents sorted by creation date 
        /// </summary>
        /// <param name="xYapilyApiVersion">__Optional__. Determines the API version to use. Valid values are &#x60;1.0&#x60; or &#x60;2.0-ALPHA&#x60;. Defaults to &#x60;1.0&#x60;</param>
        /// <param name="filterApplicationUserId">__Optional__. Filter records based on the list of &#x60;applicationUserId&#x60; users provided.</param>
        /// <param name="filterUserUuid">__Optional__. Filter records based on the list of &#x60;userUuid&#x60; users provided.</param>
        /// <param name="filterInstitution">__Optional__. Filter records based on the list of &#x60;Institution&#x60; provided.</param>
        /// <param name="filterStatus">__Optional__. Filter records based on the list of &#x60;Consent&#x60; [statuses](https://docs.yapily.com/api/#tocS_AuthorisationStatus).</param>
        /// <param name="from">__Optional__. Returned transactions will be on or after this date (yyyy-MM-dd&#x27;T&#x27;HH:mm:ss.SSSZ). </param>
        /// <param name="before">__Optional__. Returned transactions will be on or before this date (yyyy-MM-dd&#x27;T&#x27;HH:mm:ss.SSSZ).</param>
        /// <param name="limit">Use this parameter to limit consent results, max limit is 20</param>
        /// <param name="offset">__Optional__. The number of transaction records to be skipped. Used primarily with paginated results.</param>
        /// <returns>ApiListResponseOfConsent</returns>
        ApiListResponseOfConsent GetConsentsUsingGET (string xYapilyApiVersion, List<string> filterApplicationUserId, List<string> filterUserUuid, List<string> filterInstitution, List<string> filterStatus, string from, string before, int? limit, int? offset);
        /// <summary>
        /// Get latest user consents 
        /// </summary>
        /// <param name="userUuid">__Mandatory__. The Yapily generated UUID for the user.</param>
        /// <param name="xYapilyApiVersion">__Optional__. Determines the API version to use. Valid values are &#x60;1.0&#x60; or &#x60;2.0-ALPHA&#x60;. Defaults to &#x60;1.0&#x60;</param>
        /// <param name="institutionId">Use this parameter to filter consent by institution, using the Yapily institution Id. This replaces the deprecated &#x60;institutionId&#x60; query param.</param>
        /// <param name="limit">Use this parameter to limit consent results, max limit is 20</param>
        /// <returns>List&lt;Consent&gt;</returns>
        List<Consent> GetUserConsentsUsingGET (string userUuid, string xYapilyApiVersion, string institutionId, int? limit);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ConsentsApi : IConsentsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConsentsApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public ConsentsApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ConsentsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ConsentsApi(String basePath)
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
        /// Post consent 
        /// </summary>
        /// <param name="body">createConsentAccessToken</param>
        /// <param name="userUuid">__Mandatory__. The Yapily generated UUID for the user.</param>
        /// <param name="xYapilyApiVersion">__Optional__. Determines the API version to use. Valid values are &#x60;1.0&#x60; or &#x60;2.0-ALPHA&#x60;. Defaults to &#x60;1.0&#x60;</param>
        /// <returns>Consent</returns>
        public Consent AddConsentUsingPOST (CreateConsentAccessToken body, string userUuid, string xYapilyApiVersion)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling AddConsentUsingPOST");
            // verify the required parameter 'userUuid' is set
            if (userUuid == null) throw new ApiException(400, "Missing required parameter 'userUuid' when calling AddConsentUsingPOST");
    
            var path = "/users/{userUuid}/consents";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "userUuid" + "}", ApiClient.ParameterToString(userUuid));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                         if (xYapilyApiVersion != null) headerParams.Add("x-yapily-api-version", ApiClient.ParameterToString(xYapilyApiVersion)); // header parameter
            postBody = ApiClient.Serialize(body); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] { "basicAuth", "tokenAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling AddConsentUsingPOST: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AddConsentUsingPOST: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Consent) ApiClient.Deserialize(response.Content, typeof(Consent), response.Headers);
        }
    
        /// <summary>
        /// Post auth-code and auth-state 
        /// </summary>
        /// <param name="body">consentByAuthCode</param>
        /// <param name="xYapilyApiVersion">__Optional__. Determines the API version to use. Valid values are &#x60;1.0&#x60; or &#x60;2.0-ALPHA&#x60;. Defaults to &#x60;1.0&#x60;</param>
        /// <returns>Consent</returns>
        public Consent CreateConsentWithCodeUsingPOST (ConsentAuthCodeRequest body, string xYapilyApiVersion)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling CreateConsentWithCodeUsingPOST");
    
            var path = "/consent-auth-code";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                         if (xYapilyApiVersion != null) headerParams.Add("x-yapily-api-version", ApiClient.ParameterToString(xYapilyApiVersion)); // header parameter
            postBody = ApiClient.Serialize(body); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] { "basicAuth", "tokenAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateConsentWithCodeUsingPOST: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateConsentWithCodeUsingPOST: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Consent) ApiClient.Deserialize(response.Content, typeof(Consent), response.Headers);
        }
    
        /// <summary>
        /// Initiate request for user to pre authorise 
        /// </summary>
        /// <param name="body">preAuthorisationRequest</param>
        /// <param name="xYapilyApiVersion">__Optional__. Determines the API version to use. Valid values are &#x60;1.0&#x60; or &#x60;2.0-ALPHA&#x60;. Defaults to &#x60;1.0&#x60;</param>
        /// <returns>ApiResponseOfAuthorisationRequestResponse</returns>
        public ApiResponseOfAuthorisationRequestResponse CreatePreAuthorisationRequestUsingPOST (PreAuthorisationRequest body, string xYapilyApiVersion)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling CreatePreAuthorisationRequestUsingPOST");
    
            var path = "/pre-auth-requests";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                         if (xYapilyApiVersion != null) headerParams.Add("x-yapily-api-version", ApiClient.ParameterToString(xYapilyApiVersion)); // header parameter
            postBody = ApiClient.Serialize(body); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] { "basicAuth", "tokenAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling CreatePreAuthorisationRequestUsingPOST: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CreatePreAuthorisationRequestUsingPOST: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ApiResponseOfAuthorisationRequestResponse) ApiClient.Deserialize(response.Content, typeof(ApiResponseOfAuthorisationRequestResponse), response.Headers);
        }
    
        /// <summary>
        /// Delete consent 
        /// </summary>
        /// <param name="consentId">__Mandatory__. The consent Id of the &#x60;Consent&#x60; to update.</param>
        /// <param name="xYapilyApiVersion">__Optional__. Determines the API version to use. Valid values are &#x60;1.0&#x60; or &#x60;2.0-ALPHA&#x60;. Defaults to &#x60;1.0&#x60;</param>
        /// <param name="forceDelete">__Optional__. Whether to force the deletion.</param>
        /// <returns>ApiResponseOfConsentDeleteResponse</returns>
        public ApiResponseOfConsentDeleteResponse DeleteUsingDELETE (string consentId, string xYapilyApiVersion, bool? forceDelete)
        {
            // verify the required parameter 'consentId' is set
            if (consentId == null) throw new ApiException(400, "Missing required parameter 'consentId' when calling DeleteUsingDELETE");
    
            var path = "/consents/{consentId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "consentId" + "}", ApiClient.ParameterToString(consentId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (forceDelete != null) queryParams.Add("forceDelete", ApiClient.ParameterToString(forceDelete)); // query parameter
             if (xYapilyApiVersion != null) headerParams.Add("x-yapily-api-version", ApiClient.ParameterToString(xYapilyApiVersion)); // header parameter
            
            // authentication setting, if any
            String[] authSettings = new String[] { "basicAuth", "tokenAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteUsingDELETE: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteUsingDELETE: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ApiResponseOfConsentDeleteResponse) ApiClient.Deserialize(response.Content, typeof(ApiResponseOfConsentDeleteResponse), response.Headers);
        }
    
        /// <summary>
        /// Get consent 
        /// </summary>
        /// <param name="consentId">__Mandatory__. The consent Id of the &#x60;Consent&#x60; to update.</param>
        /// <param name="xYapilyApiVersion">__Optional__. Determines the API version to use. Valid values are &#x60;1.0&#x60; or &#x60;2.0-ALPHA&#x60;. Defaults to &#x60;1.0&#x60;</param>
        /// <returns>ApiResponseOfConsent</returns>
        public ApiResponseOfConsent GetConsentByIdUsingGET (string consentId, string xYapilyApiVersion)
        {
            // verify the required parameter 'consentId' is set
            if (consentId == null) throw new ApiException(400, "Missing required parameter 'consentId' when calling GetConsentByIdUsingGET");
    
            var path = "/consents/{consentId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "consentId" + "}", ApiClient.ParameterToString(consentId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                         if (xYapilyApiVersion != null) headerParams.Add("x-yapily-api-version", ApiClient.ParameterToString(xYapilyApiVersion)); // header parameter
            
            // authentication setting, if any
            String[] authSettings = new String[] { "basicAuth", "tokenAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetConsentByIdUsingGET: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetConsentByIdUsingGET: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ApiResponseOfConsent) ApiClient.Deserialize(response.Content, typeof(ApiResponseOfConsent), response.Headers);
        }
    
        /// <summary>
        /// Post one time token 
        /// </summary>
        /// <param name="body">oneTimeToken</param>
        /// <param name="xYapilyApiVersion">__Optional__. Determines the API version to use. Valid values are &#x60;1.0&#x60; or &#x60;2.0-ALPHA&#x60;. Defaults to &#x60;1.0&#x60;</param>
        /// <returns>Consent</returns>
        public Consent GetConsentBySingleAccessConsentUsingPOST (OneTimeTokenRequest body, string xYapilyApiVersion)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling GetConsentBySingleAccessConsentUsingPOST");
    
            var path = "/consent-one-time-token";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                         if (xYapilyApiVersion != null) headerParams.Add("x-yapily-api-version", ApiClient.ParameterToString(xYapilyApiVersion)); // header parameter
            postBody = ApiClient.Serialize(body); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] { "basicAuth", "tokenAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetConsentBySingleAccessConsentUsingPOST: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetConsentBySingleAccessConsentUsingPOST: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Consent) ApiClient.Deserialize(response.Content, typeof(Consent), response.Headers);
        }
    
        /// <summary>
        /// Get consents sorted by creation date 
        /// </summary>
        /// <param name="xYapilyApiVersion">__Optional__. Determines the API version to use. Valid values are &#x60;1.0&#x60; or &#x60;2.0-ALPHA&#x60;. Defaults to &#x60;1.0&#x60;</param>
        /// <param name="filterApplicationUserId">__Optional__. Filter records based on the list of &#x60;applicationUserId&#x60; users provided.</param>
        /// <param name="filterUserUuid">__Optional__. Filter records based on the list of &#x60;userUuid&#x60; users provided.</param>
        /// <param name="filterInstitution">__Optional__. Filter records based on the list of &#x60;Institution&#x60; provided.</param>
        /// <param name="filterStatus">__Optional__. Filter records based on the list of &#x60;Consent&#x60; [statuses](https://docs.yapily.com/api/#tocS_AuthorisationStatus).</param>
        /// <param name="from">__Optional__. Returned transactions will be on or after this date (yyyy-MM-dd&#x27;T&#x27;HH:mm:ss.SSSZ). </param>
        /// <param name="before">__Optional__. Returned transactions will be on or before this date (yyyy-MM-dd&#x27;T&#x27;HH:mm:ss.SSSZ).</param>
        /// <param name="limit">Use this parameter to limit consent results, max limit is 20</param>
        /// <param name="offset">__Optional__. The number of transaction records to be skipped. Used primarily with paginated results.</param>
        /// <returns>ApiListResponseOfConsent</returns>
        public ApiListResponseOfConsent GetConsentsUsingGET (string xYapilyApiVersion, List<string> filterApplicationUserId, List<string> filterUserUuid, List<string> filterInstitution, List<string> filterStatus, string from, string before, int? limit, int? offset)
        {
    
            var path = "/consents";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (filterApplicationUserId != null) queryParams.Add("filter[applicationUserId]", ApiClient.ParameterToString(filterApplicationUserId)); // query parameter
 if (filterUserUuid != null) queryParams.Add("filter[userUuid]", ApiClient.ParameterToString(filterUserUuid)); // query parameter
 if (filterInstitution != null) queryParams.Add("filter[institution]", ApiClient.ParameterToString(filterInstitution)); // query parameter
 if (filterStatus != null) queryParams.Add("filter[status]", ApiClient.ParameterToString(filterStatus)); // query parameter
 if (from != null) queryParams.Add("from", ApiClient.ParameterToString(from)); // query parameter
 if (before != null) queryParams.Add("before", ApiClient.ParameterToString(before)); // query parameter
 if (limit != null) queryParams.Add("limit", ApiClient.ParameterToString(limit)); // query parameter
 if (offset != null) queryParams.Add("offset", ApiClient.ParameterToString(offset)); // query parameter
             if (xYapilyApiVersion != null) headerParams.Add("x-yapily-api-version", ApiClient.ParameterToString(xYapilyApiVersion)); // header parameter
            
            // authentication setting, if any
            String[] authSettings = new String[] { "basicAuth", "tokenAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetConsentsUsingGET: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetConsentsUsingGET: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ApiListResponseOfConsent) ApiClient.Deserialize(response.Content, typeof(ApiListResponseOfConsent), response.Headers);
        }
    
        /// <summary>
        /// Get latest user consents 
        /// </summary>
        /// <param name="userUuid">__Mandatory__. The Yapily generated UUID for the user.</param>
        /// <param name="xYapilyApiVersion">__Optional__. Determines the API version to use. Valid values are &#x60;1.0&#x60; or &#x60;2.0-ALPHA&#x60;. Defaults to &#x60;1.0&#x60;</param>
        /// <param name="institutionId">Use this parameter to filter consent by institution, using the Yapily institution Id. This replaces the deprecated &#x60;institutionId&#x60; query param.</param>
        /// <param name="limit">Use this parameter to limit consent results, max limit is 20</param>
        /// <returns>List&lt;Consent&gt;</returns>
        public List<Consent> GetUserConsentsUsingGET (string userUuid, string xYapilyApiVersion, string institutionId, int? limit)
        {
            // verify the required parameter 'userUuid' is set
            if (userUuid == null) throw new ApiException(400, "Missing required parameter 'userUuid' when calling GetUserConsentsUsingGET");
    
            var path = "/users/{userUuid}/consents";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "userUuid" + "}", ApiClient.ParameterToString(userUuid));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (institutionId != null) queryParams.Add("institutionId", ApiClient.ParameterToString(institutionId)); // query parameter
 if (limit != null) queryParams.Add("limit", ApiClient.ParameterToString(limit)); // query parameter
             if (xYapilyApiVersion != null) headerParams.Add("x-yapily-api-version", ApiClient.ParameterToString(xYapilyApiVersion)); // header parameter
            
            // authentication setting, if any
            String[] authSettings = new String[] { "basicAuth", "tokenAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetUserConsentsUsingGET: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetUserConsentsUsingGET: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<Consent>) ApiClient.Deserialize(response.Content, typeof(List<Consent>), response.Headers);
        }
    
    }
}
