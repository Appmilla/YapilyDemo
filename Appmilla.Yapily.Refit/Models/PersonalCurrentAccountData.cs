using System.Collections.Generic;
using Refit;

namespace Appmilla.Yapily.Refit.Models
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