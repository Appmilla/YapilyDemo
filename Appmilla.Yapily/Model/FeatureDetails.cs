using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Appmilla.Yapily.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class FeatureDetails {
    /// <summary>
    /// Gets or Sets Feature
    /// </summary>
    [DataMember(Name="feature", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "feature")]
    public string Feature { get; set; }

    /// <summary>
    /// Gets or Sets Endpoint
    /// </summary>
    [DataMember(Name="endpoint", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "endpoint")]
    public string Endpoint { get; set; }

    /// <summary>
    /// Gets or Sets DocumentationUrl
    /// </summary>
    [DataMember(Name="documentationUrl", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "documentationUrl")]
    public string DocumentationUrl { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class FeatureDetails {\n");
      sb.Append("  Feature: ").Append(Feature).Append("\n");
      sb.Append("  Endpoint: ").Append(Endpoint).Append("\n");
      sb.Append("  DocumentationUrl: ").Append(DocumentationUrl).Append("\n");
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
