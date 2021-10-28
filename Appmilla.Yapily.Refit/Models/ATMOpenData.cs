using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Refit;

namespace Cms
{
    /// <summary>
    /// Environment of the ATM.    /// </summary>    
    public class ATMOpenData
    {

        /// <summary>
        /// Brand
        /// </summary> 

        [AliasAs("Brand")]
        public List<ATMOpenDataBrand> Brand { get; set; }

    }
}