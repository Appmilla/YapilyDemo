using Refit;

namespace Appmilla.Yapily.Refit.Models
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