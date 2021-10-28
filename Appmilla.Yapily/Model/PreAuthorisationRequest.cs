using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Appmilla.Yapily.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class PreAuthorisationRequest {
    /// <summary>
    /// Defines the scope of the pre-authorisation request.
    /// </summary>
    /// <value>Defines the scope of the pre-authorisation request.</value>
    [DataMember(Name="scope", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "scope")]
    public string Scope { get; set; }

    /// <summary>
    /// Uuid of the application user who will authorise access to their data. Either the userUuid or applicationUserId must be provided.
    /// </summary>
    /// <value>Uuid of the application user who will authorise access to their data. Either the userUuid or applicationUserId must be provided.</value>
    [DataMember(Name="userUuid", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "userUuid")]
    public string UserUuid { get; set; }

    /// <summary>
    /// Descriptive identifier for the application user.Either the userUuid or applicationUserId must be provided.
    /// </summary>
    /// <value>Descriptive identifier for the application user.Either the userUuid or applicationUserId must be provided.</value>
    [DataMember(Name="applicationUserId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "applicationUserId")]
    public string ApplicationUserId { get; set; }

    /// <summary>
    /// Gets or Sets ForwardParameters
    /// </summary>
    [DataMember(Name="forwardParameters", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "forwardParameters")]
    public List<string> ForwardParameters { get; set; }

    /// <summary>
    /// Gets or Sets InstitutionId
    /// </summary>
    [DataMember(Name="institutionId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "institutionId")]
    public string InstitutionId { get; set; }

    /// <summary>
    /// Gets or Sets Callback
    /// </summary>
    [DataMember(Name="callback", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "callback")]
    public string Callback { get; set; }

    /// <summary>
    /// Gets or Sets Redirect
    /// </summary>
    [DataMember(Name="redirect", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "redirect")]
    public RedirectRequest Redirect { get; set; }

    /// <summary>
    /// Gets or Sets OneTimeToken
    /// </summary>
    [DataMember(Name="oneTimeToken", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "oneTimeToken")]
    public bool? OneTimeToken { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PreAuthorisationRequest {\n");
      sb.Append("  Scope: ").Append(Scope).Append("\n");
      sb.Append("  UserUuid: ").Append(UserUuid).Append("\n");
      sb.Append("  ApplicationUserId: ").Append(ApplicationUserId).Append("\n");
      sb.Append("  ForwardParameters: ").Append(ForwardParameters).Append("\n");
      sb.Append("  InstitutionId: ").Append(InstitutionId).Append("\n");
      sb.Append("  Callback: ").Append(Callback).Append("\n");
      sb.Append("  Redirect: ").Append(Redirect).Append("\n");
      sb.Append("  OneTimeToken: ").Append(OneTimeToken).Append("\n");
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
