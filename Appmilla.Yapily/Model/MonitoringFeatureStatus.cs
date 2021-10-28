using System;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Appmilla.Yapily.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class MonitoringFeatureStatus {
    /// <summary>
    /// Gets or Sets LastTested
    /// </summary>
    [DataMember(Name="lastTested", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lastTested")]
    public DateTime? LastTested { get; set; }

    /// <summary>
    /// Gets or Sets Span
    /// </summary>
    [DataMember(Name="span", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "span")]
    public string Span { get; set; }

    /// <summary>
    /// Gets or Sets Status
    /// </summary>
    [DataMember(Name="status", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "status")]
    public string Status { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class MonitoringFeatureStatus {\n");
      sb.Append("  LastTested: ").Append(LastTested).Append("\n");
      sb.Append("  Span: ").Append(Span).Append("\n");
      sb.Append("  Status: ").Append(Status).Append("\n");
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
