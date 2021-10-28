using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Appmilla.Yapily.Model {

  /// <summary>
  /// Location of the ATM.
  /// </summary>
  [DataContract]
  public class Location {
    /// <summary>
    /// Gets or Sets LocationCategory
    /// </summary>
    [DataMember(Name="LocationCategory", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "LocationCategory")]
    public List<string> LocationCategory { get; set; }

    /// <summary>
    /// Gets or Sets OtherLocationCategory
    /// </summary>
    [DataMember(Name="OtherLocationCategory", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "OtherLocationCategory")]
    public List<LocationOtherLocationCategory> OtherLocationCategory { get; set; }

    /// <summary>
    /// Gets or Sets PostalAddress
    /// </summary>
    [DataMember(Name="PostalAddress", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PostalAddress")]
    public PostalAddress1 PostalAddress { get; set; }

    /// <summary>
    /// Gets or Sets Site
    /// </summary>
    [DataMember(Name="Site", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Site")]
    public Site Site { get; set; }

    /// <summary>
    /// Gets or Sets MapServiceLinks
    /// </summary>
    [DataMember(Name="mapServiceLinks", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "mapServiceLinks")]
    public ATMMapServiceLinks MapServiceLinks { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Location {\n");
      sb.Append("  LocationCategory: ").Append(LocationCategory).Append("\n");
      sb.Append("  OtherLocationCategory: ").Append(OtherLocationCategory).Append("\n");
      sb.Append("  PostalAddress: ").Append(PostalAddress).Append("\n");
      sb.Append("  Site: ").Append(Site).Append("\n");
      sb.Append("  MapServiceLinks: ").Append(MapServiceLinks).Append("\n");
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
