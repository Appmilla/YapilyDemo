using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Refit;

namespace Cms
{
    /// <summary>
    /// DeregistrationResult
    /// </summary>    
    public class DeregistrationResult
    {

        /// <summary>
        /// ApplicationId
        /// </summary> 

        [AliasAs("applicationId")]
        public string ApplicationId { get; set; }


        /// <summary>
        /// InstitutionId
        /// </summary> 

        [AliasAs("institutionId")]
        public string InstitutionId { get; set; }

    }
}