using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Refit;

namespace Cms
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