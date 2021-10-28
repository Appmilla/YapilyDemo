using Refit;

namespace Appmilla.Yapily.Refit.Models
{
    /// <summary>
    /// ProprietaryBankTransactionCode
    /// </summary>    
    public class ProprietaryBankTransactionCode
    {

        /// <summary>
        /// Code
        /// </summary> 

        [AliasAs("code")]
        public string Code { get; set; }


        /// <summary>
        /// Issuer
        /// </summary> 

        [AliasAs("issuer")]
        public string Issuer { get; set; }

    }
}