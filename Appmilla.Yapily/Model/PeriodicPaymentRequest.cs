using System;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Appmilla.Yapily.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class PeriodicPaymentRequest {
    /// <summary>
    /// Gets or Sets Frequency
    /// </summary>
    [DataMember(Name="frequency", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "frequency")]
    public FrequencyRequest Frequency { get; set; }

    /// <summary>
    /// Gets or Sets NumberOfPayments
    /// </summary>
    [DataMember(Name="numberOfPayments", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "numberOfPayments")]
    public int? NumberOfPayments { get; set; }

    /// <summary>
    /// Gets or Sets NextPaymentDateTime
    /// </summary>
    [DataMember(Name="nextPaymentDateTime", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "nextPaymentDateTime")]
    public DateTime? NextPaymentDateTime { get; set; }

    /// <summary>
    /// Gets or Sets NextPaymentAmount
    /// </summary>
    [DataMember(Name="nextPaymentAmount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "nextPaymentAmount")]
    public Amount NextPaymentAmount { get; set; }

    /// <summary>
    /// Gets or Sets FinalPaymentDateTime
    /// </summary>
    [DataMember(Name="finalPaymentDateTime", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "finalPaymentDateTime")]
    public DateTime? FinalPaymentDateTime { get; set; }

    /// <summary>
    /// Gets or Sets FinalPaymentAmount
    /// </summary>
    [DataMember(Name="finalPaymentAmount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "finalPaymentAmount")]
    public Amount FinalPaymentAmount { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PeriodicPaymentRequest {\n");
      sb.Append("  Frequency: ").Append(Frequency).Append("\n");
      sb.Append("  NumberOfPayments: ").Append(NumberOfPayments).Append("\n");
      sb.Append("  NextPaymentDateTime: ").Append(NextPaymentDateTime).Append("\n");
      sb.Append("  NextPaymentAmount: ").Append(NextPaymentAmount).Append("\n");
      sb.Append("  FinalPaymentDateTime: ").Append(FinalPaymentDateTime).Append("\n");
      sb.Append("  FinalPaymentAmount: ").Append(FinalPaymentAmount).Append("\n");
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
