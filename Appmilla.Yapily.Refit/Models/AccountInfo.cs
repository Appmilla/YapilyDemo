using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Refit;

namespace Cms
{
    /// <summary>
    /// AccountInfo
    /// </summary>    
    public class AccountInfo
    {

        /// <summary>
        /// AccountId
        /// </summary> 

        [AliasAs("accountId")]
        public string AccountId { get; set; }


        /// <summary>
        /// AccountIdentification
        /// </summary> 

        [AliasAs("accountIdentification")]
        public AccountIdentification AccountIdentification { get; set; }

    }
}