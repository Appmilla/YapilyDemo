using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Refit;

namespace Cms
{
    /// <summary>
    /// BulkPaymentEmbeddedAuthorisationRequest
    /// </summary>    
    public class BulkPaymentEmbeddedAuthorisationRequest
    {

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
        /// ForwardParameters
        /// </summary> 

        [AliasAs("forwardParameters")]
        public List<string> ForwardParameters { get; set; }


        /// <summary>
        /// InstitutionId
        /// </summary> 
        [Required(AllowEmptyStrings = true)]

        [AliasAs("institutionId")]
        public string InstitutionId { get; set; }


        /// <summary>
        /// Callback
        /// </summary> 
        [Required(AllowEmptyStrings = true)]

        [AliasAs("callback")]
        public string Callback { get; set; }


        /// <summary>
        /// OneTimeToken
        /// </summary> 

        [AliasAs("oneTimeToken")]
        public bool OneTimeToken { get; set; }


        /// <summary>
        /// Redirect
        /// </summary> 

        [AliasAs("redirect")]
        public RedirectRequest Redirect { get; set; }


        /// <summary>
        /// PaymentRequest
        /// </summary> 
        [Required]

        [AliasAs("paymentRequest")]
        public BulkPaymentRequest PaymentRequest { get; set; } = new BulkPaymentRequest();


        /// <summary>
        /// UserCredentials
        /// </summary> 

        [AliasAs("userCredentials")]
        public UserCredentials UserCredentials { get; set; }


        /// <summary>
        /// SelectedScaMethod
        /// </summary> 

        [AliasAs("selectedScaMethod")]
        public ScaMethod SelectedScaMethod { get; set; }


        /// <summary>
        /// ScaCode
        /// </summary> 

        [AliasAs("scaCode")]
        public string ScaCode { get; set; }

    }
}