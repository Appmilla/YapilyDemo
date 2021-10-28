using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Refit;

namespace Cms
{
    /// <summary>
    /// Amount
    /// </summary>    
    public class Amount
    {

        /// <summary>
        /// Amount1
        /// </summary> 

        [AliasAs("amount")]
        public double Amount1 { get; set; }

        /// <summary>
        /// ISO 4217 currency code
        /// </summary>        [Required(AllowEmptyStrings = true)]

        [AliasAs("currency")]
        public string Currency { get; set; }

    }
}