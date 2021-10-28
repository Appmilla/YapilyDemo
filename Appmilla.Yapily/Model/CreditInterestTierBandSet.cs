using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Appmilla.Yapily.Model {

  /// <summary>
  /// The group of tiers or bands for which credit interest can be applied.
  /// </summary>
  [DataContract]
  public class CreditInterestTierBandSet {
    /// <summary>
    /// Gets or Sets CalculationMethod
    /// </summary>
    [DataMember(Name="CalculationMethod", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CalculationMethod")]
    public string CalculationMethod { get; set; }

    /// <summary>
    /// Gets or Sets CreditInterestEligibility
    /// </summary>
    [DataMember(Name="CreditInterestEligibility", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CreditInterestEligibility")]
    public List<CreditInterestCreditInterestEligibility> CreditInterestEligibility { get; set; }

    /// <summary>
    /// Gets or Sets Destination
    /// </summary>
    [DataMember(Name="Destination", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Destination")]
    public string Destination { get; set; }

    /// <summary>
    /// Gets or Sets Notes
    /// </summary>
    [DataMember(Name="Notes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Notes")]
    public List<string> Notes { get; set; }

    /// <summary>
    /// Gets or Sets TierBand
    /// </summary>
    [DataMember(Name="TierBand", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TierBand")]
    public List<CreditInterestTierBand> TierBand { get; set; }

    /// <summary>
    /// Gets or Sets TierBandMethod
    /// </summary>
    [DataMember(Name="TierBandMethod", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TierBandMethod")]
    public string TierBandMethod { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class CreditInterestTierBandSet {\n");
      sb.Append("  CalculationMethod: ").Append(CalculationMethod).Append("\n");
      sb.Append("  CreditInterestEligibility: ").Append(CreditInterestEligibility).Append("\n");
      sb.Append("  Destination: ").Append(Destination).Append("\n");
      sb.Append("  Notes: ").Append(Notes).Append("\n");
      sb.Append("  TierBand: ").Append(TierBand).Append("\n");
      sb.Append("  TierBandMethod: ").Append(TierBandMethod).Append("\n");
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
