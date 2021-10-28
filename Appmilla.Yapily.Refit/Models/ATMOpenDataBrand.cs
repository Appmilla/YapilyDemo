using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Refit;

namespace Cms
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