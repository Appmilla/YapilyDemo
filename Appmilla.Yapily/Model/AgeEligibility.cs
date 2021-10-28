using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Appmilla.Yapily.Model {

  /// <summary>
  /// Age eligibility that a person should be to hold this account
  /// </summary>
  [DataContract]
  public class AgeEligibility {
    /// <summary>
    /// Gets or Sets MaximumAge
    /// </summary>
    [DataMember(Name="MaximumAge", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "MaximumAge")]
    public float? MaximumAge { get; set; }

    /// <summary>
    /// Gets or Sets MinimumAge
    /// </summary>
    [DataMember(Name="MinimumAge", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "MinimumAge")]
    public float? MinimumAge { get; set; }

    /// <summary>
    /// Gets or Sets Notes
    /// </summary>
    [DataMember(Name="Notes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Notes")]
    public List<string> Notes { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AgeEligibility {\n");
      sb.Append("  MaximumAge: ").Append(MaximumAge).Append("\n");
      sb.Append("  MinimumAge: ").Append(MinimumAge).Append("\n");
      sb.Append("  Notes: ").Append(Notes).Append("\n");
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
