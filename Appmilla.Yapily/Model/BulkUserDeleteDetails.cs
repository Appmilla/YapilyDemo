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
  public class BulkUserDeleteDetails {
    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }

    /// <summary>
    /// Gets or Sets InvalidApplicationUserIds
    /// </summary>
    [DataMember(Name="invalidApplicationUserIds", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "invalidApplicationUserIds")]
    public List<string> InvalidApplicationUserIds { get; set; }

    /// <summary>
    /// Gets or Sets InvalidUserUuids
    /// </summary>
    [DataMember(Name="invalidUserUuids", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "invalidUserUuids")]
    public List<string> InvalidUserUuids { get; set; }

    /// <summary>
    /// Gets or Sets Status
    /// </summary>
    [DataMember(Name="status", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "status")]
    public string Status { get; set; }

    /// <summary>
    /// Gets or Sets StartedAt
    /// </summary>
    [DataMember(Name="startedAt", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "startedAt")]
    public DateTime? StartedAt { get; set; }

    /// <summary>
    /// Gets or Sets Users
    /// </summary>
    [DataMember(Name="users", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "users")]
    public List<UserDeleteResponse> Users { get; set; }

    /// <summary>
    /// Gets or Sets Links
    /// </summary>
    [DataMember(Name="links", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "links")]
    public Dictionary<string, string> Links { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class BulkUserDeleteDetails {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  InvalidApplicationUserIds: ").Append(InvalidApplicationUserIds).Append("\n");
      sb.Append("  InvalidUserUuids: ").Append(InvalidUserUuids).Append("\n");
      sb.Append("  Status: ").Append(Status).Append("\n");
      sb.Append("  StartedAt: ").Append(StartedAt).Append("\n");
      sb.Append("  Users: ").Append(Users).Append("\n");
      sb.Append("  Links: ").Append(Links).Append("\n");
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
