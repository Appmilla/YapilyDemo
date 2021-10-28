using Refit;

namespace Appmilla.Yapily.Refit.Models
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