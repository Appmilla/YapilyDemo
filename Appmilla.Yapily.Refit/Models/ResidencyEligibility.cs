using System.Collections.Generic;
using Refit;

namespace Appmilla.Yapily.Refit.Models
{
    /// <summary>
    /// Countries in which an accountholder can reside and, therefore, be eligible to open an account    /// </summary>    
    public class ResidencyEligibility
    {

        /// <summary>
        /// Notes
        /// </summary> 

        [AliasAs("Notes")]
        public List<string> Notes { get; set; }


        /// <summary>
        /// OtherResidencyType
        /// </summary> 

        [AliasAs("OtherResidencyType")]
        public OtherResidencyType OtherResidencyType { get; set; }


        /// <summary>
        /// ResidencyIncluded
        /// </summary> 

        [AliasAs("ResidencyIncluded")]
        public List<string> ResidencyIncluded { get; set; }


        /// <summary>
        /// ResidencyType
        /// </summary> 

        [AliasAs("ResidencyType")]
        public ResidencyEligibilityResidencyType? ResidencyType { get; set; }

    }
}