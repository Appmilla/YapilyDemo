using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Appmilla.Yapily.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class SSAResult {
    /// <summary>
    /// Gets or Sets ApplicationId
    /// </summary>
    [DataMember(Name="applicationId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "applicationId")]
    public string ApplicationId { get; set; }

    /// <summary>
    /// Gets or Sets InstitutionId
    /// </summary>
    [DataMember(Name="institutionId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "institutionId")]
    public string InstitutionId { get; set; }

    /// <summary>
    /// Gets or Sets SsaJwt
    /// </summary>
    [DataMember(Name="ssaJwt", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ssaJwt")]
    public string SsaJwt { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class SSAResult {\n");
      sb.Append("  ApplicationId: ").Append(ApplicationId).Append("\n");
      sb.Append("  InstitutionId: ").Append(InstitutionId).Append("\n");
      sb.Append("  SsaJwt: ").Append(SsaJwt).Append("\n");
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
