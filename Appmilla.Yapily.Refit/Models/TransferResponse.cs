using Refit;

namespace Appmilla.Yapily.Refit.Models
{
    /// <summary>
    /// TransferResponse
    /// </summary>    
    public class TransferResponse
    {

        /// <summary>
        /// FromAccountId
        /// </summary> 

        [AliasAs("fromAccountId")]
        public string FromAccountId { get; set; }


        /// <summary>
        /// ToAccountId
        /// </summary> 

        [AliasAs("toAccountId")]
        public string ToAccountId { get; set; }


        /// <summary>
        /// Status
        /// </summary> 

        [AliasAs("status")]
        public TransferResponseStatus? Status { get; set; }


        /// <summary>
        /// CreatedAt
        /// </summary> 

        [AliasAs("createdAt")]
        public System.DateTimeOffset? CreatedAt { get; set; }


        /// <summary>
        /// Reference
        /// </summary> 

        [AliasAs("reference")]
        public string Reference { get; set; }


        /// <summary>
        /// Balance
        /// </summary> 

        [AliasAs("balance")]
        public double? Balance { get; set; }


        /// <summary>
        /// Currency
        /// </summary> 

        [AliasAs("currency")]
        public string Currency { get; set; }

    }
}