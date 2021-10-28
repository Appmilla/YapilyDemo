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
  public class AccountBalance {
    /// <summary>
    /// Gets or Sets Type
    /// </summary>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }

    /// <summary>
    /// Timestamp of the last change of the balance amount
    /// </summary>
    /// <value>Timestamp of the last change of the balance amount</value>
    [DataMember(Name="dateTime", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "dateTime")]
    public DateTime? DateTime { get; set; }

    /// <summary>
    /// Gets or Sets BalanceAmount
    /// </summary>
    [DataMember(Name="balanceAmount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "balanceAmount")]
    public Amount BalanceAmount { get; set; }

    /// <summary>
    /// Indicates whether or not the credit line is included in the balance
    /// </summary>
    /// <value>Indicates whether or not the credit line is included in the balance</value>
    [DataMember(Name="creditLineIncluded", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "creditLineIncluded")]
    public bool? CreditLineIncluded { get; set; }

    /// <summary>
    /// Gets or Sets CreditLines
    /// </summary>
    [DataMember(Name="creditLines", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "creditLines")]
    public List<CreditLine> CreditLines { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AccountBalance {\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
      sb.Append("  DateTime: ").Append(DateTime).Append("\n");
      sb.Append("  BalanceAmount: ").Append(BalanceAmount).Append("\n");
      sb.Append("  CreditLineIncluded: ").Append(CreditLineIncluded).Append("\n");
      sb.Append("  CreditLines: ").Append(CreditLines).Append("\n");
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
