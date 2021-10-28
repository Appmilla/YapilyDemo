using System.Collections.Generic;
using Refit;

namespace Appmilla.Yapily.Refit.Models
{
    /// <summary>
    /// Age eligibility that a person should be to hold this account    /// </summary>    
    public class AgeEligibility
    {

        /// <summary>
        /// MaximumAge
        /// </summary> 

        [AliasAs("MaximumAge")]
        public float? MaximumAge { get; set; }


        /// <summary>
        /// MinimumAge
        /// </summary> 

        [AliasAs("MinimumAge")]
        public float? MinimumAge { get; set; }


        /// <summary>
        /// Notes
        /// </summary> 

        [AliasAs("Notes")]
        public List<string> Notes { get; set; }

    }
}