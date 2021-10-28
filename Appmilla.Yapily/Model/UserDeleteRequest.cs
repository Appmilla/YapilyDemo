using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Appmilla.Yapily.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class UserDeleteRequest {
    /// <summary>
    /// Gets or Sets UserUuids
    /// </summary>
    [DataMember(Name="userUuids", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "userUuids")]
    public List<string> UserUuids { get; set; }

    /// <summary>
    /// Gets or Sets ApplicationUserIds
    /// </summary>
    [DataMember(Name="applicationUserIds", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "applicationUserIds")]
    public List<string> ApplicationUserIds { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class UserDeleteRequest {\n");
      sb.Append("  UserUuids: ").Append(UserUuids).Append("\n");
      sb.Append("  ApplicationUserIds: ").Append(ApplicationUserIds).Append("\n");
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
