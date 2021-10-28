using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Appmilla.Yapily.Model {

  /// <summary>
  /// Links on popular map services pointing the ATM Location on the earth.
  /// </summary>
  [DataContract]
  public class ATMMapServiceLinks {
    /// <summary>
    /// Gets or Sets BingMapsUrl
    /// </summary>
    [DataMember(Name="bingMapsUrl", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "bingMapsUrl")]
    public string BingMapsUrl { get; set; }

    /// <summary>
    /// Gets or Sets GoogleMapsUrl
    /// </summary>
    [DataMember(Name="googleMapsUrl", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "googleMapsUrl")]
    public string GoogleMapsUrl { get; set; }

    /// <summary>
    /// Gets or Sets HereMapsUrl
    /// </summary>
    [DataMember(Name="hereMapsUrl", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "hereMapsUrl")]
    public string HereMapsUrl { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ATMMapServiceLinks {\n");
      sb.Append("  BingMapsUrl: ").Append(BingMapsUrl).Append("\n");
      sb.Append("  GoogleMapsUrl: ").Append(GoogleMapsUrl).Append("\n");
      sb.Append("  HereMapsUrl: ").Append(HereMapsUrl).Append("\n");
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
