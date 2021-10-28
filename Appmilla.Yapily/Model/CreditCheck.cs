using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Appmilla.Yapily.Model {

  /// <summary>
  /// Credit check criteria that the account holder will need to meet to take out the PCA product
  /// </summary>
  [DataContract]
  public class CreditCheck {
    /// <summary>
    /// Gets or Sets Notes
    /// </summary>
    [DataMember(Name="Notes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Notes")]
    public List<string> Notes { get; set; }

    /// <summary>
    /// Gets or Sets ScoringType
    /// </summary>
    [DataMember(Name="ScoringType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ScoringType")]
    public string ScoringType { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class CreditCheck {\n");
      sb.Append("  Notes: ").Append(Notes).Append("\n");
      sb.Append("  ScoringType: ").Append(ScoringType).Append("\n");
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
