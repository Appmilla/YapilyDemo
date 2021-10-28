using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Refit;

namespace Cms
{
    /// <summary>
    /// InternationalPaymentRequest
    /// </summary>    
    public class InternationalPaymentRequest
    {

        /// <summary>
        /// CurrencyOfTransfer
        /// </summary> 
        [Required(AllowEmptyStrings = true)]

        [AliasAs("currencyOfTransfer")]
        public string CurrencyOfTransfer { get; set; }


        /// <summary>
        /// ExchangeRateInformation
        /// </summary> 

        [AliasAs("exchangeRateInformation")]
        public ExchangeRateInformation ExchangeRateInformation { get; set; }


        /// <summary>
        /// Purpose
        /// </summary> 

        [AliasAs("purpose")]
        public string Purpose { get; set; }


        /// <summary>
        /// Priority
        /// </summary> 

        [AliasAs("priority")]
        public InternationalPaymentRequestPriority? Priority { get; set; }


        /// <summary>
        /// ChargeBearer
        /// </summary> 

        [AliasAs("chargeBearer")]
        public InternationalPaymentRequestChargeBearer? ChargeBearer { get; set; }

    }
}