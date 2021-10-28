using System.Collections.Generic;
using Refit;

namespace Appmilla.Yapily.Refit.Models
{
    /// <summary>
    /// UserDeleteResponse
    /// </summary>    
    public class UserDeleteResponse
    {

        /// <summary>
        /// Id
        /// </summary> 

        [AliasAs("id")]
        public string Id { get; set; }


        /// <summary>
        /// DeleteStatus
        /// </summary> 

        [AliasAs("deleteStatus")]
        public UserDeleteResponseDeleteStatus? DeleteStatus { get; set; }


        /// <summary>
        /// CreationDate
        /// </summary> 

        [AliasAs("creationDate")]
        public System.DateTimeOffset? CreationDate { get; set; }


        /// <summary>
        /// UserConsents
        /// </summary> 

        [AliasAs("userConsents")]
        public List<ConsentDeleteResponse> UserConsents { get; set; }

    }
}