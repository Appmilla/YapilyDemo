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
    public interface IApplicationUsersApi
    {
        /// <summary>
        /// Add an application user 
        /// </summary>
        /// <param name="body">newApplicationUser</param>
        /// <param name="xYapilyApiVersion">__Optional__. Determines the API version to use. Valid values are &#x60;1.0&#x60; or &#x60;2.0-ALPHA&#x60;. Defaults to &#x60;1.0&#x60;</param>
        /// <returns>ApplicationUser</returns>
        ApplicationUser AddUserUsingPOST (NewApplicationUser body, string xYapilyApiVersion);
        /// <summary>
        /// Delete an application user and sub-resources (including consent resources on institution APIs if they exist) 
        /// </summary>
        /// <param name="userUuid">__Mandatory__. The Yapily generated UUID for the user.</param>
        /// <param name="xYapilyApiVersion">__Optional__. Determines the API version to use. Valid values are &#x60;1.0&#x60; or &#x60;2.0-ALPHA&#x60;. Defaults to &#x60;1.0&#x60;</param>
        /// <returns>ApiResponseOfUserDeleteResponse</returns>
        ApiResponseOfUserDeleteResponse DeleteUserUsingDELETE (string userUuid, string xYapilyApiVersion);
        /// <summary>
        /// Get details of a user deletion job 
        /// </summary>
        /// <param name="jobId">job-id</param>
        /// <returns>ApiResponseOfBulkUserDeleteDetails</returns>
        ApiResponseOfBulkUserDeleteDetails GetDeleteUsersJobUsingGET (string jobId);
        /// <summary>
        /// Get details of all user deletion jobs 
        /// </summary>
        /// <returns>ApiListResponseOfBulkUserDelete</returns>
        ApiListResponseOfBulkUserDelete GetDeleteUsersJobsUsingGET ();
        /// <summary>
        /// Get an application user 
        /// </summary>
        /// <param name="userUuid">__Mandatory__. The Yapily generated UUID for the user.</param>
        /// <param name="xYapilyApiVersion">__Optional__. Determines the API version to use. Valid values are &#x60;1.0&#x60; or &#x60;2.0-ALPHA&#x60;. Defaults to &#x60;1.0&#x60;</param>
        /// <returns>ApplicationUser</returns>
        ApplicationUser GetUserUsingGET (string userUuid, string xYapilyApiVersion);
        /// <summary>
        /// Get application users 
        /// </summary>
        /// <param name="xYapilyApiVersion">__Optional__. Determines the API version to use. Valid values are &#x60;1.0&#x60; or &#x60;2.0-ALPHA&#x60;. Defaults to &#x60;1.0&#x60;</param>
        /// <param name="filterApplicationUserId">__Optional__. Filter records based on the list of &#x60;applicationUserId&#x60; users provided.</param>
        /// <returns>List&lt;ApplicationUser&gt;</returns>
        List<ApplicationUser> GetUsersUsingGET (string xYapilyApiVersion, List<string> filterApplicationUserId);
        /// <summary>
        /// Start a job to delete application users by specifying their identifiers 
        /// </summary>
        /// <param name="body">userDeleteRequest</param>
        /// <returns>ApiResponseOfBulkUserDeleteDetails</returns>
        ApiResponseOfBulkUserDeleteDetails StartDeleteUsersJobUsingPOST (UserDeleteRequest body);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ApplicationUsersApi : IApplicationUsersApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicationUsersApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public ApplicationUsersApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicationUsersApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ApplicationUsersApi(String basePath)
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
        /// Add an application user 
        /// </summary>
        /// <param name="body">newApplicationUser</param>
        /// <param name="xYapilyApiVersion">__Optional__. Determines the API version to use. Valid values are &#x60;1.0&#x60; or &#x60;2.0-ALPHA&#x60;. Defaults to &#x60;1.0&#x60;</param>
        /// <returns>ApplicationUser</returns>
        public ApplicationUser AddUserUsingPOST (NewApplicationUser body, string xYapilyApiVersion)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling AddUserUsingPOST");
    
            var path = "/users";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AddUserUsingPOST: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AddUserUsingPOST: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ApplicationUser) ApiClient.Deserialize(response.Content, typeof(ApplicationUser), response.Headers);
        }
    
        /// <summary>
        /// Delete an application user and sub-resources (including consent resources on institution APIs if they exist) 
        /// </summary>
        /// <param name="userUuid">__Mandatory__. The Yapily generated UUID for the user.</param>
        /// <param name="xYapilyApiVersion">__Optional__. Determines the API version to use. Valid values are &#x60;1.0&#x60; or &#x60;2.0-ALPHA&#x60;. Defaults to &#x60;1.0&#x60;</param>
        /// <returns>ApiResponseOfUserDeleteResponse</returns>
        public ApiResponseOfUserDeleteResponse DeleteUserUsingDELETE (string userUuid, string xYapilyApiVersion)
        {
            // verify the required parameter 'userUuid' is set
            if (userUuid == null) throw new ApiException(400, "Missing required parameter 'userUuid' when calling DeleteUserUsingDELETE");
    
            var path = "/users/{userUuid}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "userUuid" + "}", ApiClient.ParameterToString(userUuid));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                         if (xYapilyApiVersion != null) headerParams.Add("x-yapily-api-version", ApiClient.ParameterToString(xYapilyApiVersion)); // header parameter
            
            // authentication setting, if any
            String[] authSettings = new String[] { "basicAuth", "tokenAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteUserUsingDELETE: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteUserUsingDELETE: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ApiResponseOfUserDeleteResponse) ApiClient.Deserialize(response.Content, typeof(ApiResponseOfUserDeleteResponse), response.Headers);
        }
    
        /// <summary>
        /// Get details of a user deletion job 
        /// </summary>
        /// <param name="jobId">job-id</param>
        /// <returns>ApiResponseOfBulkUserDeleteDetails</returns>
        public ApiResponseOfBulkUserDeleteDetails GetDeleteUsersJobUsingGET (string jobId)
        {
            // verify the required parameter 'jobId' is set
            if (jobId == null) throw new ApiException(400, "Missing required parameter 'jobId' when calling GetDeleteUsersJobUsingGET");
    
            var path = "/delete-users/{job-id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "job-id" + "}", ApiClient.ParameterToString(jobId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetDeleteUsersJobUsingGET: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetDeleteUsersJobUsingGET: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ApiResponseOfBulkUserDeleteDetails) ApiClient.Deserialize(response.Content, typeof(ApiResponseOfBulkUserDeleteDetails), response.Headers);
        }
    
        /// <summary>
        /// Get details of all user deletion jobs 
        /// </summary>
        /// <returns>ApiListResponseOfBulkUserDelete</returns>
        public ApiListResponseOfBulkUserDelete GetDeleteUsersJobsUsingGET ()
        {
    
            var path = "/delete-users";
            path = path.Replace("{format}", "json");
                
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetDeleteUsersJobsUsingGET: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetDeleteUsersJobsUsingGET: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ApiListResponseOfBulkUserDelete) ApiClient.Deserialize(response.Content, typeof(ApiListResponseOfBulkUserDelete), response.Headers);
        }
    
        /// <summary>
        /// Get an application user 
        /// </summary>
        /// <param name="userUuid">__Mandatory__. The Yapily generated UUID for the user.</param>
        /// <param name="xYapilyApiVersion">__Optional__. Determines the API version to use. Valid values are &#x60;1.0&#x60; or &#x60;2.0-ALPHA&#x60;. Defaults to &#x60;1.0&#x60;</param>
        /// <returns>ApplicationUser</returns>
        public ApplicationUser GetUserUsingGET (string userUuid, string xYapilyApiVersion)
        {
            // verify the required parameter 'userUuid' is set
            if (userUuid == null) throw new ApiException(400, "Missing required parameter 'userUuid' when calling GetUserUsingGET");
    
            var path = "/users/{userUuid}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "userUuid" + "}", ApiClient.ParameterToString(userUuid));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetUserUsingGET: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetUserUsingGET: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ApplicationUser) ApiClient.Deserialize(response.Content, typeof(ApplicationUser), response.Headers);
        }
    
        /// <summary>
        /// Get application users 
        /// </summary>
        /// <param name="xYapilyApiVersion">__Optional__. Determines the API version to use. Valid values are &#x60;1.0&#x60; or &#x60;2.0-ALPHA&#x60;. Defaults to &#x60;1.0&#x60;</param>
        /// <param name="filterApplicationUserId">__Optional__. Filter records based on the list of &#x60;applicationUserId&#x60; users provided.</param>
        /// <returns>List&lt;ApplicationUser&gt;</returns>
        public List<ApplicationUser> GetUsersUsingGET (string xYapilyApiVersion, List<string> filterApplicationUserId)
        {
    
            var path = "/users";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (filterApplicationUserId != null) queryParams.Add("filter[applicationUserId]", ApiClient.ParameterToString(filterApplicationUserId)); // query parameter
             if (xYapilyApiVersion != null) headerParams.Add("x-yapily-api-version", ApiClient.ParameterToString(xYapilyApiVersion)); // header parameter
            
            // authentication setting, if any
            String[] authSettings = new String[] { "basicAuth", "tokenAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetUsersUsingGET: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetUsersUsingGET: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<ApplicationUser>) ApiClient.Deserialize(response.Content, typeof(List<ApplicationUser>), response.Headers);
        }
    
        /// <summary>
        /// Start a job to delete application users by specifying their identifiers 
        /// </summary>
        /// <param name="body">userDeleteRequest</param>
        /// <returns>ApiResponseOfBulkUserDeleteDetails</returns>
        public ApiResponseOfBulkUserDeleteDetails StartDeleteUsersJobUsingPOST (UserDeleteRequest body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling StartDeleteUsersJobUsingPOST");
    
            var path = "/delete-users";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                    postBody = ApiClient.Serialize(body); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] { "basicAuth", "tokenAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling StartDeleteUsersJobUsingPOST: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling StartDeleteUsersJobUsingPOST: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ApiResponseOfBulkUserDeleteDetails) ApiClient.Deserialize(response.Content, typeof(ApiResponseOfBulkUserDeleteDetails), response.Headers);
        }
    
    }
}
