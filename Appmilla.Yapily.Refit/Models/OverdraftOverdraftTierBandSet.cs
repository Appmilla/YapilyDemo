using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Refit;

namespace Cms
{
    /// <summary>
    /// Tier band set details    /// </summary>    
    public class OverdraftOverdraftTierBandSet
    {

        /// <summary>
        /// AuthorisedIndicator
        /// </summary> 

        [AliasAs("AuthorisedIndicator")]
        public bool? AuthorisedIndicator { get; set; }


        /// <summary>
        /// BufferAmount
        /// </summary> 

        [AliasAs("BufferAmount")]
        public string BufferAmount { get; set; }


        /// <summary>
        /// Identification
        /// </summary> 

        [AliasAs("Identification")]
        public string Identification { get; set; }


        /// <summary>
        /// MinimumArrangedOverdraftAmount
        /// </summary> 

        [AliasAs("MinimumArrangedOverdraftAmount")]
        public string MinimumArrangedOverdraftAmount { get; set; }


        /// <summary>
        /// Notes
        /// </summary> 

        [AliasAs("Notes")]
        public List<string> Notes { get; set; }


        /// <summary>
        /// OverdraftFeesCharges
        /// </summary> 

        [AliasAs("OverdraftFeesCharges")]
        public List<OverdraftOverdraftFeesCharges1> OverdraftFeesCharges { get; set; }


        /// <summary>
        /// OverdraftTierBand
        /// </summary> 

        [AliasAs("OverdraftTierBand")]
        public List<OverdraftOverdraftTierBand> OverdraftTierBand { get; set; }


        /// <summary>
        /// OverdraftType
        /// </summary> 

        [AliasAs("OverdraftType")]
        public OverdraftOverdraftTierBandSetOverdraftType? OverdraftType { get; set; }


        /// <summary>
        /// TierBandMethod
        /// </summary> 

        [AliasAs("TierBandMethod")]
        public OverdraftOverdraftTierBandSetTierBandMethod? TierBandMethod { get; set; }

    }
}