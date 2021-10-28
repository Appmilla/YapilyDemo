using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Appmilla.Yapily.Model {

  /// <summary>
  /// Geographic location of the ATM specified by geographic coordinates or UTM coordinates.
  /// </summary>
  [DataContract]
  public class GeoLocation1 {
    /// <summary>
    /// Gets or Sets GeographicCoordinates
    /// </summary>
    [DataMember(Name="GeographicCoordinates", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "GeographicCoordinates")]
    public GeographicCoordinates1 GeographicCoordinates { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GeoLocation1 {\n");
      sb.Append("  GeographicCoordinates: ").Append(GeographicCoordinates).Append("\n");
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
