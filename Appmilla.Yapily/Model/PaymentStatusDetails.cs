using System;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Appmilla.Yapily.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class PaymentStatusDetails {
    /// <summary>
    /// Gets or Sets Status
    /// </summary>
    [DataMember(Name="status", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "status")]
    public string Status { get; set; }

    /// <summary>
    /// Gets or Sets StatusReason
    /// </summary>
    [DataMember(Name="statusReason", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "statusReason")]
    public string StatusReason { get; set; }

    /// <summary>
    /// Gets or Sets StatusReasonDescription
    /// </summary>
    [DataMember(Name="statusReasonDescription", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "statusReasonDescription")]
    public string StatusReasonDescription { get; set; }

    /// <summary>
    /// Gets or Sets StatusUpdateDate
    /// </summary>
    [DataMember(Name="statusUpdateDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "statusUpdateDate")]
    public DateTime? StatusUpdateDate { get; set; }

    /// <summary>
    /// Gets or Sets MultiAuthorisationStatus
    /// </summary>
    [DataMember(Name="multiAuthorisationStatus", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "multiAuthorisationStatus")]
    public MultiAuthorisation MultiAuthorisationStatus { get; set; }

    /// <summary>
    /// Gets or Sets IsoStatus
    /// </summary>
    [DataMember(Name="isoStatus", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "isoStatus")]
    public PaymentIsoStatus IsoStatus { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PaymentStatusDetails {\n");
      sb.Append("  Status: ").Append(Status).Append("\n");
      sb.Append("  StatusReason: ").Append(StatusReason).Append("\n");
      sb.Append("  StatusReasonDescription: ").Append(StatusReasonDescription).Append("\n");
      sb.Append("  StatusUpdateDate: ").Append(StatusUpdateDate).Append("\n");
      sb.Append("  MultiAuthorisationStatus: ").Append(MultiAuthorisationStatus).Append("\n");
      sb.Append("  IsoStatus: ").Append(IsoStatus).Append("\n");
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
