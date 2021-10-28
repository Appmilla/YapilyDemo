using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Appmilla.Yapily.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class ExchangeRateInformation {
    /// <summary>
    /// Gets or Sets ForeignExchangeContractReference
    /// </summary>
    [DataMember(Name="foreignExchangeContractReference", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "foreignExchangeContractReference")]
    public string ForeignExchangeContractReference { get; set; }

    /// <summary>
    /// Gets or Sets Rate
    /// </summary>
    [DataMember(Name="rate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "rate")]
    public decimal? Rate { get; set; }

    /// <summary>
    /// Gets or Sets RateType
    /// </summary>
    [DataMember(Name="rateType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "rateType")]
    public string RateType { get; set; }

    /// <summary>
    /// Gets or Sets UnitCurrency
    /// </summary>
    [DataMember(Name="unitCurrency", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "unitCurrency")]
    public string UnitCurrency { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ExchangeRateInformation {\n");
      sb.Append("  ForeignExchangeContractReference: ").Append(ForeignExchangeContractReference).Append("\n");
      sb.Append("  Rate: ").Append(Rate).Append("\n");
      sb.Append("  RateType: ").Append(RateType).Append("\n");
      sb.Append("  UnitCurrency: ").Append(UnitCurrency).Append("\n");
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
