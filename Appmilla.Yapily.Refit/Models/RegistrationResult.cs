using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Refit;

namespace Cms
{
    /// <summary>
    /// RegistrationResult
    /// </summary>    
    public class RegistrationResult
    {

        /// <summary>
        /// ApplicationId
        /// </summary> 

        [AliasAs("applicationId")]
        public string ApplicationId { get; set; }


        /// <summary>
        /// InstitutionId
        /// </summary> 

        [AliasAs("institutionId")]
        public string InstitutionId { get; set; }


        /// <summary>
        /// TppId
        /// </summary> 

        [AliasAs("tppId")]
        public string TppId { get; set; }


        /// <summary>
        /// SoftwareId
        /// </summary> 

        [AliasAs("softwareId")]
        public string SoftwareId { get; set; }


        /// <summary>
        /// ClientName
        /// </summary> 

        [AliasAs("clientName")]
        public string ClientName { get; set; }


        /// <summary>
        /// SigningKeyId
        /// </summary> 

        [AliasAs("signingKeyId")]
        public string SigningKeyId { get; set; }


        /// <summary>
        /// SigningCertificateId
        /// </summary> 

        [AliasAs("signingCertificateId")]
        public string SigningCertificateId { get; set; }


        /// <summary>
        /// TransportKeyId
        /// </summary> 

        [AliasAs("transportKeyId")]
        public string TransportKeyId { get; set; }


        /// <summary>
        /// TransportCertificateId
        /// </summary> 

        [AliasAs("transportCertificateId")]
        public string TransportCertificateId { get; set; }


        /// <summary>
        /// ClientUri
        /// </summary> 

        [AliasAs("clientUri")]
        public string ClientUri { get; set; }


        /// <summary>
        /// TermsOfServiceUri
        /// </summary> 

        [AliasAs("termsOfServiceUri")]
        public string TermsOfServiceUri { get; set; }


        /// <summary>
        /// SsaJwt
        /// </summary> 

        [AliasAs("ssaJwt")]
        public string SsaJwt { get; set; }


        /// <summary>
        /// ClientId
        /// </summary> 

        [AliasAs("clientId")]
        public string ClientId { get; set; }


        /// <summary>
        /// ClientSecret
        /// </summary> 

        [AliasAs("clientSecret")]
        public string ClientSecret { get; set; }


        /// <summary>
        /// SigningKeyStore
        /// </summary> 

        [AliasAs("signingKeyStore")]
        public string SigningKeyStore { get; set; }


        /// <summary>
        /// TransportKeyStore
        /// </summary> 

        [AliasAs("transportKeyStore")]
        public string TransportKeyStore { get; set; }


        /// <summary>
        /// RegistrationResponse
        /// </summary> 

        [AliasAs("registrationResponse")]
        public string RegistrationResponse { get; set; }

    }
}