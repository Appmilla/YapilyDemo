using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Refit;

namespace Cms
{
    /// <summary>
    /// SortCodePaymentRequest
    /// </summary>    
    public class SortCodePaymentRequest
    {

        /// <summary>
        /// SenderAccountId
        /// </summary> 

        [AliasAs("senderAccountId")]
        public string SenderAccountId { get; set; }


        /// <summary>
        /// Name
        /// </summary> 
        [Required(AllowEmptyStrings = true)]

        [AliasAs("name")]
        public string Name { get; set; }


        /// <summary>
        /// Amount
        /// </summary> 

        [AliasAs("amount")]
        public double Amount { get; set; }


        /// <summary>
        /// Currency
        /// </summary> 
        [Required(AllowEmptyStrings = true)]

        [AliasAs("currency")]
        public string Currency { get; set; }


        /// <summary>
        /// Reference
        /// </summary> 
        [Required(AllowEmptyStrings = true)]

        [AliasAs("reference")]
        public string Reference { get; set; }


        /// <summary>
        /// Country
        /// </summary> 
        [Required(AllowEmptyStrings = true)]

        [AliasAs("country")]
        public string Country { get; set; }


        /// <summary>
        /// Type
        /// </summary> 

        [AliasAs("type")]
        public SortCodePaymentRequestType? Type { get; set; }


        /// <summary>
        /// AccountNumber
        /// </summary> 
        [Required(AllowEmptyStrings = true)]

        [AliasAs("accountNumber")]
        public string AccountNumber { get; set; }


        /// <summary>
        /// SortCode
        /// </summary> 
        [Required(AllowEmptyStrings = true)]

        [AliasAs("sortCode")]
        public string SortCode { get; set; }


        /// <summary>
        /// MerchantInfo
        /// </summary> 

        [AliasAs("merchantInfo")]
        public MerchantInfo MerchantInfo { get; set; }


        /// <summary>
        /// ReadRefundAccount
        /// </summary> 

        [AliasAs("readRefundAccount")]
        public bool? ReadRefundAccount { get; set; }

    }
}