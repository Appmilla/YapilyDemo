using System;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Appmilla.Yapily.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class AccountStatement {
    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }

    /// <summary>
    /// Gets or Sets StartDateTime
    /// </summary>
    [DataMember(Name="startDateTime", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "startDateTime")]
    public DateTime? StartDateTime { get; set; }

    /// <summary>
    /// Gets or Sets EndDateTime
    /// </summary>
    [DataMember(Name="endDateTime", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "endDateTime")]
    public DateTime? EndDateTime { get; set; }

    /// <summary>
    /// Gets or Sets CreationDateTime
    /// </summary>
    [DataMember(Name="creationDateTime", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "creationDateTime")]
    public DateTime? CreationDateTime { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AccountStatement {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  StartDateTime: ").Append(StartDateTime).Append("\n");
      sb.Append("  EndDateTime: ").Append(EndDateTime).Append("\n");
      sb.Append("  CreationDateTime: ").Append(CreationDateTime).Append("\n");
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
