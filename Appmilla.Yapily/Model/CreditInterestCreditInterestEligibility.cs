using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Appmilla.Yapily.Model {

  /// <summary>
  /// Eligibility for credit interest
  /// </summary>
  [DataContract]
  public class CreditInterestCreditInterestEligibility {
    /// <summary>
    /// Gets or Sets Amount
    /// </summary>
    [DataMember(Name="Amount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Amount")]
    public string Amount { get; set; }

    /// <summary>
    /// Gets or Sets Description
    /// </summary>
    [DataMember(Name="Description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Description")]
    public string Description { get; set; }

    /// <summary>
    /// Gets or Sets Indicator
    /// </summary>
    [DataMember(Name="Indicator", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Indicator")]
    public bool? Indicator { get; set; }

    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name="Name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Name")]
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets Notes
    /// </summary>
    [DataMember(Name="Notes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Notes")]
    public List<string> Notes { get; set; }

    /// <summary>
    /// Gets or Sets OtherType
    /// </summary>
    [DataMember(Name="OtherType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "OtherType")]
    public OtherType OtherType { get; set; }

    /// <summary>
    /// Gets or Sets Period
    /// </summary>
    [DataMember(Name="Period", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Period")]
    public string Period { get; set; }

    /// <summary>
    /// Gets or Sets Textual
    /// </summary>
    [DataMember(Name="Textual", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Textual")]
    public string Textual { get; set; }

    /// <summary>
    /// Gets or Sets Type
    /// </summary>
    [DataMember(Name="Type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Type")]
    public string Type { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class CreditInterestCreditInterestEligibility {\n");
      sb.Append("  Amount: ").Append(Amount).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  Indicator: ").Append(Indicator).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Notes: ").Append(Notes).Append("\n");
      sb.Append("  OtherType: ").Append(OtherType).Append("\n");
      sb.Append("  Period: ").Append(Period).Append("\n");
      sb.Append("  Textual: ").Append(Textual).Append("\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
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
