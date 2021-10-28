using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Refit;

namespace Cms
{
    /// <summary>
    /// PaymentIsoStatus
    /// </summary>    
    public class PaymentIsoStatus
    {

        /// <summary>
        /// Code
        /// </summary> 

        [AliasAs("code")]
        public PaymentIsoStatusCode? Code { get; set; }


        /// <summary>
        /// Name
        /// </summary> 

        [AliasAs("name")]
        public string Name { get; set; }

    }
}