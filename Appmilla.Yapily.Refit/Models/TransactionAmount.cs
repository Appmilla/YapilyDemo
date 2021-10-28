using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Refit;

namespace Cms
{
    /// <summary>
    /// TransactionAmount
    /// </summary>    
    public class TransactionAmount
    {

        /// <summary>
        /// Amount
        /// </summary> 

        [AliasAs("amount")]
        public double Amount { get; set; }

        /// <summary>
        /// ISO 4217 currency code
        /// </summary>        [Required(AllowEmptyStrings = true)]

        [AliasAs("currency")]
        public string Currency { get; set; }

    }
}