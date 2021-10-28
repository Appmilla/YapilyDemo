using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Refit;

namespace Cms
{
    /// <summary>
    /// PaymentResponse
    /// </summary>    
    public class PaymentResponse
    {

        /// <summary>
        /// Id
        /// </summary> 

        [AliasAs("id")]
        public string Id { get; set; }


        /// <summary>
        /// InstitutionConsentId
        /// </summary> 

        [AliasAs("institutionConsentId")]
        public string InstitutionConsentId { get; set; }


        /// <summary>
        /// PaymentIdempotencyId
        /// </summary> 

        [AliasAs("paymentIdempotencyId")]
        public string PaymentIdempotencyId { get; set; }


        /// <summary>
        /// PaymentLifecycleId
        /// </summary> 

        [AliasAs("paymentLifecycleId")]
        public string PaymentLifecycleId { get; set; }


        /// <summary>
        /// Status
        /// </summary> 

        [AliasAs("status")]
        public PaymentResponseStatus? Status { get; set; }


        /// <summary>
        /// StatusDetails
        /// </summary> 

        [AliasAs("statusDetails")]
        public PaymentStatusDetails StatusDetails { get; set; }


        /// <summary>
        /// Payer
        /// </summary> 

        [AliasAs("payer")]
        public Payer Payer { get; set; }


        /// <summary>
        /// PayeeDetails
        /// </summary> 

        [AliasAs("payeeDetails")]
        public Payee PayeeDetails { get; set; }


        /// <summary>
        /// Reference
        /// </summary> 

        [AliasAs("reference")]
        public string Reference { get; set; }


        /// <summary>
        /// Amount
        /// </summary> 

        [AliasAs("amount")]
        public double? Amount { get; set; }


        /// <summary>
        /// Currency
        /// </summary> 

        [AliasAs("currency")]
        public string Currency { get; set; }


        /// <summary>
        /// AmountDetails
        /// </summary> 

        [AliasAs("amountDetails")]
        public Amount AmountDetails { get; set; }


        /// <summary>
        /// CreatedAt
        /// </summary> 

        [AliasAs("createdAt")]
        public System.DateTimeOffset? CreatedAt { get; set; }


        /// <summary>
        /// FirstPaymentAmount
        /// </summary> 

        [AliasAs("firstPaymentAmount")]
        public Amount FirstPaymentAmount { get; set; }


        /// <summary>
        /// FirstPaymentDateTime
        /// </summary> 

        [AliasAs("firstPaymentDateTime")]
        public System.DateTimeOffset? FirstPaymentDateTime { get; set; }


        /// <summary>
        /// NextPaymentAmount
        /// </summary> 

        [AliasAs("nextPaymentAmount")]
        public Amount NextPaymentAmount { get; set; }


        /// <summary>
        /// NextPaymentDateTime
        /// </summary> 

        [AliasAs("nextPaymentDateTime")]
        public System.DateTimeOffset? NextPaymentDateTime { get; set; }


        /// <summary>
        /// FinalPaymentAmount
        /// </summary> 

        [AliasAs("finalPaymentAmount")]
        public Amount FinalPaymentAmount { get; set; }


        /// <summary>
        /// FinalPaymentDateTime
        /// </summary> 

        [AliasAs("finalPaymentDateTime")]
        public System.DateTimeOffset? FinalPaymentDateTime { get; set; }


        /// <summary>
        /// NumberOfPayments
        /// </summary> 

        [AliasAs("numberOfPayments")]
        public int? NumberOfPayments { get; set; }


        /// <summary>
        /// PreviousPaymentAmount
        /// </summary> 

        [AliasAs("previousPaymentAmount")]
        public Amount PreviousPaymentAmount { get; set; }


        /// <summary>
        /// PreviousPaymentDateTime
        /// </summary> 

        [AliasAs("previousPaymentDateTime")]
        public System.DateTimeOffset? PreviousPaymentDateTime { get; set; }


        /// <summary>
        /// ChargeDetails
        /// </summary> 

        [AliasAs("chargeDetails")]
        public List<ChargeDetails> ChargeDetails { get; set; }


        /// <summary>
        /// ScheduledPaymentType
        /// </summary> 

        [AliasAs("scheduledPaymentType")]
        public string ScheduledPaymentType { get; set; }


        /// <summary>
        /// ScheduledPaymentDateTime
        /// </summary> 

        [AliasAs("scheduledPaymentDateTime")]
        public System.DateTimeOffset? ScheduledPaymentDateTime { get; set; }


        /// <summary>
        /// Frequency
        /// </summary> 

        [AliasAs("frequency")]
        public FrequencyResponse Frequency { get; set; }


        /// <summary>
        /// CurrencyOfTransfer
        /// </summary> 

        [AliasAs("currencyOfTransfer")]
        public string CurrencyOfTransfer { get; set; }


        /// <summary>
        /// Purpose
        /// </summary> 

        [AliasAs("purpose")]
        public string Purpose { get; set; }


        /// <summary>
        /// Priority
        /// </summary> 

        [AliasAs("priority")]
        public PaymentResponsePriority? Priority { get; set; }


        /// <summary>
        /// ExchangeRate
        /// </summary> 

        [AliasAs("exchangeRate")]
        public ExchangeRateInformationResponse ExchangeRate { get; set; }


        /// <summary>
        /// RefundAccount
        /// </summary> 

        [AliasAs("refundAccount")]
        public RefundAccount RefundAccount { get; set; }

        /// <summary>
        /// Control sum for bulk payments
        /// </summary>
        [AliasAs("bulkAmountSum")]
        public double? BulkAmountSum { get; set; }

    }
}