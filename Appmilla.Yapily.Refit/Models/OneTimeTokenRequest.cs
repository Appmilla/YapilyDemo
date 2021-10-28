using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Refit;

namespace Cms
{
    /// <summary>
    /// OneTimeTokenRequest
    /// </summary>    
    public class OneTimeTokenRequest
    {

        /// <summary>
        /// OneTimeToken
        /// </summary> 
        [Required(AllowEmptyStrings = true)]

        [AliasAs("oneTimeToken")]
        public string OneTimeToken { get; set; }

    }
}