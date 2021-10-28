using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Refit;

namespace Cms
{
    /// <summary>
    /// Subcategory
    /// </summary>    
    public class Subcategory
    {
        /// <summary>
        /// Subcategory ID
        /// </summary>
        [AliasAs("id")]
        public string Id { get; set; }

        /// <summary>
        /// Subcategory label
        /// </summary>
        [AliasAs("label")]
        public string Label { get; set; }

    }
}