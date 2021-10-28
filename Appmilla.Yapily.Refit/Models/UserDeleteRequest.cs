using System.Collections.Generic;
using Refit;

namespace Appmilla.Yapily.Refit.Models
{
    /// <summary>
    /// UserDeleteRequest
    /// </summary>    
    public class UserDeleteRequest
    {

        /// <summary>
        /// UserUuids
        /// </summary> 

        [AliasAs("userUuids")]
        public List<string> UserUuids { get; set; }


        /// <summary>
        /// ApplicationUserIds
        /// </summary> 

        [AliasAs("applicationUserIds")]
        public List<string> ApplicationUserIds { get; set; }

    }
}