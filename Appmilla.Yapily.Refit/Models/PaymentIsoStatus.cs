using Refit;

namespace Appmilla.Yapily.Refit.Models
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