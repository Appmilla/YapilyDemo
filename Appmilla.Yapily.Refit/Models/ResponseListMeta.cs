using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Refit;

namespace Cms
{
    /// <summary>
    /// ResponseListMeta
    /// </summary>    
    public class ResponseListMeta
    {

        /// <summary>
        /// TracingId
        /// </summary> 

        [AliasAs("tracingId")]
        public string TracingId { get; set; }


        /// <summary>
        /// Count
        /// </summary> 

        [AliasAs("count")]
        public int? Count { get; set; }


        /// <summary>
        /// Pagination
        /// </summary> 

        [AliasAs("pagination")]
        public Pagination Pagination { get; set; }

    }
}