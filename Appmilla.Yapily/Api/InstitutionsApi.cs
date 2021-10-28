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
    public interface IInstitutionsApi
    {
        /// <summary>
        /// Retrieve details for Yapily&#x27;s institution features 
        /// </summary>
        /// <param name="xYapilyApiVersion">__Optional__. Determines the API version to use. Valid values are &#x60;1.0&#x60; or &#x60;2.0-ALPHA&#x60;. Defaults to &#x60;1.0&#x60;</param>
        /// <returns>ApiListResponseOfFeatureDetails</returns>
        ApiListResponseOfFeatureDetails GetFeatureDetailsUsingGET (string xYapilyApiVersion);
        /// <summary>
        /// Retrieves details of a specific institution available in Yapily 
        /// </summary>
        /// <param name="institutionId">__Mandatory__. The Yapily institution Id for the &#x60;Institution&#x60;.</param>
        /// <param name="xYapilyApiVersion">__Optional__. Determines the API version to use. Valid values are &#x60;1.0&#x60; or &#x60;2.0-ALPHA&#x60;. Defaults to &#x60;1.0&#x60;</param>
        /// <returns>Institution</returns>
        Institution GetInstitutionUsingGET (string institutionId, string xYapilyApiVersion);
        /// <summary>
        /// Retrieves the list of institutions available in Yapily 
        /// </summary>
        /// <param name="xYapilyApiVersion">__Optional__. Determines the API version to use. Valid values are &#x60;1.0&#x60; or &#x60;2.0-ALPHA&#x60;. Defaults to &#x60;1.0&#x60;</param>
        /// <returns>ApiListResponseOfInstitution</returns>
        ApiListResponseOfInstitution GetInstitutionsUsingGET (string xYapilyApiVersion);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class InstitutionsApi : IInstitutionsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InstitutionsApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public InstitutionsApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="InstitutionsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public InstitutionsApi(String basePath)
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
        /// Retrieve details for Yapily&#x27;s institution features 
        /// </summary>
        /// <param name="xYapilyApiVersion">__Optional__. Determines the API version to use. Valid values are &#x60;1.0&#x60; or &#x60;2.0-ALPHA&#x60;. Defaults to &#x60;1.0&#x60;</param>
        /// <returns>ApiListResponseOfFeatureDetails</returns>
        public ApiListResponseOfFeatureDetails GetFeatureDetailsUsingGET (string xYapilyApiVersion)
        {
    
            var path = "/features";
            path = path.Replace("{format}", "json");
                
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetFeatureDetailsUsingGET: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetFeatureDetailsUsingGET: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ApiListResponseOfFeatureDetails) ApiClient.Deserialize(response.Content, typeof(ApiListResponseOfFeatureDetails), response.Headers);
        }
    
        /// <summary>
        /// Retrieves details of a specific institution available in Yapily 
        /// </summary>
        /// <param name="institutionId">__Mandatory__. The Yapily institution Id for the &#x60;Institution&#x60;.</param>
        /// <param name="xYapilyApiVersion">__Optional__. Determines the API version to use. Valid values are &#x60;1.0&#x60; or &#x60;2.0-ALPHA&#x60;. Defaults to &#x60;1.0&#x60;</param>
        /// <returns>Institution</returns>
        public Institution GetInstitutionUsingGET (string institutionId, string xYapilyApiVersion)
        {
            // verify the required parameter 'institutionId' is set
            if (institutionId == null) throw new ApiException(400, "Missing required parameter 'institutionId' when calling GetInstitutionUsingGET");
    
            var path = "/institutions/{institutionId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "institutionId" + "}", ApiClient.ParameterToString(institutionId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetInstitutionUsingGET: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetInstitutionUsingGET: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Institution) ApiClient.Deserialize(response.Content, typeof(Institution), response.Headers);
        }
    
        /// <summary>
        /// Retrieves the list of institutions available in Yapily 
        /// </summary>
        /// <param name="xYapilyApiVersion">__Optional__. Determines the API version to use. Valid values are &#x60;1.0&#x60; or &#x60;2.0-ALPHA&#x60;. Defaults to &#x60;1.0&#x60;</param>
        /// <returns>ApiListResponseOfInstitution</returns>
        public ApiListResponseOfInstitution GetInstitutionsUsingGET (string xYapilyApiVersion)
        {
    
            var path = "/institutions";
            path = path.Replace("{format}", "json");
                
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetInstitutionsUsingGET: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetInstitutionsUsingGET: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ApiListResponseOfInstitution) ApiClient.Deserialize(response.Content, typeof(ApiListResponseOfInstitution), response.Headers);
        }
    
    }
}
