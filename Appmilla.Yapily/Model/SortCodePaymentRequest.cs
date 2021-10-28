using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Appmilla.Yapily.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class SortCodePaymentRequest {
    /// <summary>
    /// Gets or Sets SenderAccountId
    /// </summary>
    [DataMember(Name="senderAccountId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "senderAccountId")]
    public string SenderAccountId { get; set; }

    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets Amount
    /// </summary>
    [DataMember(Name="amount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "amount")]
    public decimal? Amount { get; set; }

    /// <summary>
    /// Gets or Sets Currency
    /// </summary>
    [DataMember(Name="currency", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "currency")]
    public string Currency { get; set; }

    /// <summary>
    /// Gets or Sets Reference
    /// </summary>
    [DataMember(Name="reference", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "reference")]
    public string Reference { get; set; }

    /// <summary>
    /// Gets or Sets Country
    /// </summary>
    [DataMember(Name="country", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "country")]
    public string Country { get; set; }

    /// <summary>
    /// Gets or Sets Type
    /// </summary>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }

    /// <summary>
    /// Gets or Sets AccountNumber
    /// </summary>
    [DataMember(Name="accountNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "accountNumber")]
    public string AccountNumber { get; set; }

    /// <summary>
    /// Gets or Sets SortCode
    /// </summary>
    [DataMember(Name="sortCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sortCode")]
    public string SortCode { get; set; }

    /// <summary>
    /// Gets or Sets MerchantInfo
    /// </summary>
    [DataMember(Name="merchantInfo", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "merchantInfo")]
    public MerchantInfo MerchantInfo { get; set; }

    /// <summary>
    /// Gets or Sets ReadRefundAccount
    /// </summary>
    [DataMember(Name="readRefundAccount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "readRefundAccount")]
    public bool? ReadRefundAccount { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class SortCodePaymentRequest {\n");
      sb.Append("  SenderAccountId: ").Append(SenderAccountId).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Amount: ").Append(Amount).Append("\n");
      sb.Append("  Currency: ").Append(Currency).Append("\n");
      sb.Append("  Reference: ").Append(Reference).Append("\n");
      sb.Append("  Country: ").Append(Country).Append("\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
      sb.Append("  AccountNumber: ").Append(AccountNumber).Append("\n");
      sb.Append("  SortCode: ").Append(SortCode).Append("\n");
      sb.Append("  MerchantInfo: ").Append(MerchantInfo).Append("\n");
      sb.Append("  ReadRefundAccount: ").Append(ReadRefundAccount).Append("\n");
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
