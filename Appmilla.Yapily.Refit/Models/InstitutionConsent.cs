using Refit;

namespace Appmilla.Yapily.Refit.Models
{
    /// <summary>
    /// InstitutionConsent
    /// </summary>    
    public class InstitutionConsent
    {

        /// <summary>
        /// InstitutionId
        /// </summary> 

        [AliasAs("institutionId")]
        public string InstitutionId { get; set; }

    }
}