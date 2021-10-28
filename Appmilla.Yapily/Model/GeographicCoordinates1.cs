using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Appmilla.Yapily.Model {

  /// <summary>
  /// Location on the earth specified by two numbers representing vertical and horizontal position.
  /// </summary>
  [DataContract]
  public class GeographicCoordinates1 {
    /// <summary>
    /// Gets or Sets Latitude
    /// </summary>
    [DataMember(Name="Latitude", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Latitude")]
    public string Latitude { get; set; }

    /// <summary>
    /// Gets or Sets Longitude
    /// </summary>
    [DataMember(Name="Longitude", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Longitude")]
    public string Longitude { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GeographicCoordinates1 {\n");
      sb.Append("  Latitude: ").Append(Latitude).Append("\n");
      sb.Append("  Longitude: ").Append(Longitude).Append("\n");
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
