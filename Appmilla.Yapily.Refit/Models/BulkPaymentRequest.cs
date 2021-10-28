using System.Collections.Generic;
using Refit;

namespace Appmilla.Yapily.Refit.Models
{
    /// <summary>
    /// BulkPaymentRequest
    /// </summary>    
    public class BulkPaymentRequest
    {
        /// <summary>
        /// Execution datetime for the bulk payments
        /// </summary>
        [AliasAs("executionDateTime")]
        public System.DateTimeOffset? ExecutionDateTime { get; set; }

        /// <summary>
        /// Required field for AIB bulk payments
        /// </summary>
        [AliasAs("originatorIdentificationNumber")]
        public string OriginatorIdentificationNumber { get; set; }


        /// <summary>
        /// Payments
        /// </summary> 
        //[Required]

        [AliasAs("payments")]
        public List<PaymentRequest> Payments { get; set; } = new List<PaymentRequest>();

    }
}