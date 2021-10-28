using System.Collections.Generic;
using Refit;

namespace Appmilla.Yapily.Refit.Models
{
    /// <summary>
    /// Identity verification criteria that the account holder will need to meet to take out the PCA product    /// </summary>    
    public class IDVerificationCheck
    {

        /// <summary>
        /// Notes
        /// </summary> 

        [AliasAs("Notes")]
        public List<string> Notes { get; set; }


        /// <summary>
        /// URL
        /// </summary> 

        [AliasAs("URL")]
        public string URL { get; set; }

    }
}