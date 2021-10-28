using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Appmilla.Yapily.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class RegistrationRequestAuto {
    /// <summary>
    /// Gets or Sets SoftwareId
    /// </summary>
    [DataMember(Name="softwareId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "softwareId")]
    public string SoftwareId { get; set; }

    /// <summary>
    /// Gets or Sets SigningCertificateId
    /// </summary>
    [DataMember(Name="signingCertificateId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "signingCertificateId")]
    public string SigningCertificateId { get; set; }

    /// <summary>
    /// Gets or Sets TransportCertificateId
    /// </summary>
    [DataMember(Name="transportCertificateId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "transportCertificateId")]
    public string TransportCertificateId { get; set; }

    /// <summary>
    /// Gets or Sets SsaJwt
    /// </summary>
    [DataMember(Name="ssaJwt", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ssaJwt")]
    public string SsaJwt { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class RegistrationRequestAuto {\n");
      sb.Append("  SoftwareId: ").Append(SoftwareId).Append("\n");
      sb.Append("  SigningCertificateId: ").Append(SigningCertificateId).Append("\n");
      sb.Append("  TransportCertificateId: ").Append(TransportCertificateId).Append("\n");
      sb.Append("  SsaJwt: ").Append(SsaJwt).Append("\n");
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
