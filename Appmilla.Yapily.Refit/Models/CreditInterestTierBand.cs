using System.Collections.Generic;
using Refit;

namespace Appmilla.Yapily.Refit.Models
{
    /// <summary>
    /// Tier Band Details    /// </summary>    
    public class CreditInterestTierBand
    {

        /// <summary>
        /// AER
        /// </summary> 

        [AliasAs("AER")]
        public string AER { get; set; }


        /// <summary>
        /// ApplicationFrequency
        /// </summary> 

        [AliasAs("ApplicationFrequency")]
        public CreditInterestTierBandApplicationFrequency? ApplicationFrequency { get; set; }


        /// <summary>
        /// BankInterestRate
        /// </summary> 

        [AliasAs("BankInterestRate")]
        public string BankInterestRate { get; set; }


        /// <summary>
        /// BankInterestRateType
        /// </summary> 

        [AliasAs("BankInterestRateType")]
        public CreditInterestTierBandBankInterestRateType? BankInterestRateType { get; set; }


        /// <summary>
        /// CalculationFrequency
        /// </summary> 

        [AliasAs("CalculationFrequency")]
        public CreditInterestTierBandCalculationFrequency? CalculationFrequency { get; set; }


        /// <summary>
        /// DepositInterestAppliedCoverage
        /// </summary> 

        [AliasAs("DepositInterestAppliedCoverage")]
        public CreditInterestTierBandDepositInterestAppliedCoverage? DepositInterestAppliedCoverage { get; set; }


        /// <summary>
        /// FixedVariableInterestRateType
        /// </summary> 

        [AliasAs("FixedVariableInterestRateType")]
        public CreditInterestTierBandFixedVariableInterestRateType? FixedVariableInterestRateType { get; set; }


        /// <summary>
        /// Identification
        /// </summary> 

        [AliasAs("Identification")]
        public string Identification { get; set; }


        /// <summary>
        /// Notes
        /// </summary> 

        [AliasAs("Notes")]
        public List<string> Notes { get; set; }


        /// <summary>
        /// OtherApplicationFrequency
        /// </summary> 

        [AliasAs("OtherApplicationFrequency")]
        public OtherApplicationFrequency OtherApplicationFrequency { get; set; }


        /// <summary>
        /// OtherBankInterestType
        /// </summary> 

        [AliasAs("OtherBankInterestType")]
        public OtherBankInterestType OtherBankInterestType { get; set; }


        /// <summary>
        /// OtherCalculationFrequency
        /// </summary> 

        [AliasAs("OtherCalculationFrequency")]
        public OtherCalculationFrequency OtherCalculationFrequency { get; set; }


        /// <summary>
        /// TierValueMaximum
        /// </summary> 

        [AliasAs("TierValueMaximum")]
        public string TierValueMaximum { get; set; }


        /// <summary>
        /// TierValueMinimum
        /// </summary> 

        [AliasAs("TierValueMinimum")]
        public string TierValueMinimum { get; set; }

    }
}