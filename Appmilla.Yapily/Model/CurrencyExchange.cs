using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Appmilla.Yapily.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class CurrencyExchange {
    /// <summary>
    /// ISO 4217 currency code denoting the currency of the creditor
    /// </summary>
    /// <value>ISO 4217 currency code denoting the currency of the creditor</value>
    [DataMember(Name="sourceCurrency", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sourceCurrency")]
    public string SourceCurrency { get; set; }

    /// <summary>
    /// ISO 4217 currency code denoting the currency of the debtor
    /// </summary>
    /// <value>ISO 4217 currency code denoting the currency of the debtor</value>
    [DataMember(Name="targetCurrency", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "targetCurrency")]
    public string TargetCurrency { get; set; }

    /// <summary>
    /// ISO 4217 currency code denoting the currency used to set the exchange rate (GBP is the unit currency in the conversion of 1 GBP = x CUR)
    /// </summary>
    /// <value>ISO 4217 currency code denoting the currency used to set the exchange rate (GBP is the unit currency in the conversion of 1 GBP = x CUR)</value>
    [DataMember(Name="unitCurrency", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "unitCurrency")]
    public string UnitCurrency { get; set; }

    /// <summary>
    /// Currency exchange rate
    /// </summary>
    /// <value>Currency exchange rate</value>
    [DataMember(Name="exchangeRate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "exchangeRate")]
    public decimal? ExchangeRate { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class CurrencyExchange {\n");
      sb.Append("  SourceCurrency: ").Append(SourceCurrency).Append("\n");
      sb.Append("  TargetCurrency: ").Append(TargetCurrency).Append("\n");
      sb.Append("  UnitCurrency: ").Append(UnitCurrency).Append("\n");
      sb.Append("  ExchangeRate: ").Append(ExchangeRate).Append("\n");
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
