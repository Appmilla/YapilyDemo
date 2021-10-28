using Refit;

namespace Appmilla.Yapily.Refit.Models
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