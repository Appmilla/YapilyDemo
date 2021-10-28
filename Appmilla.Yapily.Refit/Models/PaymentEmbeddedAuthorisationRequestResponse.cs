using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Refit;

namespace Cms
{
    /// <summary>
    /// PaymentEmbeddedAuthorisationRequestResponse
    /// </summary>    
    public class PaymentEmbeddedAuthorisationRequestResponse
    {

        /// <summary>
        /// Id
        /// </summary> 

        [AliasAs("id")]
        public string Id { get; set; }


        /// <summary>
        /// UserUuid
        /// </summary> 

        [AliasAs("userUuid")]
        public string UserUuid { get; set; }


        /// <summary>
        /// ApplicationUserId
        /// </summary> 

        [AliasAs("applicationUserId")]
        public string ApplicationUserId { get; set; }


        /// <summary>
        /// ReferenceId
        /// </summary> 

        [AliasAs("referenceId")]
        public string ReferenceId { get; set; }


        /// <summary>
        /// InstitutionId
        /// </summary> 

        [AliasAs("institutionId")]
        public string InstitutionId { get; set; }


        /// <summary>
        /// Status
        /// </summary> 

        [AliasAs("status")]
        public PaymentEmbeddedAuthorisationRequestResponseStatus? Status { get; set; }


        /// <summary>
        /// CreatedAt
        /// </summary> 

        [AliasAs("createdAt")]
        public System.DateTimeOffset? CreatedAt { get; set; }


        /// <summary>
        /// TransactionFrom
        /// </summary> 

        [AliasAs("transactionFrom")]
        public System.DateTimeOffset? TransactionFrom { get; set; }


        /// <summary>
        /// TransactionTo
        /// </summary> 

        [AliasAs("transactionTo")]
        public System.DateTimeOffset? TransactionTo { get; set; }


        /// <summary>
        /// ExpiresAt
        /// </summary> 

        [AliasAs("expiresAt")]
        public System.DateTimeOffset? ExpiresAt { get; set; }

        /// <summary>
        /// Deprecated. Use `timeToExpire` instead.
        /// </summary>
        [AliasAs("timeToExpireInMillis")]
        public long? TimeToExpireInMillis { get; set; }

        /// <summary>
        /// ISO 8601 duration
        /// </summary>
        [AliasAs("timeToExpire")]
        public string TimeToExpire { get; set; }


        /// <summary>
        /// FeatureScope
        /// </summary> 

        [AliasAs("featureScope")]
        public List<FeatureScope6> FeatureScope { get; set; }


        /// <summary>
        /// Charges
        /// </summary> 

        [AliasAs("charges")]
        public List<ChargeDetails> Charges { get; set; }


        /// <summary>
        /// ExchangeRateInformation
        /// </summary> 

        [AliasAs("exchangeRateInformation")]
        public ExchangeRateInformationResponse ExchangeRateInformation { get; set; }


        /// <summary>
        /// ConsentToken
        /// </summary> 

        [AliasAs("consentToken")]
        public string ConsentToken { get; set; }


        /// <summary>
        /// AuthorisationUrl
        /// </summary> 

        [AliasAs("authorisationUrl")]
        public string AuthorisationUrl { get; set; }


        /// <summary>
        /// State
        /// </summary> 

        [AliasAs("state")]
        public string State { get; set; }


        /// <summary>
        /// QrCodeUrl
        /// </summary> 

        [AliasAs("qrCodeUrl")]
        public string QrCodeUrl { get; set; }


        /// <summary>
        /// AuthorizedAt
        /// </summary> 

        [AliasAs("authorizedAt")]
        public System.DateTimeOffset? AuthorizedAt { get; set; }


        /// <summary>
        /// Explanation
        /// </summary> 

        [AliasAs("explanation")]
        public string Explanation { get; set; }


        /// <summary>
        /// ScaMethods
        /// </summary> 

        [AliasAs("scaMethods")]
        public List<ScaMethod> ScaMethods { get; set; }


        /// <summary>
        /// InstitutionConsentId
        /// </summary> 

        [AliasAs("institutionConsentId")]
        public string InstitutionConsentId { get; set; }


        /// <summary>
        /// SelectedScaMethod
        /// </summary> 

        [AliasAs("selectedScaMethod")]
        public ScaMethod SelectedScaMethod { get; set; }

    }
}