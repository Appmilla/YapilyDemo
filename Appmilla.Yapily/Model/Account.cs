using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Appmilla.Yapily.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class Account {
    /// <summary>
    /// Account Id returned by the institution if present
    /// </summary>
    /// <value>Account Id returned by the institution if present</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }

    /// <summary>
    /// Gets or Sets Type
    /// </summary>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }

    /// <summary>
    /// Product name as defined by the financial institution for this account
    /// </summary>
    /// <value>Product name as defined by the financial institution for this account</value>
    [DataMember(Name="description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    /// <summary>
    /// Gets or Sets Balance
    /// </summary>
    [DataMember(Name="balance", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "balance")]
    public decimal? Balance { get; set; }

    /// <summary>
    /// ISO 4217 currency code
    /// </summary>
    /// <value>ISO 4217 currency code</value>
    [DataMember(Name="currency", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "currency")]
    public string Currency { get; set; }

    /// <summary>
    /// Gets or Sets UsageType
    /// </summary>
    [DataMember(Name="usageType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "usageType")]
    public string UsageType { get; set; }

    /// <summary>
    /// Gets or Sets AccountType
    /// </summary>
    [DataMember(Name="accountType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "accountType")]
    public string AccountType { get; set; }

    /// <summary>
    /// Name of the account as defined by the financial institution or the end user
    /// </summary>
    /// <value>Name of the account as defined by the financial institution or the end user</value>
    [DataMember(Name="nickname", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "nickname")]
    public string Nickname { get; set; }

    /// <summary>
    /// Specifications that might be provided by the institution - characteristics of the account - characteristics of the relevant card
    /// </summary>
    /// <value>Specifications that might be provided by the institution - characteristics of the account - characteristics of the relevant card</value>
    [DataMember(Name="details", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "details")]
    public string Details { get; set; }

    /// <summary>
    /// Gets or Sets AccountNames
    /// </summary>
    [DataMember(Name="accountNames", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "accountNames")]
    public List<AccountName> AccountNames { get; set; }

    /// <summary>
    /// Gets or Sets AccountIdentifications
    /// </summary>
    [DataMember(Name="accountIdentifications", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "accountIdentifications")]
    public List<AccountIdentification> AccountIdentifications { get; set; }

    /// <summary>
    /// Gets or Sets AccountBalances
    /// </summary>
    [DataMember(Name="accountBalances", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "accountBalances")]
    public List<AccountBalance> AccountBalances { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Account {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  Balance: ").Append(Balance).Append("\n");
      sb.Append("  Currency: ").Append(Currency).Append("\n");
      sb.Append("  UsageType: ").Append(UsageType).Append("\n");
      sb.Append("  AccountType: ").Append(AccountType).Append("\n");
      sb.Append("  Nickname: ").Append(Nickname).Append("\n");
      sb.Append("  Details: ").Append(Details).Append("\n");
      sb.Append("  AccountNames: ").Append(AccountNames).Append("\n");
      sb.Append("  AccountIdentifications: ").Append(AccountIdentifications).Append("\n");
      sb.Append("  AccountBalances: ").Append(AccountBalances).Append("\n");
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
