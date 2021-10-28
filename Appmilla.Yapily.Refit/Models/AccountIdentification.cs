using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Refit;

namespace Cms
{
    /// <summary>
    /// AccountIdentification
    /// </summary>    
    public class AccountIdentification
    {

        /// <summary>
        /// Type
        /// </summary> 
        [Required(AllowEmptyStrings = true)]

        [AliasAs("type")]
        public AccountIdentificationType Type { get; set; }


        /// <summary>
        /// Identification
        /// </summary> 
        [Required(AllowEmptyStrings = true)]

        [AliasAs("identification")]
        public string Identification { get; set; }

    }
}