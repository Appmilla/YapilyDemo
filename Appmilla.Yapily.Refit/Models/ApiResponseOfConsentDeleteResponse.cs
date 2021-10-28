using Refit;

namespace Appmilla.Yapily.Refit.Models
{
    /// <summary>
    /// ApiResponseOfConsentDeleteResponse
    /// </summary>    
    public class ApiResponseOfConsentDeleteResponse
    {

        /// <summary>
        /// Meta
        /// </summary> 

        [AliasAs("meta")]
        public ResponseMeta Meta { get; set; }


        /// <summary>
        /// Data
        /// </summary> 

        [AliasAs("data")]
        public ConsentDeleteResponse Data { get; set; }


        /// <summary>
        /// Links
        /// </summary> 

        [AliasAs("links")]
        public System.Collections.Generic.IDictionary<string, string> Links { get; set; }

    }
}