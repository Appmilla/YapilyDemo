using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Appmilla.Yapily.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class Merchant {
    /// <summary>
    /// Gets or Sets MerchantName
    /// </summary>
    [DataMember(Name="merchantName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "merchantName")]
    public string MerchantName { get; set; }

    /// <summary>
    /// Gets or Sets MerchantCategoryCode
    /// </summary>
    [DataMember(Name="merchantCategoryCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "merchantCategoryCode")]
    public string MerchantCategoryCode { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Merchant {\n");
      sb.Append("  MerchantName: ").Append(MerchantName).Append("\n");
      sb.Append("  MerchantCategoryCode: ").Append(MerchantCategoryCode).Append("\n");
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
