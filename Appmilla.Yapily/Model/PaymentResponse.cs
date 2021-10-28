using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Appmilla.Yapily.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class PaymentResponse {
    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }

    /// <summary>
    /// Gets or Sets InstitutionConsentId
    /// </summary>
    [DataMember(Name="institutionConsentId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "institutionConsentId")]
    public string InstitutionConsentId { get; set; }

    /// <summary>
    /// Gets or Sets PaymentIdempotencyId
    /// </summary>
    [DataMember(Name="paymentIdempotencyId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "paymentIdempotencyId")]
    public string PaymentIdempotencyId { get; set; }

    /// <summary>
    /// Gets or Sets PaymentLifecycleId
    /// </summary>
    [DataMember(Name="paymentLifecycleId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "paymentLifecycleId")]
    public string PaymentLifecycleId { get; set; }

    /// <summary>
    /// Gets or Sets Status
    /// </summary>
    [DataMember(Name="status", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "status")]
    public string Status { get; set; }

    /// <summary>
    /// Gets or Sets StatusDetails
    /// </summary>
    [DataMember(Name="statusDetails", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "statusDetails")]
    public PaymentStatusDetails StatusDetails { get; set; }

    /// <summary>
    /// Gets or Sets Payer
    /// </summary>
    [DataMember(Name="payer", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "payer")]
    public Payer Payer { get; set; }

    /// <summary>
    /// Gets or Sets PayeeDetails
    /// </summary>
    [DataMember(Name="payeeDetails", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "payeeDetails")]
    public Payee PayeeDetails { get; set; }

    /// <summary>
    /// Gets or Sets Reference
    /// </summary>
    [DataMember(Name="reference", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "reference")]
    public string Reference { get; set; }

    /// <summary>
    /// Gets or Sets Amount
    /// </summary>
    [DataMember(Name="amount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "amount")]
    public decimal? Amount { get; set; }

    /// <summary>
    /// Gets or Sets Currency
    /// </summary>
    [DataMember(Name="currency", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "currency")]
    public string Currency { get; set; }

    /// <summary>
    /// Gets or Sets AmountDetails
    /// </summary>
    [DataMember(Name="amountDetails", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "amountDetails")]
    public Amount AmountDetails { get; set; }

    /// <summary>
    /// Gets or Sets CreatedAt
    /// </summary>
    [DataMember(Name="createdAt", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "createdAt")]
    public DateTime? CreatedAt { get; set; }

    /// <summary>
    /// Gets or Sets FirstPaymentAmount
    /// </summary>
    [DataMember(Name="firstPaymentAmount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "firstPaymentAmount")]
    public Amount FirstPaymentAmount { get; set; }

    /// <summary>
    /// Gets or Sets FirstPaymentDateTime
    /// </summary>
    [DataMember(Name="firstPaymentDateTime", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "firstPaymentDateTime")]
    public DateTime? FirstPaymentDateTime { get; set; }

    /// <summary>
    /// Gets or Sets NextPaymentAmount
    /// </summary>
    [DataMember(Name="nextPaymentAmount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "nextPaymentAmount")]
    public Amount NextPaymentAmount { get; set; }

    /// <summary>
    /// Gets or Sets NextPaymentDateTime
    /// </summary>
    [DataMember(Name="nextPaymentDateTime", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "nextPaymentDateTime")]
    public DateTime? NextPaymentDateTime { get; set; }

    /// <summary>
    /// Gets or Sets FinalPaymentAmount
    /// </summary>
    [DataMember(Name="finalPaymentAmount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "finalPaymentAmount")]
    public Amount FinalPaymentAmount { get; set; }

    /// <summary>
    /// Gets or Sets FinalPaymentDateTime
    /// </summary>
    [DataMember(Name="finalPaymentDateTime", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "finalPaymentDateTime")]
    public DateTime? FinalPaymentDateTime { get; set; }

    /// <summary>
    /// Gets or Sets NumberOfPayments
    /// </summary>
    [DataMember(Name="numberOfPayments", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "numberOfPayments")]
    public int? NumberOfPayments { get; set; }

    /// <summary>
    /// Gets or Sets PreviousPaymentAmount
    /// </summary>
    [DataMember(Name="previousPaymentAmount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "previousPaymentAmount")]
    public Amount PreviousPaymentAmount { get; set; }

    /// <summary>
    /// Gets or Sets PreviousPaymentDateTime
    /// </summary>
    [DataMember(Name="previousPaymentDateTime", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "previousPaymentDateTime")]
    public DateTime? PreviousPaymentDateTime { get; set; }

    /// <summary>
    /// Gets or Sets ChargeDetails
    /// </summary>
    [DataMember(Name="chargeDetails", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "chargeDetails")]
    public List<ChargeDetails> ChargeDetails { get; set; }

    /// <summary>
    /// Gets or Sets ScheduledPaymentType
    /// </summary>
    [DataMember(Name="scheduledPaymentType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "scheduledPaymentType")]
    public string ScheduledPaymentType { get; set; }

    /// <summary>
    /// Gets or Sets ScheduledPaymentDateTime
    /// </summary>
    [DataMember(Name="scheduledPaymentDateTime", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "scheduledPaymentDateTime")]
    public DateTime? ScheduledPaymentDateTime { get; set; }

    /// <summary>
    /// Gets or Sets Frequency
    /// </summary>
    [DataMember(Name="frequency", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "frequency")]
    public FrequencyResponse Frequency { get; set; }

    /// <summary>
    /// Gets or Sets CurrencyOfTransfer
    /// </summary>
    [DataMember(Name="currencyOfTransfer", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "currencyOfTransfer")]
    public string CurrencyOfTransfer { get; set; }

    /// <summary>
    /// Gets or Sets Purpose
    /// </summary>
    [DataMember(Name="purpose", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "purpose")]
    public string Purpose { get; set; }

    /// <summary>
    /// Gets or Sets Priority
    /// </summary>
    [DataMember(Name="priority", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "priority")]
    public string Priority { get; set; }

    /// <summary>
    /// Gets or Sets ExchangeRate
    /// </summary>
    [DataMember(Name="exchangeRate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "exchangeRate")]
    public ExchangeRateInformationResponse ExchangeRate { get; set; }

    /// <summary>
    /// Gets or Sets RefundAccount
    /// </summary>
    [DataMember(Name="refundAccount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "refundAccount")]
    public RefundAccount RefundAccount { get; set; }

    /// <summary>
    /// Control sum for bulk payments
    /// </summary>
    /// <value>Control sum for bulk payments</value>
    [DataMember(Name="bulkAmountSum", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "bulkAmountSum")]
    public decimal? BulkAmountSum { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PaymentResponse {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  InstitutionConsentId: ").Append(InstitutionConsentId).Append("\n");
      sb.Append("  PaymentIdempotencyId: ").Append(PaymentIdempotencyId).Append("\n");
      sb.Append("  PaymentLifecycleId: ").Append(PaymentLifecycleId).Append("\n");
      sb.Append("  Status: ").Append(Status).Append("\n");
      sb.Append("  StatusDetails: ").Append(StatusDetails).Append("\n");
      sb.Append("  Payer: ").Append(Payer).Append("\n");
      sb.Append("  PayeeDetails: ").Append(PayeeDetails).Append("\n");
      sb.Append("  Reference: ").Append(Reference).Append("\n");
      sb.Append("  Amount: ").Append(Amount).Append("\n");
      sb.Append("  Currency: ").Append(Currency).Append("\n");
      sb.Append("  AmountDetails: ").Append(AmountDetails).Append("\n");
      sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
      sb.Append("  FirstPaymentAmount: ").Append(FirstPaymentAmount).Append("\n");
      sb.Append("  FirstPaymentDateTime: ").Append(FirstPaymentDateTime).Append("\n");
      sb.Append("  NextPaymentAmount: ").Append(NextPaymentAmount).Append("\n");
      sb.Append("  NextPaymentDateTime: ").Append(NextPaymentDateTime).Append("\n");
      sb.Append("  FinalPaymentAmount: ").Append(FinalPaymentAmount).Append("\n");
      sb.Append("  FinalPaymentDateTime: ").Append(FinalPaymentDateTime).Append("\n");
      sb.Append("  NumberOfPayments: ").Append(NumberOfPayments).Append("\n");
      sb.Append("  PreviousPaymentAmount: ").Append(PreviousPaymentAmount).Append("\n");
      sb.Append("  PreviousPaymentDateTime: ").Append(PreviousPaymentDateTime).Append("\n");
      sb.Append("  ChargeDetails: ").Append(ChargeDetails).Append("\n");
      sb.Append("  ScheduledPaymentType: ").Append(ScheduledPaymentType).Append("\n");
      sb.Append("  ScheduledPaymentDateTime: ").Append(ScheduledPaymentDateTime).Append("\n");
      sb.Append("  Frequency: ").Append(Frequency).Append("\n");
      sb.Append("  CurrencyOfTransfer: ").Append(CurrencyOfTransfer).Append("\n");
      sb.Append("  Purpose: ").Append(Purpose).Append("\n");
      sb.Append("  Priority: ").Append(Priority).Append("\n");
      sb.Append("  ExchangeRate: ").Append(ExchangeRate).Append("\n");
      sb.Append("  RefundAccount: ").Append(RefundAccount).Append("\n");
      sb.Append("  BulkAmountSum: ").Append(BulkAmountSum).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }

    /// <summary>
    /// Get the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public string ToJson() {
      return JsonConvert.SerializeObject(this, Formatting.Indented);
    }

}
}
