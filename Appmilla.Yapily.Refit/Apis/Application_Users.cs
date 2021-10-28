using System.Collections.Generic;
using System.Threading.Tasks;
using Appmilla.Yapily.Refit.Models;
using Refit;

namespace Appmilla.Yapily.Refit.Apis
{
    public interface IApplication_Users
    {
        /// <summary>
        /// Get details of all user deletion jobs
        /// </summary>
        /// <returns>OK</returns>
        [Get("/delete-users")]
        [Headers()] 
        Task<ApiListResponseOfBulkUserDelete> GetDeleteUsersJobsUsingGETAsync();

        /// <summary>
        /// Start a job to delete application users by specifying their identifiers
        /// </summary>
        /// <param name="userDeleteRequest">userDeleteRequest</param>
        /// <returns>OK</returns>
        [Post("/delete-users")]
        [Headers()] 
        Task<ApiResponseOfBulkUserDeleteDetails> StartDeleteUsersJobUsingPOSTAsync([Body][AliasAs("userDeleteRequest")] UserDeleteRequest userDeleteRequest);

        /// <summary>
        /// Get details of a user deletion job
        /// </summary>
        /// <param name="job_id">job-id</param>
        /// <returns>OK</returns>
        [Get("/delete-users/{job-id}")]
        [Headers()] 
        Task<ApiResponseOfBulkUserDeleteDetails> GetDeleteUsersJobUsingGETAsync([AliasAs("job_id")] string job_id);

        /// <summary>
        /// Get application users
        /// </summary>
        /// <param name="filterapplicationUserId">__Optional__. Filter records based on the list of `applicationUserId` users provided.</param>
        /// <returns>OK</returns>
        [Get("/users")]
        [Headers("x-yapily-api-version: 1.0", "Authorization: Basic")] 
        Task<ICollection<ApplicationUser>> GetUsersUsingGETAsync([Query][AliasAs("filterapplicationUserId")] IEnumerable<string> filterapplicationUserId);

        /// <summary>
        /// Add an application user
        /// </summary>
        /// <param name="newApplicationUser">newApplicationUser</param>
        /// <returns>OK</returns>
        [Post("/users")]
        [Headers("x-yapily-api-version: 1.0", "Authorization: Basic")] 
        Task<ApplicationUser> AddUserUsingPOSTAsync([Body][AliasAs("newApplicationUser")] NewApplicationUser newApplicationUser);

        /// <summary>
        /// Get an application user
        /// </summary>
        /// <param name="userUuid">__Mandatory__. The Yapily generated UUID for the user.</param>
        /// <returns>OK</returns>
        [Get("/users/{userUuid}")]
        [Headers("x-yapily-api-version: 1.0", "Authorization: Basic")] 
        Task<ApplicationUser> GetUserUsingGETAsync([AliasAs("userUuid")] string userUuid);

        /// <summary>
        /// Delete an application user and sub-resources (including consent resources on institution APIs if they exist)
        /// </summary>
        /// <param name="userUuid">__Mandatory__. The Yapily generated UUID for the user.</param>
        /// <returns>OK</returns>
        [Delete("/users/{userUuid}")]
        [Headers("x-yapily-api-version: 1.0", "Authorization: Basic")] 
        Task<ApiResponseOfUserDeleteResponse> DeleteUserUsingDELETEAsync([AliasAs("userUuid")] string userUuid);

    }
}