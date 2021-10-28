using System;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Appmilla.Yapily.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class Enrichment {
    /// <summary>
    /// Gets or Sets Categorisation
    /// </summary>
    [DataMember(Name="categorisation", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "categorisation")]
    public Categorisation Categorisation { get; set; }

    /// <summary>
    /// Gets or Sets TransactionHash
    /// </summary>
    [DataMember(Name="transactionHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "transactionHash")]
    public TransactionHash TransactionHash { get; set; }

    /// <summary>
    /// CleansedDescription
    /// </summary>
    /// <value>CleansedDescription</value>
    [DataMember(Name="cleansedDescription", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "cleansedDescription")]
    public string CleansedDescription { get; set; }

    /// <summary>
    /// Gets or Sets Merchant
    /// </summary>
    [DataMember(Name="merchant", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "merchant")]
    public EnrichmentMerchant Merchant { get; set; }

    /// <summary>
    /// Location
    /// </summary>
    /// <value>Location</value>
    [DataMember(Name="location", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "location")]
    public string Location { get; set; }

    /// <summary>
    /// PaymentProcessor
    /// </summary>
    /// <value>PaymentProcessor</value>
    [DataMember(Name="paymentProcessor", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "paymentProcessor")]
    public string PaymentProcessor { get; set; }

    /// <summary>
    /// CorrectedDate
    /// </summary>
    /// <value>CorrectedDate</value>
    [DataMember(Name="correctedDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "correctedDate")]
    public DateTime? CorrectedDate { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Enrichment {\n");
      sb.Append("  Categorisation: ").Append(Categorisation).Append("\n");
      sb.Append("  TransactionHash: ").Append(TransactionHash).Append("\n");
      sb.Append("  CleansedDescription: ").Append(CleansedDescription).Append("\n");
      sb.Append("  Merchant: ").Append(Merchant).Append("\n");
      sb.Append("  Location: ").Append(Location).Append("\n");
      sb.Append("  PaymentProcessor: ").Append(PaymentProcessor).Append("\n");
      sb.Append("  CorrectedDate: ").Append(CorrectedDate).Append("\n");
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
