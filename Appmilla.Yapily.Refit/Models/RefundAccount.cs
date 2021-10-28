using System.Collections.Generic;
using Refit;

namespace Appmilla.Yapily.Refit.Models
{
    /// <summary>
    /// RefundAccount
    /// </summary>    
    public class RefundAccount
    {

        /// <summary>
        /// Name
        /// </summary> 

        [AliasAs("name")]
        public string Name { get; set; }


        /// <summary>
        /// AccountIdentifications
        /// </summary> 

        [AliasAs("accountIdentifications")]
        public List<AccountIdentification> AccountIdentifications { get; set; }

    }
}