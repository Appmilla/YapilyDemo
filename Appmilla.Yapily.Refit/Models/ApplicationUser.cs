using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Refit;

namespace Cms
{
    /// <summary>
    /// ApplicationUser
    /// </summary>    
    public class ApplicationUser
    {
        /// <summary>
        /// User UUID
        /// </summary>
        [AliasAs("uuid")]
        public string Uuid { get; set; }


        /// <summary>
        /// ApplicationUuid
        /// </summary> 

        [AliasAs("applicationUuid")]
        public string ApplicationUuid { get; set; }


        /// <summary>
        /// ApplicationUserId
        /// </summary> 

        [AliasAs("applicationUserId")]
        public string ApplicationUserId { get; set; }


        /// <summary>
        /// ReferenceId
        /// </summary> 

        [AliasAs("referenceId")]
        public string ReferenceId { get; set; }


        /// <summary>
        /// InstitutionConsents
        /// </summary> 

        [AliasAs("institutionConsents")]
        public List<InstitutionConsent> InstitutionConsents { get; set; }

    }
}