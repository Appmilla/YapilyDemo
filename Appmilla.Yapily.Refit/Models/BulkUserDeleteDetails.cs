using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Refit;

namespace Cms
{
    /// <summary>
    /// BulkUserDeleteDetails
    /// </summary>    
    public class BulkUserDeleteDetails
    {

        /// <summary>
        /// Id
        /// </summary> 

        [AliasAs("id")]
        public string Id { get; set; }


        /// <summary>
        /// InvalidApplicationUserIds
        /// </summary> 

        [AliasAs("invalidApplicationUserIds")]
        public List<string> InvalidApplicationUserIds { get; set; }


        /// <summary>
        /// InvalidUserUuids
        /// </summary> 

        [AliasAs("invalidUserUuids")]
        public List<string> InvalidUserUuids { get; set; }


        /// <summary>
        /// Status
        /// </summary> 

        [AliasAs("status")]
        public BulkUserDeleteDetailsStatus? Status { get; set; }


        /// <summary>
        /// StartedAt
        /// </summary> 

        [AliasAs("startedAt")]
        public System.DateTimeOffset? StartedAt { get; set; }


        /// <summary>
        /// Users
        /// </summary> 

        [AliasAs("users")]
        public List<UserDeleteResponse> Users { get; set; }


        /// <summary>
        /// Links
        /// </summary> 

        [AliasAs("links")]
        public System.Collections.Generic.IDictionary<string, string> Links { get; set; }

    }
}