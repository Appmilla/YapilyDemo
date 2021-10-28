using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Appmilla.Yapily.Model {

  /// <summary>
  /// Details about the fees/charges
  /// </summary>
  [DataContract]
  public class OverdraftOverdraftFeeChargeDetail {
    /// <summary>
    /// Gets or Sets ApplicationFrequency
    /// </summary>
    [DataMember(Name="ApplicationFrequency", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ApplicationFrequency")]
    public string ApplicationFrequency { get; set; }

    /// <summary>
    /// Gets or Sets CalculationFrequency
    /// </summary>
    [DataMember(Name="CalculationFrequency", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CalculationFrequency")]
    public string CalculationFrequency { get; set; }

    /// <summary>
    /// Gets or Sets FeeAmount
    /// </summary>
    [DataMember(Name="FeeAmount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "FeeAmount")]
    public string FeeAmount { get; set; }

    /// <summary>
    /// Gets or Sets FeeRate
    /// </summary>
    [DataMember(Name="FeeRate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "FeeRate")]
    public string FeeRate { get; set; }

    /// <summary>
    /// Gets or Sets FeeRateType
    /// </summary>
    [DataMember(Name="FeeRateType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "FeeRateType")]
    public string FeeRateType { get; set; }

    /// <summary>
    /// Gets or Sets FeeType
    /// </summary>
    [DataMember(Name="FeeType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "FeeType")]
    public string FeeType { get; set; }

    /// <summary>
    /// Gets or Sets IncrementalBorrowingAmount
    /// </summary>
    [DataMember(Name="IncrementalBorrowingAmount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IncrementalBorrowingAmount")]
    public string IncrementalBorrowingAmount { get; set; }

    /// <summary>
    /// Gets or Sets Notes
    /// </summary>
    [DataMember(Name="Notes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Notes")]
    public List<string> Notes { get; set; }

    /// <summary>
    /// Gets or Sets OtherApplicationFrequency
    /// </summary>
    [DataMember(Name="OtherApplicationFrequency", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "OtherApplicationFrequency")]
    public OtherApplicationFrequency OtherApplicationFrequency { get; set; }

    /// <summary>
    /// Gets or Sets OtherCalculationFrequency
    /// </summary>
    [DataMember(Name="OtherCalculationFrequency", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "OtherCalculationFrequency")]
    public OtherCalculationFrequency OtherCalculationFrequency { get; set; }

    /// <summary>
    /// Gets or Sets OtherFeeRateType
    /// </summary>
    [DataMember(Name="OtherFeeRateType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "OtherFeeRateType")]
    public OtherFeeRateType OtherFeeRateType { get; set; }

    /// <summary>
    /// Gets or Sets OtherFeeType
    /// </summary>
    [DataMember(Name="OtherFeeType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "OtherFeeType")]
    public OtherFeeType OtherFeeType { get; set; }

    /// <summary>
    /// Gets or Sets OverdraftControlIndicator
    /// </summary>
    [DataMember(Name="OverdraftControlIndicator", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "OverdraftControlIndicator")]
    public bool? OverdraftControlIndicator { get; set; }

    /// <summary>
    /// Gets or Sets OverdraftFeeChargeCap
    /// </summary>
    [DataMember(Name="OverdraftFeeChargeCap", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "OverdraftFeeChargeCap")]
    public OverdraftOverdraftFeeChargeCap OverdraftFeeChargeCap { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class OverdraftOverdraftFeeChargeDetail {\n");
      sb.Append("  ApplicationFrequency: ").Append(ApplicationFrequency).Append("\n");
      sb.Append("  CalculationFrequency: ").Append(CalculationFrequency).Append("\n");
      sb.Append("  FeeAmount: ").Append(FeeAmount).Append("\n");
      sb.Append("  FeeRate: ").Append(FeeRate).Append("\n");
      sb.Append("  FeeRateType: ").Append(FeeRateType).Append("\n");
      sb.Append("  FeeType: ").Append(FeeType).Append("\n");
      sb.Append("  IncrementalBorrowingAmount: ").Append(IncrementalBorrowingAmount).Append("\n");
      sb.Append("  Notes: ").Append(Notes).Append("\n");
      sb.Append("  OtherApplicationFrequency: ").Append(OtherApplicationFrequency).Append("\n");
      sb.Append("  OtherCalculationFrequency: ").Append(OtherCalculationFrequency).Append("\n");
      sb.Append("  OtherFeeRateType: ").Append(OtherFeeRateType).Append("\n");
      sb.Append("  OtherFeeType: ").Append(OtherFeeType).Append("\n");
      sb.Append("  OverdraftControlIndicator: ").Append(OverdraftControlIndicator).Append("\n");
      sb.Append("  OverdraftFeeChargeCap: ").Append(OverdraftFeeChargeCap).Append("\n");
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
