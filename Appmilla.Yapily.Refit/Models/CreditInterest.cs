using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Refit;

namespace Cms
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