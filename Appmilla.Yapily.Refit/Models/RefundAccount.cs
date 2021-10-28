using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Refit;

namespace Cms
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