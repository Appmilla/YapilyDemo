using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Appmilla.Yapily.Model {

  /// <summary>
  /// Provides overdraft details for a specific tier or band
  /// </summary>
  [DataContract]
  public class OverdraftOverdraftTierBand {
    /// <summary>
    /// Gets or Sets BankGuaranteedIndicator
    /// </summary>
    [DataMember(Name="BankGuaranteedIndicator", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "BankGuaranteedIndicator")]
    public bool? BankGuaranteedIndicator { get; set; }

    /// <summary>
    /// Gets or Sets EAR
    /// </summary>
    [DataMember(Name="EAR", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "EAR")]
    public string EAR { get; set; }

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
    /// Gets or Sets OverdraftFeesCharges
    /// </summary>
    [DataMember(Name="OverdraftFeesCharges", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "OverdraftFeesCharges")]
    public List<OverdraftOverdraftFeesCharges> OverdraftFeesCharges { get; set; }

    /// <summary>
    /// Gets or Sets OverdraftInterestChargingCoverage
    /// </summary>
    [DataMember(Name="OverdraftInterestChargingCoverage", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "OverdraftInterestChargingCoverage")]
    public string OverdraftInterestChargingCoverage { get; set; }

    /// <summary>
    /// Gets or Sets TierValueMax
    /// </summary>
    [DataMember(Name="TierValueMax", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TierValueMax")]
    public string TierValueMax { get; set; }

    /// <summary>
    /// Gets or Sets TierValueMin
    /// </summary>
    [DataMember(Name="TierValueMin", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TierValueMin")]
    public string TierValueMin { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class OverdraftOverdraftTierBand {\n");
      sb.Append("  BankGuaranteedIndicator: ").Append(BankGuaranteedIndicator).Append("\n");
      sb.Append("  EAR: ").Append(EAR).Append("\n");
      sb.Append("  Identification: ").Append(Identification).Append("\n");
      sb.Append("  Notes: ").Append(Notes).Append("\n");
      sb.Append("  OverdraftFeesCharges: ").Append(OverdraftFeesCharges).Append("\n");
      sb.Append("  OverdraftInterestChargingCoverage: ").Append(OverdraftInterestChargingCoverage).Append("\n");
      sb.Append("  TierValueMax: ").Append(TierValueMax).Append("\n");
      sb.Append("  TierValueMin: ").Append(TierValueMin).Append("\n");
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
