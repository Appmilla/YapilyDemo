using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Refit;

namespace Cms
{
    /// <summary>
    /// ApiListResponseOfTransaction
    /// </summary>    
    public class ApiListResponseOfTransaction
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
        public List<Transaction> Data { get; set; }


        /// <summary>
        /// Links
        /// </summary> 

        [AliasAs("links")]
        public System.Collections.Generic.IDictionary<string, string> Links { get; set; }

    }
}