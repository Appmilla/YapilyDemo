using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Appmilla.Yapily.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class AccountRequest {
    /// <summary>
    /// Gets or Sets TransactionFrom
    /// </summary>
    [DataMember(Name="transactionFrom", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "transactionFrom")]
    public DateTime? TransactionFrom { get; set; }

    /// <summary>
    /// Gets or Sets TransactionTo
    /// </summary>
    [DataMember(Name="transactionTo", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "transactionTo")]
    public DateTime? TransactionTo { get; set; }

    /// <summary>
    /// Gets or Sets ExpiresAt
    /// </summary>
    [DataMember(Name="expiresAt", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "expiresAt")]
    public DateTime? ExpiresAt { get; set; }

    /// <summary>
    /// Gets or Sets AccountIdentifiers
    /// </summary>
    [DataMember(Name="accountIdentifiers", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "accountIdentifiers")]
    public AccountInfo AccountIdentifiers { get; set; }

    /// <summary>
    /// Gets or Sets AccountIdentifiersForTransaction
    /// </summary>
    [DataMember(Name="accountIdentifiersForTransaction", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "accountIdentifiersForTransaction")]
    public List<AccountInfo> AccountIdentifiersForTransaction { get; set; }

    /// <summary>
    /// Gets or Sets AccountIdentifiersForBalance
    /// </summary>
    [DataMember(Name="accountIdentifiersForBalance", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "accountIdentifiersForBalance")]
    public List<AccountInfo> AccountIdentifiersForBalance { get; set; }

    /// <summary>
    /// Gets or Sets FeatureScope
    /// </summary>
    [DataMember(Name="featureScope", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "featureScope")]
    public List<string> FeatureScope { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AccountRequest {\n");
      sb.Append("  TransactionFrom: ").Append(TransactionFrom).Append("\n");
      sb.Append("  TransactionTo: ").Append(TransactionTo).Append("\n");
      sb.Append("  ExpiresAt: ").Append(ExpiresAt).Append("\n");
      sb.Append("  AccountIdentifiers: ").Append(AccountIdentifiers).Append("\n");
      sb.Append("  AccountIdentifiersForTransaction: ").Append(AccountIdentifiersForTransaction).Append("\n");
      sb.Append("  AccountIdentifiersForBalance: ").Append(AccountIdentifiersForBalance).Append("\n");
      sb.Append("  FeatureScope: ").Append(FeatureScope).Append("\n");
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
