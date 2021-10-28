using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Appmilla.Yapily.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class EnrichmentMerchant {
    /// <summary>
    /// MerchantName
    /// </summary>
    /// <value>MerchantName</value>
    [DataMember(Name="merchantName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "merchantName")]
    public string MerchantName { get; set; }

    /// <summary>
    /// ParentGroup
    /// </summary>
    /// <value>ParentGroup</value>
    [DataMember(Name="parentGroup", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "parentGroup")]
    public string ParentGroup { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class EnrichmentMerchant {\n");
      sb.Append("  MerchantName: ").Append(MerchantName).Append("\n");
      sb.Append("  ParentGroup: ").Append(ParentGroup).Append("\n");
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
