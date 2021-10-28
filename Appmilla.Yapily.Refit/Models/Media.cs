using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Refit;

namespace Cms
{
    /// <summary>
    /// Contains links to the logo and the icons for the `Institution`    /// </summary>    
    public class Media
    {

        /// <summary>
        /// Source
        /// </summary> 

        [AliasAs("source")]
        public string Source { get; set; }


        /// <summary>
        /// Type
        /// </summary> 

        [AliasAs("type")]
        public string Type { get; set; }

    }
}