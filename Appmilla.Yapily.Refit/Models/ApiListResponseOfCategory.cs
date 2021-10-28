using System.Collections.Generic;
using Refit;

namespace Appmilla.Yapily.Refit.Models
{
    /// <summary>
    /// ApiListResponseOfCategory
    /// </summary>    
    public class ApiListResponseOfCategory
    {

        /// <summary>
        /// Meta
        /// </summary> 

        [AliasAs("meta")]
        public ResponseListMeta Meta { get; set; }


        /// <summary>
        /// Data
        /// </summary> 

        [AliasAs("data")]
        public List<Category> Data { get; set; }


        /// <summary>
        /// Links
        /// </summary> 

        [AliasAs("links")]
        public System.Collections.Generic.IDictionary<string, string> Links { get; set; }

    }
}