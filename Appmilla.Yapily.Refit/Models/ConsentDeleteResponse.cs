using Refit;

namespace Appmilla.Yapily.Refit.Models
{
    /// <summary>
    /// ConsentDeleteResponse
    /// </summary>    
    public class ConsentDeleteResponse
    {

        /// <summary>
        /// Id
        /// </summary> 

        [AliasAs("id")]
        public string Id { get; set; }


        /// <summary>
        /// DeleteStatus
        /// </summary> 

        [AliasAs("deleteStatus")]
        public ConsentDeleteResponseDeleteStatus? DeleteStatus { get; set; }


        /// <summary>
        /// InstitutionId
        /// </summary> 

        [AliasAs("institutionId")]
        public string InstitutionId { get; set; }


        /// <summary>
        /// InstitutionConsentId
        /// </summary> 

        [AliasAs("institutionConsentId")]
        public string InstitutionConsentId { get; set; }


        /// <summary>
        /// CreationDate
        /// </summary> 

        [AliasAs("creationDate")]
        public System.DateTimeOffset? CreationDate { get; set; }

    }
}