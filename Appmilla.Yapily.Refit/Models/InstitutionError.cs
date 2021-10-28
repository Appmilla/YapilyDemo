using Refit;

namespace Appmilla.Yapily.Refit.Models
{
    /// <summary>
    /// InstitutionError
    /// </summary>    
    public class InstitutionError
    {

        /// <summary>
        /// ErrorMessage
        /// </summary> 

        [AliasAs("errorMessage")]
        public string ErrorMessage { get; set; }


        /// <summary>
        /// HttpStatusCode
        /// </summary> 

        [AliasAs("httpStatusCode")]
        public int? HttpStatusCode { get; set; }

    }
}