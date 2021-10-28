using System.Collections.Generic;
using Refit;

namespace Appmilla.Yapily.Refit.Models
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