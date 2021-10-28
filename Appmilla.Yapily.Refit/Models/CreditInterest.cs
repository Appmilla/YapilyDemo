using System.Collections.Generic;
using Refit;

namespace Appmilla.Yapily.Refit.Models
{
    /// <summary>
    /// Details about the interest that may be payable to the PCA account holders    /// </summary>    
    public class CreditInterest
    {

        /// <summary>
        /// TierBandSet
        /// </summary> 

        [AliasAs("TierBandSet")]
        public List<CreditInterestTierBandSet> TierBandSet { get; set; }

    }
}