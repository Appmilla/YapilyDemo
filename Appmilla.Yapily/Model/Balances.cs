using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Appmilla.Yapily.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class Balances {
    /// <summary>
    /// Gets or Sets MainBalanceAmount
    /// </summary>
    [DataMember(Name="mainBalanceAmount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "mainBalanceAmount")]
    public Amount MainBalanceAmount { get; set; }

    /// <summary>
    /// Gets or Sets _Balances
    /// </summary>
    [DataMember(Name="balances", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "balances")]
    public List<AccountBalance> _Balances { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Balances {\n");
      sb.Append("  MainBalanceAmount: ").Append(MainBalanceAmount).Append("\n");
      sb.Append("  _Balances: ").Append(_Balances).Append("\n");
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
