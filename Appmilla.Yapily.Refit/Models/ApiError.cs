using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Refit;

namespace Cms
{
    /// <summary>
    /// ApiError
    /// </summary>    
    public class ApiError
    {

        /// <summary>
        /// Code
        /// </summary> 

        [AliasAs("code")]
        public int? Code { get; set; }


        /// <summary>
        /// InstitutionError
        /// </summary> 

        [AliasAs("institutionError")]
        public InstitutionError InstitutionError { get; set; }


        /// <summary>
        /// Message
        /// </summary> 

        [AliasAs("message")]
        public string Message { get; set; }


        /// <summary>
        /// Source
        /// </summary> 

        [AliasAs("source")]
        public string Source { get; set; }


        /// <summary>
        /// Status
        /// </summary> 

        [AliasAs("status")]
        public ApiErrorStatus? Status { get; set; }


        /// <summary>
        /// TracingId
        /// </summary> 

        [AliasAs("tracingId")]
        public string TracingId { get; set; }

    }
}