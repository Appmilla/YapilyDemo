using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Appmilla.Yapily.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class ApiError {
    /// <summary>
    /// Gets or Sets Code
    /// </summary>
    [DataMember(Name="code", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "code")]
    public int? Code { get; set; }

    /// <summary>
    /// Gets or Sets InstitutionError
    /// </summary>
    [DataMember(Name="institutionError", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "institutionError")]
    public InstitutionError InstitutionError { get; set; }

    /// <summary>
    /// Gets or Sets Message
    /// </summary>
    [DataMember(Name="message", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "message")]
    public string Message { get; set; }

    /// <summary>
    /// Gets or Sets Source
    /// </summary>
    [DataMember(Name="source", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "source")]
    public string Source { get; set; }

    /// <summary>
    /// Gets or Sets Status
    /// </summary>
    [DataMember(Name="status", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "status")]
    public string Status { get; set; }

    /// <summary>
    /// Gets or Sets TracingId
    /// </summary>
    [DataMember(Name="tracingId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tracingId")]
    public string TracingId { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ApiError {\n");
      sb.Append("  Code: ").Append(Code).Append("\n");
      sb.Append("  InstitutionError: ").Append(InstitutionError).Append("\n");
      sb.Append("  Message: ").Append(Message).Append("\n");
      sb.Append("  Source: ").Append(Source).Append("\n");
      sb.Append("  Status: ").Append(Status).Append("\n");
      sb.Append("  TracingId: ").Append(TracingId).Append("\n");
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
