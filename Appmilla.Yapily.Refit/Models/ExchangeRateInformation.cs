using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Refit;

namespace Cms
{
    /// <summary>
    /// ExchangeRateInformation
    /// </summary>    
    public class ExchangeRateInformation
    {

        /// <summary>
        /// ForeignExchangeContractReference
        /// </summary> 

        [AliasAs("foreignExchangeContractReference")]
        public string ForeignExchangeContractReference { get; set; }


        /// <summary>
        /// Rate
        /// </summary> 

        [AliasAs("rate")]
        public double? Rate { get; set; }


        /// <summary>
        /// RateType
        /// </summary> 

        [AliasAs("rateType")]
        public ExchangeRateInformationRateType? RateType { get; set; }


        /// <summary>
        /// UnitCurrency
        /// </summary> 

        [AliasAs("unitCurrency")]
        public string UnitCurrency { get; set; }

    }
}