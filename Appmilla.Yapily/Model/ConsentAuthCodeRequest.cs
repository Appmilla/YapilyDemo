using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Appmilla.Yapily.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class ConsentAuthCodeRequest {
    /// <summary>
    /// Gets or Sets AuthCode
    /// </summary>
    [DataMember(Name="authCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "authCode")]
    public string AuthCode { get; set; }

    /// <summary>
    /// Gets or Sets AuthState
    /// </summary>
    [DataMember(Name="authState", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "authState")]
    public string AuthState { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ConsentAuthCodeRequest {\n");
      sb.Append("  AuthCode: ").Append(AuthCode).Append("\n");
      sb.Append("  AuthState: ").Append(AuthState).Append("\n");
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
