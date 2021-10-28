using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Refit;

namespace Cms
{
    /// <summary>
    /// ResponseMeta
    /// </summary>    
    public class ResponseMeta
    {

        /// <summary>
        /// TracingId
        /// </summary> 

        [AliasAs("tracingId")]
        public string TracingId { get; set; }

    }
}