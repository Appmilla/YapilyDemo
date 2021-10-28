using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Refit;

namespace Cms
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