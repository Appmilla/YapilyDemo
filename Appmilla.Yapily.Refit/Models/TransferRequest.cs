using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Refit;

namespace Cms
{
    /// <summary>
    /// TransferRequest
    /// </summary>    
    public class TransferRequest
    {

        /// <summary>
        /// AccountId
        /// </summary> 

        [AliasAs("accountId")]
        public string AccountId { get; set; }


        /// <summary>
        /// Amount
        /// </summary> 

        [AliasAs("amount")]
        public double? Amount { get; set; }


        /// <summary>
        /// Currency
        /// </summary> 

        [AliasAs("currency")]
        public string Currency { get; set; }


        /// <summary>
        /// Reference
        /// </summary> 

        [AliasAs("reference")]
        public string Reference { get; set; }


        /// <summary>
        /// TransferReferenceId
        /// </summary> 

        [AliasAs("transferReferenceId")]
        public string TransferReferenceId { get; set; }

    }
}