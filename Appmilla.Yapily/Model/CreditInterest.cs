using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Appmilla.Yapily.Model {

  /// <summary>
  /// Details about the interest that may be payable to the PCA account holders
  /// </summary>
  [DataContract]
  public class CreditInterest {
    /// <summary>
    /// Gets or Sets TierBandSet
    /// </summary>
    [DataMember(Name="TierBandSet", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TierBandSet")]
    public List<CreditInterestTierBandSet> TierBandSet { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class CreditInterest {\n");
      sb.Append("  TierBandSet: ").Append(TierBandSet).Append("\n");
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
