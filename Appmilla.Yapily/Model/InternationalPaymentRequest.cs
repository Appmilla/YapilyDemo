using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Appmilla.Yapily.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class InternationalPaymentRequest {
    /// <summary>
    /// Gets or Sets CurrencyOfTransfer
    /// </summary>
    [DataMember(Name="currencyOfTransfer", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "currencyOfTransfer")]
    public string CurrencyOfTransfer { get; set; }

    /// <summary>
    /// Gets or Sets ExchangeRateInformation
    /// </summary>
    [DataMember(Name="exchangeRateInformation", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "exchangeRateInformation")]
    public ExchangeRateInformation ExchangeRateInformation { get; set; }

    /// <summary>
    /// Gets or Sets Purpose
    /// </summary>
    [DataMember(Name="purpose", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "purpose")]
    public string Purpose { get; set; }

    /// <summary>
    /// Gets or Sets Priority
    /// </summary>
    [DataMember(Name="priority", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "priority")]
    public string Priority { get; set; }

    /// <summary>
    /// Gets or Sets ChargeBearer
    /// </summary>
    [DataMember(Name="chargeBearer", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "chargeBearer")]
    public string ChargeBearer { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class InternationalPaymentRequest {\n");
      sb.Append("  CurrencyOfTransfer: ").Append(CurrencyOfTransfer).Append("\n");
      sb.Append("  ExchangeRateInformation: ").Append(ExchangeRateInformation).Append("\n");
      sb.Append("  Purpose: ").Append(Purpose).Append("\n");
      sb.Append("  Priority: ").Append(Priority).Append("\n");
      sb.Append("  ChargeBearer: ").Append(ChargeBearer).Append("\n");
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
