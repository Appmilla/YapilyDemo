using System.ComponentModel.DataAnnotations;
using Refit;

namespace Appmilla.Yapily.Refit.Models
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
        /// </summary>
        [Required(AllowEmptyStrings = true)]
        [AliasAs("currency")]
        public string Currency { get; set; }

    }
}