using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Refit;

namespace Cms
{
    /// <summary>
    /// NewApplicationUser
    /// </summary>    
    public class NewApplicationUser
    {

        /// <summary>
        /// ApplicationUserId
        /// </summary> 

        [AliasAs("applicationUserId")]
        public string ApplicationUserId { get; set; }


        /// <summary>
        /// ReferenceId
        /// </summary> 

        [AliasAs("referenceId")]
        public string ReferenceId { get; set; }

    }
}