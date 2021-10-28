using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Refit;

namespace Cms
{
    /// <summary>
    /// PersonalCurrentAccountPCA
    /// </summary>    
    public class PersonalCurrentAccountPCA
    {

        /// <summary>
        /// Identification
        /// </summary> 

        [AliasAs("Identification")]
        public string Identification { get; set; }


        /// <summary>
        /// Name
        /// </summary> 

        [AliasAs("Name")]
        public string Name { get; set; }


        /// <summary>
        /// PCAMarketingState
        /// </summary> 

        [AliasAs("PCAMarketingState")]
        public List<PersonalCurrentAccountPCAMarketingState> PCAMarketingState { get; set; }


        /// <summary>
        /// Segment
        /// </summary> 

        [AliasAs("Segment")]
        public List<string> Segment { get; set; }

    }
}