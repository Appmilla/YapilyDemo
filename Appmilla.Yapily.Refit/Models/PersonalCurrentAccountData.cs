using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Refit;

namespace Cms
{
    /// <summary>
    /// PersonalCurrentAccountData
    /// </summary>    
    public class PersonalCurrentAccountData
    {

        /// <summary>
        /// Brand
        /// </summary> 

        [AliasAs("Brand")]
        public List<PersonalCurrentAccountBrand> Brand { get; set; }

    }
}