using Refit;

namespace Appmilla.Yapily.Refit.Models
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