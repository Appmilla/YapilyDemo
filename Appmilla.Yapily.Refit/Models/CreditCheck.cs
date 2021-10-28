using System.Collections.Generic;
using Refit;

namespace Appmilla.Yapily.Refit.Models
{
    /// <summary>
    /// Credit check criteria that the account holder will need to meet to take out the PCA product    /// </summary>    
    public class CreditCheck
    {

        /// <summary>
        /// Notes
        /// </summary> 

        [AliasAs("Notes")]
        public List<string> Notes { get; set; }


        /// <summary>
        /// ScoringType
        /// </summary> 

        [AliasAs("ScoringType")]
        public CreditCheckScoringType? ScoringType { get; set; }

    }
}