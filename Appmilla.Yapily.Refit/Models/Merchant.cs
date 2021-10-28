using Refit;

namespace Appmilla.Yapily.Refit.Models
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