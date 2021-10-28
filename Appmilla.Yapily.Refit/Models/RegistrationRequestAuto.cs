using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Refit;

namespace Cms
{
    /// <summary>
    /// RegistrationRequestAuto
    /// </summary>    
    public class RegistrationRequestAuto
    {

        /// <summary>
        /// SoftwareId
        /// </summary> 

        [AliasAs("softwareId")]
        public string SoftwareId { get; set; }


        /// <summary>
        /// SigningCertificateId
        /// </summary> 

        [AliasAs("signingCertificateId")]
        public string SigningCertificateId { get; set; }


        /// <summary>
        /// TransportCertificateId
        /// </summary> 

        [AliasAs("transportCertificateId")]
        public string TransportCertificateId { get; set; }


        /// <summary>
        /// SsaJwt
        /// </summary> 

        [AliasAs("ssaJwt")]
        public string SsaJwt { get; set; }

    }
}