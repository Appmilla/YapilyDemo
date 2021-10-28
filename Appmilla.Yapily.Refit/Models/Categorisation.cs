using System.Collections.Generic;
using Refit;

namespace Appmilla.Yapily.Refit.Models
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