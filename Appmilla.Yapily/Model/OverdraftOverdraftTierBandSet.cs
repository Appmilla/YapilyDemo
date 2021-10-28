using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Appmilla.Yapily.Model {

  /// <summary>
  /// Tier band set details
  /// </summary>
  [DataContract]
  public class OverdraftOverdraftTierBandSet {
    /// <summary>
    /// Gets or Sets AuthorisedIndicator
    /// </summary>
    [DataMember(Name="AuthorisedIndicator", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AuthorisedIndicator")]
    public bool? AuthorisedIndicator { get; set; }

    /// <summary>
    /// Gets or Sets BufferAmount
    /// </summary>
    [DataMember(Name="BufferAmount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "BufferAmount")]
    public string BufferAmount { get; set; }

    /// <summary>
    /// Gets or Sets Identification
    /// </summary>
    [DataMember(Name="Identification", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Identification")]
    public string Identification { get; set; }

    /// <summary>
    /// Gets or Sets MinimumArrangedOverdraftAmount
    /// </summary>
    [DataMember(Name="MinimumArrangedOverdraftAmount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "MinimumArrangedOverdraftAmount")]
    public string MinimumArrangedOverdraftAmount { get; set; }

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
    public List<OverdraftOverdraftFeesCharges1> OverdraftFeesCharges { get; set; }

    /// <summary>
    /// Gets or Sets OverdraftTierBand
    /// </summary>
    [DataMember(Name="OverdraftTierBand", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "OverdraftTierBand")]
    public List<OverdraftOverdraftTierBand> OverdraftTierBand { get; set; }

    /// <summary>
    /// Gets or Sets OverdraftType
    /// </summary>
    [DataMember(Name="OverdraftType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "OverdraftType")]
    public string OverdraftType { get; set; }

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
      sb.Append("class OverdraftOverdraftTierBandSet {\n");
      sb.Append("  AuthorisedIndicator: ").Append(AuthorisedIndicator).Append("\n");
      sb.Append("  BufferAmount: ").Append(BufferAmount).Append("\n");
      sb.Append("  Identification: ").Append(Identification).Append("\n");
      sb.Append("  MinimumArrangedOverdraftAmount: ").Append(MinimumArrangedOverdraftAmount).Append("\n");
      sb.Append("  Notes: ").Append(Notes).Append("\n");
      sb.Append("  OverdraftFeesCharges: ").Append(OverdraftFeesCharges).Append("\n");
      sb.Append("  OverdraftTierBand: ").Append(OverdraftTierBand).Append("\n");
      sb.Append("  OverdraftType: ").Append(OverdraftType).Append("\n");
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
