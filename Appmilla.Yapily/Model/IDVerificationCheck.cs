using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Appmilla.Yapily.Model {

  /// <summary>
  /// Identity verification criteria that the account holder will need to meet to take out the PCA product
  /// </summary>
  [DataContract]
  public class IDVerificationCheck {
    /// <summary>
    /// Gets or Sets Notes
    /// </summary>
    [DataMember(Name="Notes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Notes")]
    public List<string> Notes { get; set; }

    /// <summary>
    /// Gets or Sets URL
    /// </summary>
    [DataMember(Name="URL", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "URL")]
    public string URL { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class IDVerificationCheck {\n");
      sb.Append("  Notes: ").Append(Notes).Append("\n");
      sb.Append("  URL: ").Append(URL).Append("\n");
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
