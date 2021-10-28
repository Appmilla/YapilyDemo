using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Refit;

namespace Cms
{
    /// <summary>
    /// Core feature of the PCA product which can be associated to a particular Marketing State    /// </summary>    
    public class CoreProduct
    {

        /// <summary>
        /// MonthlyMaximumCharge
        /// </summary> 

        [AliasAs("MonthlyMaximumCharge")]
        public string MonthlyMaximumCharge { get; set; }


        /// <summary>
        /// ProductDescription
        /// </summary> 

        [AliasAs("ProductDescription")]
        public string ProductDescription { get; set; }


        /// <summary>
        /// ProductURL
        /// </summary> 

        [AliasAs("ProductURL")]
        public string ProductURL { get; set; }


        /// <summary>
        /// SalesAccessChannels
        /// </summary> 

        [AliasAs("SalesAccessChannels")]
        public List<SalesAccessChannels> SalesAccessChannels { get; set; }


        /// <summary>
        /// ServicingAccessChannels
        /// </summary> 

        [AliasAs("ServicingAccessChannels")]
        public List<ServicingAccessChannels> ServicingAccessChannels { get; set; }


        /// <summary>
        /// TcsAndCsURL
        /// </summary> 

        [AliasAs("TcsAndCsURL")]
        public string TcsAndCsURL { get; set; }

    }
}