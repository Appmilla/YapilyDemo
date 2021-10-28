using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Refit;

namespace Cms
{
    /// <summary>
    /// SSAResult
    /// </summary>    
    public class SSAResult
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


        /// <summary>
        /// SsaJwt
        /// </summary> 

        [AliasAs("ssaJwt")]
        public string SsaJwt { get; set; }

    }
}