using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Refit;

namespace Cms
{
    /// <summary>
    /// MultiAuthorisation
    /// </summary>    
    public class MultiAuthorisation
    {

        /// <summary>
        /// Status
        /// </summary> 

        [AliasAs("status")]
        public string Status { get; set; }


        /// <summary>
        /// NumberOfAuthorisationRequired
        /// </summary> 

        [AliasAs("numberOfAuthorisationRequired")]
        public int? NumberOfAuthorisationRequired { get; set; }


        /// <summary>
        /// NumberOfAuthorisationReceived
        /// </summary> 

        [AliasAs("numberOfAuthorisationReceived")]
        public int? NumberOfAuthorisationReceived { get; set; }


        /// <summary>
        /// LastUpdatedDateTime
        /// </summary> 

        [AliasAs("lastUpdatedDateTime")]
        public System.DateTimeOffset? LastUpdatedDateTime { get; set; }


        /// <summary>
        /// ExpirationDateTime
        /// </summary> 

        [AliasAs("expirationDateTime")]
        public System.DateTimeOffset? ExpirationDateTime { get; set; }

    }
}