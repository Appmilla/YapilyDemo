using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Appmilla.Yapily.Model {

  /// <summary>
  /// Information that locates and identifies a specific address, as defined by postal services or in free format text.
  /// </summary>
  [DataContract]
  public class PostalAddress1 {
    /// <summary>
    /// Gets or Sets AddressLine
    /// </summary>
    [DataMember(Name="AddressLine", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AddressLine")]
    public List<string> AddressLine { get; set; }

    /// <summary>
    /// Gets or Sets BuildingNumber
    /// </summary>
    [DataMember(Name="BuildingNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "BuildingNumber")]
    public string BuildingNumber { get; set; }

    /// <summary>
    /// Gets or Sets Country
    /// </summary>
    [DataMember(Name="Country", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Country")]
    public string Country { get; set; }

    /// <summary>
    /// Gets or Sets CountrySubDivision
    /// </summary>
    [DataMember(Name="CountrySubDivision", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CountrySubDivision")]
    public List<string> CountrySubDivision { get; set; }

    /// <summary>
    /// Gets or Sets GeoLocation
    /// </summary>
    [DataMember(Name="GeoLocation", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "GeoLocation")]
    public GeoLocation1 GeoLocation { get; set; }

    /// <summary>
    /// Gets or Sets PostCode
    /// </summary>
    [DataMember(Name="PostCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PostCode")]
    public string PostCode { get; set; }

    /// <summary>
    /// Gets or Sets StreetName
    /// </summary>
    [DataMember(Name="StreetName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "StreetName")]
    public string StreetName { get; set; }

    /// <summary>
    /// Gets or Sets TownName
    /// </summary>
    [DataMember(Name="TownName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TownName")]
    public string TownName { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PostalAddress1 {\n");
      sb.Append("  AddressLine: ").Append(AddressLine).Append("\n");
      sb.Append("  BuildingNumber: ").Append(BuildingNumber).Append("\n");
      sb.Append("  Country: ").Append(Country).Append("\n");
      sb.Append("  CountrySubDivision: ").Append(CountrySubDivision).Append("\n");
      sb.Append("  GeoLocation: ").Append(GeoLocation).Append("\n");
      sb.Append("  PostCode: ").Append(PostCode).Append("\n");
      sb.Append("  StreetName: ").Append(StreetName).Append("\n");
      sb.Append("  TownName: ").Append(TownName).Append("\n");
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
