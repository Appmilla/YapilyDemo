using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Refit;

namespace Cms
{
    /// <summary>
    /// Categorisation
    /// </summary>    
    public class Categorisation
    {
        /// <summary>
        /// Categories
        /// </summary>
        [AliasAs("categories")]
        public List<string> Categories { get; set; }

        /// <summary>
        /// Source
        /// </summary>
        [AliasAs("source")]
        public string Source { get; set; }

    }
}