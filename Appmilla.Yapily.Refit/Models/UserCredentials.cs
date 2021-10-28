using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Refit;

namespace Cms
{
    /// <summary>
    /// UserCredentials
    /// </summary>    
    public class UserCredentials
    {

        /// <summary>
        /// Id
        /// </summary> 
        [Required(AllowEmptyStrings = true)]

        [AliasAs("id")]
        public string Id { get; set; }


        /// <summary>
        /// CorporateId
        /// </summary> 

        [AliasAs("corporateId")]
        public string CorporateId { get; set; }


        /// <summary>
        /// Password
        /// </summary> 
        [Required(AllowEmptyStrings = true)]

        [AliasAs("password")]
        public string Password { get; set; }

    }
}