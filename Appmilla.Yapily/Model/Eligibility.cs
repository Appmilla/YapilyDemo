using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Appmilla.Yapily.Model {

  /// <summary>
  /// Eligibility details for this product i.e. the criteria that an accountholder has to meet in order to be eligible for the PCA product.
  /// </summary>
  [DataContract]
  public class Eligibility {
    /// <summary>
    /// Gets or Sets AgeEligibility
    /// </summary>
    [DataMember(Name="AgeEligibility", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AgeEligibility")]
    public AgeEligibility AgeEligibility { get; set; }

    /// <summary>
    /// Gets or Sets CreditCheck
    /// </summary>
    [DataMember(Name="CreditCheck", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CreditCheck")]
    public CreditCheck CreditCheck { get; set; }

    /// <summary>
    /// Gets or Sets IDVerificationCheck
    /// </summary>
    [DataMember(Name="IDVerificationCheck", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IDVerificationCheck")]
    public IDVerificationCheck IDVerificationCheck { get; set; }

    /// <summary>
    /// Gets or Sets OtherEligibility
    /// </summary>
    [DataMember(Name="OtherEligibility", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "OtherEligibility")]
    public List<EligibilityOtherEligibility> OtherEligibility { get; set; }

    /// <summary>
    /// Gets or Sets ResidencyEligibility
    /// </summary>
    [DataMember(Name="ResidencyEligibility", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ResidencyEligibility")]
    public ResidencyEligibility ResidencyEligibility { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Eligibility {\n");
      sb.Append("  AgeEligibility: ").Append(AgeEligibility).Append("\n");
      sb.Append("  CreditCheck: ").Append(CreditCheck).Append("\n");
      sb.Append("  IDVerificationCheck: ").Append(IDVerificationCheck).Append("\n");
      sb.Append("  OtherEligibility: ").Append(OtherEligibility).Append("\n");
      sb.Append("  ResidencyEligibility: ").Append(ResidencyEligibility).Append("\n");
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
