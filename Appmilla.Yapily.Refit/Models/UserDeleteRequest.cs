using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Refit;

namespace Cms
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