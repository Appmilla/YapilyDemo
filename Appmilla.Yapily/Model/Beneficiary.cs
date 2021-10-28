using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Appmilla.Yapily.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class Beneficiary {
    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }

    /// <summary>
    /// Gets or Sets Trusted
    /// </summary>
    [DataMember(Name="trusted", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "trusted")]
    public bool? Trusted { get; set; }

    /// <summary>
    /// Gets or Sets Reference
    /// </summary>
    [DataMember(Name="reference", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "reference")]
    public string Reference { get; set; }

    /// <summary>
    /// Gets or Sets Payee
    /// </summary>
    [DataMember(Name="payee", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "payee")]
    public Payee Payee { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Beneficiary {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Trusted: ").Append(Trusted).Append("\n");
      sb.Append("  Reference: ").Append(Reference).Append("\n");
      sb.Append("  Payee: ").Append(Payee).Append("\n");
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
