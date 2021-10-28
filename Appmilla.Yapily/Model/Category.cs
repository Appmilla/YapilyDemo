using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Appmilla.Yapily.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class Category {
    /// <summary>
    /// Category ID
    /// </summary>
    /// <value>Category ID</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }

    /// <summary>
    /// Category label
    /// </summary>
    /// <value>Category label</value>
    [DataMember(Name="label", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "label")]
    public string Label { get; set; }

    /// <summary>
    /// Category country
    /// </summary>
    /// <value>Category country</value>
    [DataMember(Name="country", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "country")]
    public string Country { get; set; }

    /// <summary>
    /// Gets or Sets Subcategories
    /// </summary>
    [DataMember(Name="subcategories", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "subcategories")]
    public List<Subcategory> Subcategories { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Category {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Label: ").Append(Label).Append("\n");
      sb.Append("  Country: ").Append(Country).Append("\n");
      sb.Append("  Subcategories: ").Append(Subcategories).Append("\n");
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
