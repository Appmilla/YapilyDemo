using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Appmilla.Yapily.Model {

  /// <summary>
  /// An array of &#x60;Country&#x60; denoting which regions the &#x60;Institution&#x60; provides coverage for
  /// </summary>
  [DataContract]
  public class Country {
    /// <summary>
    /// Gets or Sets CountryCode2
    /// </summary>
    [DataMember(Name="countryCode2", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "countryCode2")]
    public string CountryCode2 { get; set; }

    /// <summary>
    /// Gets or Sets DisplayName
    /// </summary>
    [DataMember(Name="displayName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "displayName")]
    public string DisplayName { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Country {\n");
      sb.Append("  CountryCode2: ").Append(CountryCode2).Append("\n");
      sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
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
