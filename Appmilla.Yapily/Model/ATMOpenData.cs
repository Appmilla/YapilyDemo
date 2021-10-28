using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Appmilla.Yapily.Model {

  /// <summary>
  /// Environment of the ATM.
  /// </summary>
  [DataContract]
  public class ATMOpenData {
    /// <summary>
    /// Gets or Sets Brand
    /// </summary>
    [DataMember(Name="Brand", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Brand")]
    public List<ATMOpenDataBrand> Brand { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ATMOpenData {\n");
      sb.Append("  Brand: ").Append(Brand).Append("\n");
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
