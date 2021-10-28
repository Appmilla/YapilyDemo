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
  public class UserDeleteResponse {
    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }

    /// <summary>
    /// Gets or Sets DeleteStatus
    /// </summary>
    [DataMember(Name="deleteStatus", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "deleteStatus")]
    public string DeleteStatus { get; set; }

    /// <summary>
    /// Gets or Sets CreationDate
    /// </summary>
    [DataMember(Name="creationDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "creationDate")]
    public DateTime? CreationDate { get; set; }

    /// <summary>
    /// Gets or Sets UserConsents
    /// </summary>
    [DataMember(Name="userConsents", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "userConsents")]
    public List<ConsentDeleteResponse> UserConsents { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class UserDeleteResponse {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  DeleteStatus: ").Append(DeleteStatus).Append("\n");
      sb.Append("  CreationDate: ").Append(CreationDate).Append("\n");
      sb.Append("  UserConsents: ").Append(UserConsents).Append("\n");
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
