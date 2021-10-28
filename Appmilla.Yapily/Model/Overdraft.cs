using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Appmilla.Yapily.Model {

  /// <summary>
  /// Borrowing details
  /// </summary>
  [DataContract]
  public class Overdraft {
    /// <summary>
    /// Gets or Sets Notes
    /// </summary>
    [DataMember(Name="Notes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Notes")]
    public List<string> Notes { get; set; }

    /// <summary>
    /// Gets or Sets OverdraftTierBandSet
    /// </summary>
    [DataMember(Name="OverdraftTierBandSet", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "OverdraftTierBandSet")]
    public List<OverdraftOverdraftTierBandSet> OverdraftTierBandSet { get; set; }

    /// <summary>
    /// Gets or Sets TcsAndCsURL
    /// </summary>
    [DataMember(Name="TcsAndCsURL", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TcsAndCsURL")]
    public string TcsAndCsURL { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Overdraft {\n");
      sb.Append("  Notes: ").Append(Notes).Append("\n");
      sb.Append("  OverdraftTierBandSet: ").Append(OverdraftTierBandSet).Append("\n");
      sb.Append("  TcsAndCsURL: ").Append(TcsAndCsURL).Append("\n");
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
