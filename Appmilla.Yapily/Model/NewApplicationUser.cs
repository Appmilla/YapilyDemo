using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Appmilla.Yapily.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class NewApplicationUser {
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
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class NewApplicationUser {\n");
      sb.Append("  ApplicationUserId: ").Append(ApplicationUserId).Append("\n");
      sb.Append("  ReferenceId: ").Append(ReferenceId).Append("\n");
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
