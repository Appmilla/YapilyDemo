using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Appmilla.Yapily.Model {

  /// <summary>
  /// Core feature of the PCA product which can be associated to a particular Marketing State
  /// </summary>
  [DataContract]
  public class CoreProduct {
    /// <summary>
    /// Gets or Sets MonthlyMaximumCharge
    /// </summary>
    [DataMember(Name="MonthlyMaximumCharge", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "MonthlyMaximumCharge")]
    public string MonthlyMaximumCharge { get; set; }

    /// <summary>
    /// Gets or Sets ProductDescription
    /// </summary>
    [DataMember(Name="ProductDescription", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ProductDescription")]
    public string ProductDescription { get; set; }

    /// <summary>
    /// Gets or Sets ProductURL
    /// </summary>
    [DataMember(Name="ProductURL", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ProductURL")]
    public string ProductURL { get; set; }

    /// <summary>
    /// Gets or Sets SalesAccessChannels
    /// </summary>
    [DataMember(Name="SalesAccessChannels", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SalesAccessChannels")]
    public List<string> SalesAccessChannels { get; set; }

    /// <summary>
    /// Gets or Sets ServicingAccessChannels
    /// </summary>
    [DataMember(Name="ServicingAccessChannels", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ServicingAccessChannels")]
    public List<string> ServicingAccessChannels { get; set; }

    /// <summary>
    /// Gets or Sets TcsAndCsURL
    /// </summary>
    [DataMember(Name="TcsAndCsURL", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TcsAndCsURL")]
    public string TcsAndCsURL { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class CoreProduct {\n");
      sb.Append("  MonthlyMaximumCharge: ").Append(MonthlyMaximumCharge).Append("\n");
      sb.Append("  ProductDescription: ").Append(ProductDescription).Append("\n");
      sb.Append("  ProductURL: ").Append(ProductURL).Append("\n");
      sb.Append("  SalesAccessChannels: ").Append(SalesAccessChannels).Append("\n");
      sb.Append("  ServicingAccessChannels: ").Append(ServicingAccessChannels).Append("\n");
      sb.Append("  TcsAndCsURL: ").Append(TcsAndCsURL).Append("\n");
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
