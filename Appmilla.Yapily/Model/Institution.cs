using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Appmilla.Yapily.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class Institution {
    /// <summary>
    /// An array of `Country` denoting which regions the `Institution` provides coverage for
    /// </summary>
    /// <value>An array of `Country` denoting which regions the `Institution` provides coverage for</value>
    [DataMember(Name="countries", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "countries")]
    public List<Country> Countries { get; set; }

    /// <summary>
    /// Gets or Sets CredentialsType
    /// </summary>
    [DataMember(Name="credentialsType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "credentialsType")]
    public string CredentialsType { get; set; }

    /// <summary>
    /// Gets or Sets EnvironmentType
    /// </summary>
    [DataMember(Name="environmentType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "environmentType")]
    public string EnvironmentType { get; set; }

    /// <summary>
    /// Gets or Sets Features
    /// </summary>
    [DataMember(Name="features", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "features")]
    public List<string> Features { get; set; }

    /// <summary>
    /// The full name of the `Institution`
    /// </summary>
    /// <value>The full name of the `Institution`</value>
    [DataMember(Name="fullName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "fullName")]
    public string FullName { get; set; }

    /// <summary>
    /// The Yapily Id for the `Institution`
    /// </summary>
    /// <value>The Yapily Id for the `Institution`</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }

    /// <summary>
    /// Contains links to the logo and the icons for the `Institution`
    /// </summary>
    /// <value>Contains links to the logo and the icons for the `Institution`</value>
    [DataMember(Name="media", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "media")]
    public List<Media> Media { get; set; }

    /// <summary>
    /// Gets or Sets Monitoring
    /// </summary>
    [DataMember(Name="monitoring", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "monitoring")]
    public Dictionary<string, MonitoringFeatureStatus> Monitoring { get; set; }

    /// <summary>
    /// The friendly name of the `Institution`
    /// </summary>
    /// <value>The friendly name of the `Institution`</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Institution {\n");
      sb.Append("  Countries: ").Append(Countries).Append("\n");
      sb.Append("  CredentialsType: ").Append(CredentialsType).Append("\n");
      sb.Append("  EnvironmentType: ").Append(EnvironmentType).Append("\n");
      sb.Append("  Features: ").Append(Features).Append("\n");
      sb.Append("  FullName: ").Append(FullName).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Media: ").Append(Media).Append("\n");
      sb.Append("  Monitoring: ").Append(Monitoring).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
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
