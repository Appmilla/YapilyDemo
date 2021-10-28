using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Appmilla.Yapily.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class InstitutionError {
    /// <summary>
    /// Gets or Sets ErrorMessage
    /// </summary>
    [DataMember(Name="errorMessage", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "errorMessage")]
    public string ErrorMessage { get; set; }

    /// <summary>
    /// Gets or Sets HttpStatusCode
    /// </summary>
    [DataMember(Name="httpStatusCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "httpStatusCode")]
    public int? HttpStatusCode { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class InstitutionError {\n");
      sb.Append("  ErrorMessage: ").Append(ErrorMessage).Append("\n");
      sb.Append("  HttpStatusCode: ").Append(HttpStatusCode).Append("\n");
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
