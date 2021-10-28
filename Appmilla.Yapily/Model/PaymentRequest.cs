using System;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Appmilla.Yapily.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class PaymentRequest {
    /// <summary>
    /// Gets or Sets PaymentIdempotencyId
    /// </summary>
    [DataMember(Name="paymentIdempotencyId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "paymentIdempotencyId")]
    public string PaymentIdempotencyId { get; set; }

    /// <summary>
    /// Gets or Sets Payer
    /// </summary>
    [DataMember(Name="payer", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "payer")]
    public Payer Payer { get; set; }

    /// <summary>
    /// Gets or Sets Amount
    /// </summary>
    [DataMember(Name="amount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "amount")]
    public Amount Amount { get; set; }

    /// <summary>
    /// Gets or Sets Reference
    /// </summary>
    [DataMember(Name="reference", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "reference")]
    public string Reference { get; set; }

    /// <summary>
    /// Gets or Sets ContextType
    /// </summary>
    [DataMember(Name="contextType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "contextType")]
    public string ContextType { get; set; }

    /// <summary>
    /// Gets or Sets Type
    /// </summary>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }

    /// <summary>
    /// Gets or Sets PaymentDateTime
    /// </summary>
    [DataMember(Name="paymentDateTime", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "paymentDateTime")]
    public DateTime? PaymentDateTime { get; set; }

    /// <summary>
    /// Gets or Sets Payee
    /// </summary>
    [DataMember(Name="payee", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "payee")]
    public Payee Payee { get; set; }

    /// <summary>
    /// Gets or Sets PeriodicPayment
    /// </summary>
    [DataMember(Name="periodicPayment", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "periodicPayment")]
    public PeriodicPaymentRequest PeriodicPayment { get; set; }

    /// <summary>
    /// Gets or Sets InternationalPayment
    /// </summary>
    [DataMember(Name="internationalPayment", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "internationalPayment")]
    public InternationalPaymentRequest InternationalPayment { get; set; }

    /// <summary>
    /// Gets or Sets ReadRefundAccount
    /// </summary>
    [DataMember(Name="readRefundAccount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "readRefundAccount")]
    public bool? ReadRefundAccount { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PaymentRequest {\n");
      sb.Append("  PaymentIdempotencyId: ").Append(PaymentIdempotencyId).Append("\n");
      sb.Append("  Payer: ").Append(Payer).Append("\n");
      sb.Append("  Amount: ").Append(Amount).Append("\n");
      sb.Append("  Reference: ").Append(Reference).Append("\n");
      sb.Append("  ContextType: ").Append(ContextType).Append("\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
      sb.Append("  PaymentDateTime: ").Append(PaymentDateTime).Append("\n");
      sb.Append("  Payee: ").Append(Payee).Append("\n");
      sb.Append("  PeriodicPayment: ").Append(PeriodicPayment).Append("\n");
      sb.Append("  InternationalPayment: ").Append(InternationalPayment).Append("\n");
      sb.Append("  ReadRefundAccount: ").Append(ReadRefundAccount).Append("\n");
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
