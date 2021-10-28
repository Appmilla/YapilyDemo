using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Refit;

namespace Cms
{
    /// <summary>
    /// Institution
    /// </summary>    
    public class Institution
    {
        /// <summary>
        /// An array of `Country` denoting which regions the `Institution` provides coverage for
        /// </summary>
        [AliasAs("countries")]
        public List<Country> Countries { get; set; }


        /// <summary>
        /// CredentialsType
        /// </summary> 

        [AliasAs("credentialsType")]
        public InstitutionCredentialsType? CredentialsType { get; set; }


        /// <summary>
        /// EnvironmentType
        /// </summary> 

        [AliasAs("environmentType")]
        public InstitutionEnvironmentType? EnvironmentType { get; set; }


        /// <summary>
        /// Features
        /// </summary> 

        [AliasAs("features")]
        public List<Features> Features { get; set; }

        /// <summary>
        /// The full name of the `Institution`
        /// </summary>
        [AliasAs("fullName")]
        public string FullName { get; set; }

        /// <summary>
        /// The Yapily Id for the `Institution`
        /// </summary>
        [AliasAs("id")]
        public string Id { get; set; }

        /// <summary>
        /// Contains links to the logo and the icons for the `Institution`
        /// </summary>
        [AliasAs("media")]
        public List<Media> Media { get; set; }


        /// <summary>
        /// Monitoring
        /// </summary> 

        [AliasAs("monitoring")]
        public System.Collections.Generic.IDictionary<string, MonitoringFeatureStatus> Monitoring { get; set; }

        /// <summary>
        /// The friendly name of the `Institution`
        /// </summary>
        [AliasAs("name")]
        public string Name { get; set; }

    }
}