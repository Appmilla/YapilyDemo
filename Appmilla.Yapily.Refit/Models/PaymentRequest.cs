using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Refit;

namespace Cms
{
    /// <summary>
    /// PaymentRequest
    /// </summary>    
    public class PaymentRequest
    {

        /// <summary>
        /// PaymentIdempotencyId
        /// </summary> 

        [AliasAs("paymentIdempotencyId")]
        public string PaymentIdempotencyId { get; set; }


        /// <summary>
        /// Payer
        /// </summary> 

        [AliasAs("payer")]
        public Payer Payer { get; set; }


        /// <summary>
        /// Amount
        /// </summary> 

        [AliasAs("amount")]
        public Amount Amount { get; set; }


        /// <summary>
        /// Reference
        /// </summary> 

        [AliasAs("reference")]
        public string Reference { get; set; }


        /// <summary>
        /// ContextType
        /// </summary> 

        [AliasAs("contextType")]
        public PaymentRequestContextType? ContextType { get; set; }


        /// <summary>
        /// Type
        /// </summary> 
        [Required(AllowEmptyStrings = true)]

        [AliasAs("type")]
        public PaymentRequestType Type { get; set; }


        /// <summary>
        /// PaymentDateTime
        /// </summary> 

        [AliasAs("paymentDateTime")]
        public System.DateTimeOffset? PaymentDateTime { get; set; }


        /// <summary>
        /// Payee
        /// </summary> 
        [Required]

        [AliasAs("payee")]
        public Payee Payee { get; set; } = new Payee();


        /// <summary>
        /// PeriodicPayment
        /// </summary> 

        [AliasAs("periodicPayment")]
        public PeriodicPaymentRequest PeriodicPayment { get; set; }


        /// <summary>
        /// InternationalPayment
        /// </summary> 

        [AliasAs("internationalPayment")]
        public InternationalPaymentRequest InternationalPayment { get; set; }


        /// <summary>
        /// ReadRefundAccount
        /// </summary> 

        [AliasAs("readRefundAccount")]
        public bool? ReadRefundAccount { get; set; }

    }
}