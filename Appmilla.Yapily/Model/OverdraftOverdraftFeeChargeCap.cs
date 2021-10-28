using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Appmilla.Yapily.Model {

  /// <summary>
  /// Details about any caps (maximum charges) that apply to a particular fee/charge
  /// </summary>
  [DataContract]
  public class OverdraftOverdraftFeeChargeCap {
    /// <summary>
    /// Gets or Sets CappingPeriod
    /// </summary>
    [DataMember(Name="CappingPeriod", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CappingPeriod")]
    public string CappingPeriod { get; set; }

    /// <summary>
    /// Gets or Sets FeeCapAmount
    /// </summary>
    [DataMember(Name="FeeCapAmount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "FeeCapAmount")]
    public string FeeCapAmount { get; set; }

    /// <summary>
    /// Gets or Sets FeeCapOccurrence
    /// </summary>
    [DataMember(Name="FeeCapOccurrence", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "FeeCapOccurrence")]
    public float? FeeCapOccurrence { get; set; }

    /// <summary>
    /// Gets or Sets FeeType
    /// </summary>
    [DataMember(Name="FeeType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "FeeType")]
    public List<string> FeeType { get; set; }

    /// <summary>
    /// Gets or Sets MinMaxType
    /// </summary>
    [DataMember(Name="MinMaxType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "MinMaxType")]
    public string MinMaxType { get; set; }

    /// <summary>
    /// Gets or Sets Notes
    /// </summary>
    [DataMember(Name="Notes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Notes")]
    public List<string> Notes { get; set; }

    /// <summary>
    /// Gets or Sets OtherFeeType
    /// </summary>
    [DataMember(Name="OtherFeeType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "OtherFeeType")]
    public List<OverdraftOtherFeeType> OtherFeeType { get; set; }

    /// <summary>
    /// Gets or Sets OverdraftControlIndicator
    /// </summary>
    [DataMember(Name="OverdraftControlIndicator", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "OverdraftControlIndicator")]
    public bool? OverdraftControlIndicator { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class OverdraftOverdraftFeeChargeCap {\n");
      sb.Append("  CappingPeriod: ").Append(CappingPeriod).Append("\n");
      sb.Append("  FeeCapAmount: ").Append(FeeCapAmount).Append("\n");
      sb.Append("  FeeCapOccurrence: ").Append(FeeCapOccurrence).Append("\n");
      sb.Append("  FeeType: ").Append(FeeType).Append("\n");
      sb.Append("  MinMaxType: ").Append(MinMaxType).Append("\n");
      sb.Append("  Notes: ").Append(Notes).Append("\n");
      sb.Append("  OtherFeeType: ").Append(OtherFeeType).Append("\n");
      sb.Append("  OverdraftControlIndicator: ").Append(OverdraftControlIndicator).Append("\n");
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
