using System.ComponentModel.DataAnnotations;
using Refit;

namespace Appmilla.Yapily.Refit.Models
{
    /// <summary>
    /// PeriodicPaymentRequest
    /// </summary>    
    public class PeriodicPaymentRequest
    {

        /// <summary>
        /// Frequency
        /// </summary> 
        [Required]
        [AliasAs("frequency")]
        public FrequencyRequest Frequency { get; set; } = new FrequencyRequest();


        /// <summary>
        /// NumberOfPayments
        /// </summary> 

        [AliasAs("numberOfPayments")]
        public int? NumberOfPayments { get; set; }


        /// <summary>
        /// NextPaymentDateTime
        /// </summary> 

        [AliasAs("nextPaymentDateTime")]
        public System.DateTimeOffset? NextPaymentDateTime { get; set; }


        /// <summary>
        /// NextPaymentAmount
        /// </summary> 

        [AliasAs("nextPaymentAmount")]
        public Amount NextPaymentAmount { get; set; }


        /// <summary>
        /// FinalPaymentDateTime
        /// </summary> 

        [AliasAs("finalPaymentDateTime")]
        public System.DateTimeOffset? FinalPaymentDateTime { get; set; }


        /// <summary>
        /// FinalPaymentAmount
        /// </summary> 

        [AliasAs("finalPaymentAmount")]
        public Amount FinalPaymentAmount { get; set; }

    }
}