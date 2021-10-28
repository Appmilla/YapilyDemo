using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Refit;

namespace Cms
{
    /// <summary>
    /// ExchangeRateInformationResponse
    /// </summary>    
    public class ExchangeRateInformationResponse
    {

        /// <summary>
        /// ExchangeRateExpiryDate
        /// </summary> 

        [AliasAs("exchangeRateExpiryDate")]
        public System.DateTimeOffset? ExchangeRateExpiryDate { get; set; }


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
        public ExchangeRateInformationResponseRateType? RateType { get; set; }


        /// <summary>
        /// UnitCurrency
        /// </summary> 

        [AliasAs("unitCurrency")]
        public string UnitCurrency { get; set; }

    }
}