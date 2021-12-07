using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Refit;

namespace Appmilla.Yapily.Refit.Models
{
    /// <summary>
    /// PreAuthorisationRequest
    /// </summary>    
    public class PreAuthorisationRequest
    {
        /// <summary>
        /// Defines the scope of the pre-authorisation request.
        /// </summary>
        [Required(AllowEmptyStrings = true)]
        [AliasAs("scope")]
        public string Scope { get; set; }

        /// <summary>
        /// Uuid of the application user who will authorise access to their data. Either the userUuid or applicationUserId must be provided.
        /// </summary>
        [AliasAs("userUuid")]
        public string UserUuid { get; set; }

        /// <summary>
        /// Descriptive identifier for the application user.Either the userUuid or applicationUserId must be provided.
        /// </summary>
        [AliasAs("applicationUserId")]
        public string ApplicationUserId { get; set; }


        /// <summary>
        /// ForwardParameters
        /// </summary> 

        [AliasAs("forwardParameters")]
        public List<string> ForwardParameters { get; set; }


        /// <summary>
        /// InstitutionId
        /// </summary> 
        [Required(AllowEmptyStrings = true)]
        [AliasAs("institutionId")]
        public string InstitutionId { get; set; }


        /// <summary>
        /// Callback
        /// </summary> 
        [Required(AllowEmptyStrings = true)]
        [AliasAs("callback")]
        public string Callback { get; set; }


        /// <summary>
        /// Redirect
        /// </summary> 

        [AliasAs("redirect")]
        public RedirectRequest Redirect { get; set; }


        /// <summary>
        /// OneTimeToken
        /// </summary> 

        [AliasAs("oneTimeToken")]
        public bool OneTimeToken { get; set; }

    }
}