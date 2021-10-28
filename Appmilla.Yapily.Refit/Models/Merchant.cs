using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Refit;

namespace Cms
{
    /// <summary>
    /// Merchant
    /// </summary>    
    public class Merchant
    {

        /// <summary>
        /// MerchantName
        /// </summary> 

        [AliasAs("merchantName")]
        public string MerchantName { get; set; }


        /// <summary>
        /// MerchantCategoryCode
        /// </summary> 

        [AliasAs("merchantCategoryCode")]
        public string MerchantCategoryCode { get; set; }

    }
}