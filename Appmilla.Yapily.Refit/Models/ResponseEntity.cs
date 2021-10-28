using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Refit;

namespace Cms
{
    /// <summary>
    /// ResponseEntity
    /// </summary>    
    public class ResponseEntity
    {

        /// <summary>
        /// Body
        /// </summary> 

        [AliasAs("body")]
        public object Body { get; set; }


        /// <summary>
        /// StatusCode
        /// </summary> 

        [AliasAs("statusCode")]
        public ResponseEntityStatusCode? StatusCode { get; set; }


        /// <summary>
        /// StatusCodeValue
        /// </summary> 

        [AliasAs("statusCodeValue")]
        public int? StatusCodeValue { get; set; }

    }
}