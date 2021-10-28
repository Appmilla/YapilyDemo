using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Refit;

namespace Cms
{
    /// <summary>
    /// InstitutionError
    /// </summary>    
    public class InstitutionError
    {

        /// <summary>
        /// ErrorMessage
        /// </summary> 

        [AliasAs("errorMessage")]
        public string ErrorMessage { get; set; }


        /// <summary>
        /// HttpStatusCode
        /// </summary> 

        [AliasAs("httpStatusCode")]
        public int? HttpStatusCode { get; set; }

    }
}