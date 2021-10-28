using Refit;

namespace Appmilla.Yapily.Refit.Models
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