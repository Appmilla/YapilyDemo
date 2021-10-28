using Refit;

namespace Appmilla.Yapily.Refit.Models
{
    /// <summary>
    /// FeatureDetails
    /// </summary>    
    public class FeatureDetails
    {

        /// <summary>
        /// Feature
        /// </summary> 

        [AliasAs("feature")]
        public FeatureDetailsFeature? Feature { get; set; }


        /// <summary>
        /// Endpoint
        /// </summary> 

        [AliasAs("endpoint")]
        public string Endpoint { get; set; }


        /// <summary>
        /// DocumentationUrl
        /// </summary> 

        [AliasAs("documentationUrl")]
        public string DocumentationUrl { get; set; }

    }
}