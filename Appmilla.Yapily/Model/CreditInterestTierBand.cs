using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Appmilla.Yapily.Model {

  /// <summary>
  /// Tier Band Details
  /// </summary>
  [DataContract]
  public class CreditInterestTierBand {
    /// <summary>
    /// Gets or Sets AER
    /// </summary>
    [DataMember(Name="AER", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AER")]
    public string AER { get; set; }

    /// <summary>
    /// Gets or Sets ApplicationFrequency
    /// </summary>
    [DataMember(Name="ApplicationFrequency", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ApplicationFrequency")]
    public string ApplicationFrequency { get; set; }

    /// <summary>
    /// Gets or Sets BankInterestRate
    /// </summary>
    [DataMember(Name="BankInterestRate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "BankInterestRate")]
    public string BankInterestRate { get; set; }

    /// <summary>
    /// Gets or Sets BankInterestRateType
    /// </summary>
    [DataMember(Name="BankInterestRateType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "BankInterestRateType")]
    public string BankInterestRateType { get; set; }

    /// <summary>
    /// Gets or Sets CalculationFrequency
    /// </summary>
    [DataMember(Name="CalculationFrequency", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CalculationFrequency")]
    public string CalculationFrequency { get; set; }

    /// <summary>
    /// Gets or Sets DepositInterestAppliedCoverage
    /// </summary>
    [DataMember(Name="DepositInterestAppliedCoverage", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DepositInterestAppliedCoverage")]
    public string DepositInterestAppliedCoverage { get; set; }

    /// <summary>
    /// Gets or Sets FixedVariableInterestRateType
    /// </summary>
    [DataMember(Name="FixedVariableInterestRateType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "FixedVariableInterestRateType")]
    public string FixedVariableInterestRateType { get; set; }

    /// <summary>
    /// Gets or Sets Identification
    /// </summary>
    [DataMember(Name="Identification", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Identification")]
    public string Identification { get; set; }

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
    /// Gets or Sets OtherBankInterestType
    /// </summary>
    [DataMember(Name="OtherBankInterestType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "OtherBankInterestType")]
    public OtherBankInterestType OtherBankInterestType { get; set; }

    /// <summary>
    /// Gets or Sets OtherCalculationFrequency
    /// </summary>
    [DataMember(Name="OtherCalculationFrequency", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "OtherCalculationFrequency")]
    public OtherCalculationFrequency OtherCalculationFrequency { get; set; }

    /// <summary>
    /// Gets or Sets TierValueMaximum
    /// </summary>
    [DataMember(Name="TierValueMaximum", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TierValueMaximum")]
    public string TierValueMaximum { get; set; }

    /// <summary>
    /// Gets or Sets TierValueMinimum
    /// </summary>
    [DataMember(Name="TierValueMinimum", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TierValueMinimum")]
    public string TierValueMinimum { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class CreditInterestTierBand {\n");
      sb.Append("  AER: ").Append(AER).Append("\n");
      sb.Append("  ApplicationFrequency: ").Append(ApplicationFrequency).Append("\n");
      sb.Append("  BankInterestRate: ").Append(BankInterestRate).Append("\n");
      sb.Append("  BankInterestRateType: ").Append(BankInterestRateType).Append("\n");
      sb.Append("  CalculationFrequency: ").Append(CalculationFrequency).Append("\n");
      sb.Append("  DepositInterestAppliedCoverage: ").Append(DepositInterestAppliedCoverage).Append("\n");
      sb.Append("  FixedVariableInterestRateType: ").Append(FixedVariableInterestRateType).Append("\n");
      sb.Append("  Identification: ").Append(Identification).Append("\n");
      sb.Append("  Notes: ").Append(Notes).Append("\n");
      sb.Append("  OtherApplicationFrequency: ").Append(OtherApplicationFrequency).Append("\n");
      sb.Append("  OtherBankInterestType: ").Append(OtherBankInterestType).Append("\n");
      sb.Append("  OtherCalculationFrequency: ").Append(OtherCalculationFrequency).Append("\n");
      sb.Append("  TierValueMaximum: ").Append(TierValueMaximum).Append("\n");
      sb.Append("  TierValueMinimum: ").Append(TierValueMinimum).Append("\n");
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
