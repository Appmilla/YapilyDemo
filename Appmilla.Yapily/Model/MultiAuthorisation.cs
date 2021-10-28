using System;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Appmilla.Yapily.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class MultiAuthorisation {
    /// <summary>
    /// Gets or Sets Status
    /// </summary>
    [DataMember(Name="status", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "status")]
    public string Status { get; set; }

    /// <summary>
    /// Gets or Sets NumberOfAuthorisationRequired
    /// </summary>
    [DataMember(Name="numberOfAuthorisationRequired", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "numberOfAuthorisationRequired")]
    public int? NumberOfAuthorisationRequired { get; set; }

    /// <summary>
    /// Gets or Sets NumberOfAuthorisationReceived
    /// </summary>
    [DataMember(Name="numberOfAuthorisationReceived", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "numberOfAuthorisationReceived")]
    public int? NumberOfAuthorisationReceived { get; set; }

    /// <summary>
    /// Gets or Sets LastUpdatedDateTime
    /// </summary>
    [DataMember(Name="lastUpdatedDateTime", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lastUpdatedDateTime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    /// <summary>
    /// Gets or Sets ExpirationDateTime
    /// </summary>
    [DataMember(Name="expirationDateTime", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "expirationDateTime")]
    public DateTime? ExpirationDateTime { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class MultiAuthorisation {\n");
      sb.Append("  Status: ").Append(Status).Append("\n");
      sb.Append("  NumberOfAuthorisationRequired: ").Append(NumberOfAuthorisationRequired).Append("\n");
      sb.Append("  NumberOfAuthorisationReceived: ").Append(NumberOfAuthorisationReceived).Append("\n");
      sb.Append("  LastUpdatedDateTime: ").Append(LastUpdatedDateTime).Append("\n");
      sb.Append("  ExpirationDateTime: ").Append(ExpirationDateTime).Append("\n");
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
