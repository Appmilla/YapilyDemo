using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Refit;

namespace Cms
{
    /// <summary>
    /// Other residency type which is not available in standard code list.    /// </summary>    
    public class OtherResidencyType
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