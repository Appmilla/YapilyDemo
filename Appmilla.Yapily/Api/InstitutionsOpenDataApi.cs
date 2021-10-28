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
    public interface IInstitutionsOpenDataApi
    {
        /// <summary>
        /// Retrieves data about all ATMs of the selected institution 
        /// </summary>
        /// <param name="institutionId">institutionId</param>
        /// <returns>ApiResponseOfListOfATMOpenDataResponse</returns>
        ApiResponseOfListOfATMOpenDataResponse GetATMDataUsingGET (string institutionId);
        /// <summary>
        /// Retrieves details of personal current accounts for an institution 
        /// </summary>
        /// <param name="institutionId">institutionId</param>
        /// <returns>ApiResponseOfListOfPersonalCurrentAccountData</returns>
        ApiResponseOfListOfPersonalCurrentAccountData GetPersonalCurrentAccountsUsingGET (string institutionId);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class InstitutionsOpenDataApi : IInstitutionsOpenDataApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InstitutionsOpenDataApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public InstitutionsOpenDataApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="InstitutionsOpenDataApi"/> class.
        /// </summary>
        /// <returns></returns>
        public InstitutionsOpenDataApi(String basePath)
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
        /// Retrieves data about all ATMs of the selected institution 
        /// </summary>
        /// <param name="institutionId">institutionId</param>
        /// <returns>ApiResponseOfListOfATMOpenDataResponse</returns>
        public ApiResponseOfListOfATMOpenDataResponse GetATMDataUsingGET (string institutionId)
        {
            // verify the required parameter 'institutionId' is set
            if (institutionId == null) throw new ApiException(400, "Missing required parameter 'institutionId' when calling GetATMDataUsingGET");
    
            var path = "/institutions/{institutionId}/atms";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "institutionId" + "}", ApiClient.ParameterToString(institutionId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                    
            // authentication setting, if any
            String[] authSettings = new String[] { "basicAuth", "tokenAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetATMDataUsingGET: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetATMDataUsingGET: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ApiResponseOfListOfATMOpenDataResponse) ApiClient.Deserialize(response.Content, typeof(ApiResponseOfListOfATMOpenDataResponse), response.Headers);
        }
    
        /// <summary>
        /// Retrieves details of personal current accounts for an institution 
        /// </summary>
        /// <param name="institutionId">institutionId</param>
        /// <returns>ApiResponseOfListOfPersonalCurrentAccountData</returns>
        public ApiResponseOfListOfPersonalCurrentAccountData GetPersonalCurrentAccountsUsingGET (string institutionId)
        {
            // verify the required parameter 'institutionId' is set
            if (institutionId == null) throw new ApiException(400, "Missing required parameter 'institutionId' when calling GetPersonalCurrentAccountsUsingGET");
    
            var path = "/institutions/{institutionId}/personal-current-accounts";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "institutionId" + "}", ApiClient.ParameterToString(institutionId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                    
            // authentication setting, if any
            String[] authSettings = new String[] { "basicAuth", "tokenAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetPersonalCurrentAccountsUsingGET: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetPersonalCurrentAccountsUsingGET: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ApiResponseOfListOfPersonalCurrentAccountData) ApiClient.Deserialize(response.Content, typeof(ApiResponseOfListOfPersonalCurrentAccountData), response.Headers);
        }
    
    }
}
