using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Refit;

namespace Cms
{
    /// <summary>
    /// IsoCodeDetails
    /// </summary>    
    public class IsoCodeDetails
    {

        /// <summary>
        /// Code
        /// </summary> 

        [AliasAs("code")]
        public string Code { get; set; }


        /// <summary>
        /// Name
        /// </summary> 

        [AliasAs("name")]
        public string Name { get; set; }

    }
}