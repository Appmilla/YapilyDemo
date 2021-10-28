using Refit;

namespace Appmilla.Yapily.Refit.Models
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