using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Refit;

namespace Cms
{
    /// <summary>
    /// Payee
    /// </summary>    
    public class Payee
    {

        /// <summary>
        /// Name
        /// </summary> 
        [Required(AllowEmptyStrings = true)]

        [AliasAs("name")]
        public string Name { get; set; }


        /// <summary>
        /// Address
        /// </summary> 

        [AliasAs("address")]
        public Address Address { get; set; }


        /// <summary>
        /// AccountIdentifications
        /// </summary> 
        [Required]

        [AliasAs("accountIdentifications")]
        public List<AccountIdentification> AccountIdentifications { get; set; } = new List<AccountIdentification>();


        /// <summary>
        /// MerchantId
        /// </summary> 

        [AliasAs("merchantId")]
        public string MerchantId { get; set; }


        /// <summary>
        /// MerchantCategoryCode
        /// </summary> 

        [AliasAs("merchantCategoryCode")]
        public string MerchantCategoryCode { get; set; }

    }
}