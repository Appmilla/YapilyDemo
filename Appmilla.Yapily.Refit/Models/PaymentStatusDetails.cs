using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Refit;

namespace Cms
{
    /// <summary>
    /// PaymentStatusDetails
    /// </summary>    
    public class PaymentStatusDetails
    {

        /// <summary>
        /// Status
        /// </summary> 

        [AliasAs("status")]
        public PaymentStatusDetailsStatus? Status { get; set; }


        /// <summary>
        /// StatusReason
        /// </summary> 

        [AliasAs("statusReason")]
        public string StatusReason { get; set; }


        /// <summary>
        /// StatusReasonDescription
        /// </summary> 

        [AliasAs("statusReasonDescription")]
        public string StatusReasonDescription { get; set; }


        /// <summary>
        /// StatusUpdateDate
        /// </summary> 

        [AliasAs("statusUpdateDate")]
        public System.DateTimeOffset? StatusUpdateDate { get; set; }


        /// <summary>
        /// MultiAuthorisationStatus
        /// </summary> 

        [AliasAs("multiAuthorisationStatus")]
        public MultiAuthorisation MultiAuthorisationStatus { get; set; }


        /// <summary>
        /// IsoStatus
        /// </summary> 

        [AliasAs("isoStatus")]
        public PaymentIsoStatus IsoStatus { get; set; }

    }
}