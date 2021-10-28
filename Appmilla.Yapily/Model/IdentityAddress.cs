using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Appmilla.Yapily.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class IdentityAddress {
    /// <summary>
    /// Gets or Sets AddressLines
    /// </summary>
    [DataMember(Name="addressLines", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "addressLines")]
    public List<string> AddressLines { get; set; }

    /// <summary>
    /// Gets or Sets City
    /// </summary>
    [DataMember(Name="city", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "city")]
    public string City { get; set; }

    /// <summary>
    /// Gets or Sets PostalCode
    /// </summary>
    [DataMember(Name="postalCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "postalCode")]
    public string PostalCode { get; set; }

    /// <summary>
    /// Gets or Sets Country
    /// </summary>
    [DataMember(Name="country", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "country")]
    public string Country { get; set; }

    /// <summary>
    /// Gets or Sets StreetName
    /// </summary>
    [DataMember(Name="streetName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "streetName")]
    public string StreetName { get; set; }

    /// <summary>
    /// Gets or Sets BuildingNumber
    /// </summary>
    [DataMember(Name="buildingNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "buildingNumber")]
    public string BuildingNumber { get; set; }

    /// <summary>
    /// Gets or Sets Type
    /// </summary>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }

    /// <summary>
    /// Gets or Sets County
    /// </summary>
    [DataMember(Name="county", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "county")]
    public string County { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class IdentityAddress {\n");
      sb.Append("  AddressLines: ").Append(AddressLines).Append("\n");
      sb.Append("  City: ").Append(City).Append("\n");
      sb.Append("  PostalCode: ").Append(PostalCode).Append("\n");
      sb.Append("  Country: ").Append(Country).Append("\n");
      sb.Append("  StreetName: ").Append(StreetName).Append("\n");
      sb.Append("  BuildingNumber: ").Append(BuildingNumber).Append("\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
      sb.Append("  County: ").Append(County).Append("\n");
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
