using System.Collections.Generic;
using Refit;

namespace Appmilla.Yapily.Refit.Models
{
    /// <summary>
    /// Provides overdraft details for a specific tier or band    /// </summary>    
    public class OverdraftOverdraftTierBand
    {

        /// <summary>
        /// BankGuaranteedIndicator
        /// </summary> 

        [AliasAs("BankGuaranteedIndicator")]
        public bool? BankGuaranteedIndicator { get; set; }


        /// <summary>
        /// EAR
        /// </summary> 

        [AliasAs("EAR")]
        public string EAR { get; set; }


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
        /// OverdraftFeesCharges
        /// </summary> 

        [AliasAs("OverdraftFeesCharges")]
        public List<OverdraftOverdraftFeesCharges> OverdraftFeesCharges { get; set; }


        /// <summary>
        /// OverdraftInterestChargingCoverage
        /// </summary> 

        [AliasAs("OverdraftInterestChargingCoverage")]
        public OverdraftOverdraftTierBandOverdraftInterestChargingCoverage? OverdraftInterestChargingCoverage { get; set; }


        /// <summary>
        /// TierValueMax
        /// </summary> 

        [AliasAs("TierValueMax")]
        public string TierValueMax { get; set; }


        /// <summary>
        /// TierValueMin
        /// </summary> 

        [AliasAs("TierValueMin")]
        public string TierValueMin { get; set; }

    }
}