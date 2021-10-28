using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Refit;

namespace Cms
{
    /// <summary>
    /// The group of tiers or bands for which credit interest can be applied.    /// </summary>    
    public class CreditInterestTierBandSet
    {

        /// <summary>
        /// CalculationMethod
        /// </summary> 

        [AliasAs("CalculationMethod")]
        public CreditInterestTierBandSetCalculationMethod? CalculationMethod { get; set; }


        /// <summary>
        /// CreditInterestEligibility
        /// </summary> 

        [AliasAs("CreditInterestEligibility")]
        public List<CreditInterestCreditInterestEligibility> CreditInterestEligibility { get; set; }


        /// <summary>
        /// Destination
        /// </summary> 

        [AliasAs("Destination")]
        public CreditInterestTierBandSetDestination? Destination { get; set; }


        /// <summary>
        /// Notes
        /// </summary> 

        [AliasAs("Notes")]
        public List<string> Notes { get; set; }


        /// <summary>
        /// TierBand
        /// </summary> 

        [AliasAs("TierBand")]
        public List<CreditInterestTierBand> TierBand { get; set; }


        /// <summary>
        /// TierBandMethod
        /// </summary> 

        [AliasAs("TierBandMethod")]
        public CreditInterestTierBandSetTierBandMethod? TierBandMethod { get; set; }

    }
}