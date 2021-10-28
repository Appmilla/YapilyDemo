using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Appmilla.Yapily.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class ApplicationUser {
    /// <summary>
    /// User UUID
    /// </summary>
    /// <value>User UUID</value>
    [DataMember(Name="uuid", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "uuid")]
    public string Uuid { get; set; }

    /// <summary>
    /// Gets or Sets ApplicationUuid
    /// </summary>
    [DataMember(Name="applicationUuid", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "applicationUuid")]
    public string ApplicationUuid { get; set; }

    /// <summary>
    /// Gets or Sets ApplicationUserId
    /// </summary>
    [DataMember(Name="applicationUserId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "applicationUserId")]
    public string ApplicationUserId { get; set; }

    /// <summary>
    /// Gets or Sets ReferenceId
    /// </summary>
    [DataMember(Name="referenceId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "referenceId")]
    public string ReferenceId { get; set; }

    /// <summary>
    /// Gets or Sets InstitutionConsents
    /// </summary>
    [DataMember(Name="institutionConsents", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "institutionConsents")]
    public List<InstitutionConsent> InstitutionConsents { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ApplicationUser {\n");
      sb.Append("  Uuid: ").Append(Uuid).Append("\n");
      sb.Append("  ApplicationUuid: ").Append(ApplicationUuid).Append("\n");
      sb.Append("  ApplicationUserId: ").Append(ApplicationUserId).Append("\n");
      sb.Append("  ReferenceId: ").Append(ReferenceId).Append("\n");
      sb.Append("  InstitutionConsents: ").Append(InstitutionConsents).Append("\n");
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
