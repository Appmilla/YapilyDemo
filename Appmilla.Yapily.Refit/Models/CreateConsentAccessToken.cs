using System.ComponentModel.DataAnnotations;
using Refit;

namespace Appmilla.Yapily.Refit.Models
{
    /// <summary>
    /// CreateConsentAccessToken
    /// </summary>    
    public class CreateConsentAccessToken
    {

        /// <summary>
        /// AccessToken
        /// </summary> 
        [Required(AllowEmptyStrings = true)]
        [AliasAs("accessToken")]
        public string AccessToken { get; set; }


        /// <summary>
        /// RefreshToken
        /// </summary> 

        [AliasAs("refreshToken")]
        public string RefreshToken { get; set; }


        /// <summary>
        /// InstitutionId
        /// </summary> 
        [Required(AllowEmptyStrings = true)]
        [AliasAs("institutionId")]
        public string InstitutionId { get; set; }


        /// <summary>
        /// Scope
        /// </summary> 

        [AliasAs("scope")]
        public string Scope { get; set; }

    }
}