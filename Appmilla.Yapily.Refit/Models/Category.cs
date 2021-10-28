using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Refit;

namespace Cms
{
    /// <summary>
    /// Category
    /// </summary>    
    public class Category
    {
        /// <summary>
        /// Category ID
        /// </summary>
        [AliasAs("id")]
        public string Id { get; set; }

        /// <summary>
        /// Category label
        /// </summary>
        [AliasAs("label")]
        public string Label { get; set; }

        /// <summary>
        /// Category country
        /// </summary>
        [AliasAs("country")]
        public string Country { get; set; }


        /// <summary>
        /// Subcategories
        /// </summary> 

        [AliasAs("subcategories")]
        public List<Subcategory> Subcategories { get; set; }

    }
}