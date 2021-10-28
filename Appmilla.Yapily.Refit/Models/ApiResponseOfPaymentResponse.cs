using Refit;

namespace Appmilla.Yapily.Refit.Models
{
    /// <summary>
    /// ApiResponseOfPaymentResponse
    /// </summary>    
    public class ApiResponseOfPaymentResponse
    {

        /// <summary>
        /// Meta
        /// </summary> 

        [AliasAs("meta")]
        public ResponseMeta Meta { get; set; }


        /// <summary>
        /// Data
        /// </summary> 

        [AliasAs("data")]
        public PaymentResponse Data { get; set; }


        /// <summary>
        /// Links
        /// </summary> 

        [AliasAs("links")]
        public System.Collections.Generic.IDictionary<string, string> Links { get; set; }

    }
}