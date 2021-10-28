using System.Collections.Generic;
using Refit;

namespace Appmilla.Yapily.Refit.Models
{
    /// <summary>
    /// Brand of the Acquirer of transactions captured by the ATM    /// </summary>    
    public class ATMOpenDataBrand
    {

        /// <summary>
        /// ATM
        /// </summary> 

        [AliasAs("ATM")]
        public List<InlineResponse2001ATM> ATM { get; set; }


        /// <summary>
        /// BrandName
        /// </summary> 

        [AliasAs("BrandName")]
        public string BrandName { get; set; }

    }
}