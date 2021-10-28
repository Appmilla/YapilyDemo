using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Refit;

namespace Cms
{
    /// <summary>
    /// Other Fee type which is not available in the standard code set    /// </summary>    
    public class OtherFeeType
    {

        /// <summary>
        /// Code
        /// </summary> 

        [AliasAs("Code")]
        public string Code { get; set; }


        /// <summary>
        /// Description
        /// </summary> 

        [AliasAs("Description")]
        public string Description { get; set; }


        /// <summary>
        /// Name
        /// </summary> 

        [AliasAs("Name")]
        public string Name { get; set; }

    }
}