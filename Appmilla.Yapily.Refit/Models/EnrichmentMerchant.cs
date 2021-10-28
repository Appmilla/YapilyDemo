using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Refit;

namespace Cms
{
    /// <summary>
    /// EnrichmentMerchant
    /// </summary>    
    public class EnrichmentMerchant
    {
        /// <summary>
        /// MerchantName
        /// </summary>
        [AliasAs("merchantName")]
        public string MerchantName { get; set; }

        /// <summary>
        /// ParentGroup
        /// </summary>
        [AliasAs("parentGroup")]
        public string ParentGroup { get; set; }

    }
}