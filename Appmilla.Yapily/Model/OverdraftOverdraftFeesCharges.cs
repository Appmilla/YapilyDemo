using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Appmilla.Yapily.Model {

  /// <summary>
  /// Overdraft fees and charges
  /// </summary>
  [DataContract]
  public class OverdraftOverdraftFeesCharges {
    /// <summary>
    /// Gets or Sets OverdraftFeeChargeCap
    /// </summary>
    [DataMember(Name="OverdraftFeeChargeCap", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "OverdraftFeeChargeCap")]
    public List<OverdraftOverdraftFeeChargeCap> OverdraftFeeChargeCap { get; set; }

    /// <summary>
    /// Gets or Sets OverdraftFeeChargeDetail
    /// </summary>
    [DataMember(Name="OverdraftFeeChargeDetail", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "OverdraftFeeChargeDetail")]
    public List<OverdraftOverdraftFeeChargeDetail> OverdraftFeeChargeDetail { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class OverdraftOverdraftFeesCharges {\n");
      sb.Append("  OverdraftFeeChargeCap: ").Append(OverdraftFeeChargeCap).Append("\n");
      sb.Append("  OverdraftFeeChargeDetail: ").Append(OverdraftFeeChargeDetail).Append("\n");
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
