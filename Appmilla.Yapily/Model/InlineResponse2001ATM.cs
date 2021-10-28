using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Appmilla.Yapily.Model {

  /// <summary>
  /// ATM information.
  /// </summary>
  [DataContract]
  public class InlineResponse2001ATM {
    /// <summary>
    /// Gets or Sets ATMServices
    /// </summary>
    [DataMember(Name="ATMServices", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ATMServices")]
    public List<string> ATMServices { get; set; }

    /// <summary>
    /// Gets or Sets Access24HoursIndicator
    /// </summary>
    [DataMember(Name="Access24HoursIndicator", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Access24HoursIndicator")]
    public bool? Access24HoursIndicator { get; set; }

    /// <summary>
    /// Gets or Sets Accessibility
    /// </summary>
    [DataMember(Name="Accessibility", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Accessibility")]
    public List<string> Accessibility { get; set; }

    /// <summary>
    /// Gets or Sets Branch
    /// </summary>
    [DataMember(Name="Branch", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Branch")]
    public Branch Branch { get; set; }

    /// <summary>
    /// Gets or Sets Identification
    /// </summary>
    [DataMember(Name="Identification", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Identification")]
    public string Identification { get; set; }

    /// <summary>
    /// Gets or Sets Location
    /// </summary>
    [DataMember(Name="Location", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Location")]
    public Location Location { get; set; }

    /// <summary>
    /// Gets or Sets MinimumPossibleAmount
    /// </summary>
    [DataMember(Name="MinimumPossibleAmount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "MinimumPossibleAmount")]
    public string MinimumPossibleAmount { get; set; }

    /// <summary>
    /// Gets or Sets Note
    /// </summary>
    [DataMember(Name="Note", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Note")]
    public List<string> Note { get; set; }

    /// <summary>
    /// Gets or Sets OtherATMServices
    /// </summary>
    [DataMember(Name="OtherATMServices", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "OtherATMServices")]
    public List<InlineResponse2001OtherATMServices> OtherATMServices { get; set; }

    /// <summary>
    /// Gets or Sets OtherAccessibility
    /// </summary>
    [DataMember(Name="OtherAccessibility", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "OtherAccessibility")]
    public List<InlineResponse2001OtherAccessibility> OtherAccessibility { get; set; }

    /// <summary>
    /// Gets or Sets SupportedCurrencies
    /// </summary>
    [DataMember(Name="SupportedCurrencies", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SupportedCurrencies")]
    public List<string> SupportedCurrencies { get; set; }

    /// <summary>
    /// Gets or Sets SupportedLanguages
    /// </summary>
    [DataMember(Name="SupportedLanguages", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SupportedLanguages")]
    public List<string> SupportedLanguages { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class InlineResponse2001ATM {\n");
      sb.Append("  ATMServices: ").Append(ATMServices).Append("\n");
      sb.Append("  Access24HoursIndicator: ").Append(Access24HoursIndicator).Append("\n");
      sb.Append("  Accessibility: ").Append(Accessibility).Append("\n");
      sb.Append("  Branch: ").Append(Branch).Append("\n");
      sb.Append("  Identification: ").Append(Identification).Append("\n");
      sb.Append("  Location: ").Append(Location).Append("\n");
      sb.Append("  MinimumPossibleAmount: ").Append(MinimumPossibleAmount).Append("\n");
      sb.Append("  Note: ").Append(Note).Append("\n");
      sb.Append("  OtherATMServices: ").Append(OtherATMServices).Append("\n");
      sb.Append("  OtherAccessibility: ").Append(OtherAccessibility).Append("\n");
      sb.Append("  SupportedCurrencies: ").Append(SupportedCurrencies).Append("\n");
      sb.Append("  SupportedLanguages: ").Append(SupportedLanguages).Append("\n");
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
