using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Refit;

namespace Cms
{
    /// <summary>
    /// AccountName
    /// </summary>    
    public class AccountName
    {

        /// <summary>
        /// Name
        /// </summary> 
        [Required(AllowEmptyStrings = true)]

        [AliasAs("name")]
        public string Name { get; set; }

    }
}