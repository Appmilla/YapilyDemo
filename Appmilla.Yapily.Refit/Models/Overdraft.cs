using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Refit;

namespace Cms
{
    /// <summary>
    /// Borrowing details    /// </summary>    
    public class Overdraft
    {

        /// <summary>
        /// Notes
        /// </summary> 

        [AliasAs("Notes")]
        public List<string> Notes { get; set; }


        /// <summary>
        /// OverdraftTierBandSet
        /// </summary> 

        [AliasAs("OverdraftTierBandSet")]
        public List<OverdraftOverdraftTierBandSet> OverdraftTierBandSet { get; set; }


        /// <summary>
        /// TcsAndCsURL
        /// </summary> 

        [AliasAs("TcsAndCsURL")]
        public string TcsAndCsURL { get; set; }

    }
}