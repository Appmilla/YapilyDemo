using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Refit;

namespace Cms
{
    /// <summary>
    /// Payer
    /// </summary>    
    public class Payer
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

    }
}