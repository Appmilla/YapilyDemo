using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Refit;

namespace Cms
{
    /// <summary>
    /// Brand registered by the banking group at https://register.fca.org.uk/    /// </summary>    
    public class PersonalCurrentAccountBrand
    {

        /// <summary>
        /// BrandName
        /// </summary> 

        [AliasAs("BrandName")]
        public string BrandName { get; set; }


        /// <summary>
        /// PCA
        /// </summary> 

        [AliasAs("PCA")]
        public List<PersonalCurrentAccountPCA> PCA { get; set; }

    }
}