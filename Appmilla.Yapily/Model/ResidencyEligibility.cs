using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Appmilla.Yapily.Model {

  /// <summary>
  /// Countries in which an accountholder can reside and, therefore, be eligible to open an account
  /// </summary>
  [DataContract]
  public class ResidencyEligibility {
    /// <summary>
    /// Gets or Sets Notes
    /// </summary>
    [DataMember(Name="Notes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Notes")]
    public List<string> Notes { get; set; }

    /// <summary>
    /// Gets or Sets OtherResidencyType
    /// </summary>
    [DataMember(Name="OtherResidencyType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "OtherResidencyType")]
    public OtherResidencyType OtherResidencyType { get; set; }

    /// <summary>
    /// Gets or Sets ResidencyIncluded
    /// </summary>
    [DataMember(Name="ResidencyIncluded", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ResidencyIncluded")]
    public List<string> ResidencyIncluded { get; set; }

    /// <summary>
    /// Gets or Sets ResidencyType
    /// </summary>
    [DataMember(Name="ResidencyType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ResidencyType")]
    public string ResidencyType { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ResidencyEligibility {\n");
      sb.Append("  Notes: ").Append(Notes).Append("\n");
      sb.Append("  OtherResidencyType: ").Append(OtherResidencyType).Append("\n");
      sb.Append("  ResidencyIncluded: ").Append(ResidencyIncluded).Append("\n");
      sb.Append("  ResidencyType: ").Append(ResidencyType).Append("\n");
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
