using System.Collections.Generic;
using Refit;

namespace Appmilla.Yapily.Refit.Models
{
    /// <summary>
    /// PaymentResponses
    /// </summary>    
    public class PaymentResponses
    {

        /// <summary>
        /// Payments
        /// </summary> 

        [AliasAs("payments")]
        public List<PaymentResponse> Payments { get; set; }

    }
}