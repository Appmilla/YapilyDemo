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
  public class BulkPaymentRequest {
    /// <summary>
    /// Execution datetime for the bulk payments
    /// </summary>
    /// <value>Execution datetime for the bulk payments</value>
    [DataMember(Name="executionDateTime", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "executionDateTime")]
    public DateTime? ExecutionDateTime { get; set; }

    /// <summary>
    /// Required field for AIB bulk payments
    /// </summary>
    /// <value>Required field for AIB bulk payments</value>
    [DataMember(Name="originatorIdentificationNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "originatorIdentificationNumber")]
    public string OriginatorIdentificationNumber { get; set; }

    /// <summary>
    /// Gets or Sets Payments
    /// </summary>
    [DataMember(Name="payments", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "payments")]
    public List<PaymentRequest> Payments { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class BulkPaymentRequest {\n");
      sb.Append("  ExecutionDateTime: ").Append(ExecutionDateTime).Append("\n");
      sb.Append("  OriginatorIdentificationNumber: ").Append(OriginatorIdentificationNumber).Append("\n");
      sb.Append("  Payments: ").Append(Payments).Append("\n");
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
