using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Refit;

namespace Cms
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