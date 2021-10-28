using Refit;

namespace Appmilla.Yapily.Refit.Models
{
    /// <summary>
    /// Beneficiary
    /// </summary>    
    public class Beneficiary
    {

        /// <summary>
        /// Id
        /// </summary> 

        [AliasAs("id")]
        public string Id { get; set; }


        /// <summary>
        /// Trusted
        /// </summary> 

        [AliasAs("trusted")]
        public bool? Trusted { get; set; }


        /// <summary>
        /// Reference
        /// </summary> 

        [AliasAs("reference")]
        public string Reference { get; set; }


        /// <summary>
        /// Payee
        /// </summary> 

        [AliasAs("payee")]
        public Payee Payee { get; set; }

    }
}