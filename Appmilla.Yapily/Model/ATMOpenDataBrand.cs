using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Appmilla.Yapily.Model {

  /// <summary>
  /// Brand of the Acquirer of transactions captured by the ATM
  /// </summary>
  [DataContract]
  public class ATMOpenDataBrand {
    /// <summary>
    /// Gets or Sets ATM
    /// </summary>
    [DataMember(Name="ATM", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ATM")]
    public List<InlineResponse2001ATM> ATM { get; set; }

    /// <summary>
    /// Gets or Sets BrandName
    /// </summary>
    [DataMember(Name="BrandName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "BrandName")]
    public string BrandName { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ATMOpenDataBrand {\n");
      sb.Append("  ATM: ").Append(ATM).Append("\n");
      sb.Append("  BrandName: ").Append(BrandName).Append("\n");
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
