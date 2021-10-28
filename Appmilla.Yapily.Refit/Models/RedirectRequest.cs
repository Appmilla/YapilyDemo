using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Refit;

namespace Cms
{
    /// <summary>
    /// RedirectRequest
    /// </summary>    
    public class RedirectRequest
    {

        /// <summary>
        /// Url
        /// </summary> 
        [Required(AllowEmptyStrings = true)]

        [AliasAs("url")]
        public string Url { get; set; }

    }
}