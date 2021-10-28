using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Appmilla.Yapily.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class MerchantInfo {
    /// <summary>
    /// Gets or Sets CategoryCode
    /// </summary>
    [DataMember(Name="categoryCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "categoryCode")]
    public string CategoryCode { get; set; }

    /// <summary>
    /// Gets or Sets CustomerId
    /// </summary>
    [DataMember(Name="customerId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "customerId")]
    public string CustomerId { get; set; }

    /// <summary>
    /// Gets or Sets Address
    /// </summary>
    [DataMember(Name="address", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "address")]
    public Address Address { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class MerchantInfo {\n");
      sb.Append("  CategoryCode: ").Append(CategoryCode).Append("\n");
      sb.Append("  CustomerId: ").Append(CustomerId).Append("\n");
      sb.Append("  Address: ").Append(Address).Append("\n");
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
