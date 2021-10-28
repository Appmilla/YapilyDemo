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
  public class Application {
    /// <summary>
    /// Application UUID
    /// </summary>
    /// <value>Application UUID</value>
    [DataMember(Name="uuid", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "uuid")]
    public string Uuid { get; set; }

    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets Active
    /// </summary>
    [DataMember(Name="active", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "active")]
    public bool? Active { get; set; }

    /// <summary>
    /// Gets or Sets AuthCallbacks
    /// </summary>
    [DataMember(Name="authCallbacks", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "authCallbacks")]
    public List<string> AuthCallbacks { get; set; }

    /// <summary>
    /// Gets or Sets Institutions
    /// </summary>
    [DataMember(Name="institutions", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "institutions")]
    public List<Institution> Institutions { get; set; }

    /// <summary>
    /// Gets or Sets Media
    /// </summary>
    [DataMember(Name="media", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "media")]
    public List<Media> Media { get; set; }

    /// <summary>
    /// Gets or Sets Created
    /// </summary>
    [DataMember(Name="created", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "created")]
    public DateTime? Created { get; set; }

    /// <summary>
    /// Gets or Sets Updated
    /// </summary>
    [DataMember(Name="updated", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "updated")]
    public DateTime? Updated { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Application {\n");
      sb.Append("  Uuid: ").Append(Uuid).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Active: ").Append(Active).Append("\n");
      sb.Append("  AuthCallbacks: ").Append(AuthCallbacks).Append("\n");
      sb.Append("  Institutions: ").Append(Institutions).Append("\n");
      sb.Append("  Media: ").Append(Media).Append("\n");
      sb.Append("  Created: ").Append(Created).Append("\n");
      sb.Append("  Updated: ").Append(Updated).Append("\n");
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
