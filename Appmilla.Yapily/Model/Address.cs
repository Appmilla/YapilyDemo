using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Appmilla.Yapily.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class Address {
    /// <summary>
    /// Gets or Sets AddressLines
    /// </summary>
    [DataMember(Name="addressLines", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "addressLines")]
    public List<string> AddressLines { get; set; }

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
    /// Gets or Sets PostCode
    /// </summary>
    [DataMember(Name="postCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "postCode")]
    public string PostCode { get; set; }

    /// <summary>
    /// Gets or Sets TownName
    /// </summary>
    [DataMember(Name="townName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "townName")]
    public string TownName { get; set; }

    /// <summary>
    /// Gets or Sets County
    /// </summary>
    [DataMember(Name="county", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "county")]
    public List<string> County { get; set; }

    /// <summary>
    /// Gets or Sets AddressType
    /// </summary>
    [DataMember(Name="addressType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "addressType")]
    public string AddressType { get; set; }

    /// <summary>
    /// Gets or Sets Country
    /// </summary>
    [DataMember(Name="country", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "country")]
    public string Country { get; set; }

    /// <summary>
    /// Gets or Sets Department
    /// </summary>
    [DataMember(Name="department", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "department")]
    public string Department { get; set; }

    /// <summary>
    /// Gets or Sets SubDepartment
    /// </summary>
    [DataMember(Name="subDepartment", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "subDepartment")]
    public string SubDepartment { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Address {\n");
      sb.Append("  AddressLines: ").Append(AddressLines).Append("\n");
      sb.Append("  StreetName: ").Append(StreetName).Append("\n");
      sb.Append("  BuildingNumber: ").Append(BuildingNumber).Append("\n");
      sb.Append("  PostCode: ").Append(PostCode).Append("\n");
      sb.Append("  TownName: ").Append(TownName).Append("\n");
      sb.Append("  County: ").Append(County).Append("\n");
      sb.Append("  AddressType: ").Append(AddressType).Append("\n");
      sb.Append("  Country: ").Append(Country).Append("\n");
      sb.Append("  Department: ").Append(Department).Append("\n");
      sb.Append("  SubDepartment: ").Append(SubDepartment).Append("\n");
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
