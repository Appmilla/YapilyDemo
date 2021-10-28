using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Appmilla.Yapily.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class RegistrationResult {
    /// <summary>
    /// Gets or Sets ApplicationId
    /// </summary>
    [DataMember(Name="applicationId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "applicationId")]
    public string ApplicationId { get; set; }

    /// <summary>
    /// Gets or Sets InstitutionId
    /// </summary>
    [DataMember(Name="institutionId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "institutionId")]
    public string InstitutionId { get; set; }

    /// <summary>
    /// Gets or Sets TppId
    /// </summary>
    [DataMember(Name="tppId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tppId")]
    public string TppId { get; set; }

    /// <summary>
    /// Gets or Sets SoftwareId
    /// </summary>
    [DataMember(Name="softwareId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "softwareId")]
    public string SoftwareId { get; set; }

    /// <summary>
    /// Gets or Sets ClientName
    /// </summary>
    [DataMember(Name="clientName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "clientName")]
    public string ClientName { get; set; }

    /// <summary>
    /// Gets or Sets SigningKeyId
    /// </summary>
    [DataMember(Name="signingKeyId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "signingKeyId")]
    public string SigningKeyId { get; set; }

    /// <summary>
    /// Gets or Sets SigningCertificateId
    /// </summary>
    [DataMember(Name="signingCertificateId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "signingCertificateId")]
    public string SigningCertificateId { get; set; }

    /// <summary>
    /// Gets or Sets TransportKeyId
    /// </summary>
    [DataMember(Name="transportKeyId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "transportKeyId")]
    public string TransportKeyId { get; set; }

    /// <summary>
    /// Gets or Sets TransportCertificateId
    /// </summary>
    [DataMember(Name="transportCertificateId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "transportCertificateId")]
    public string TransportCertificateId { get; set; }

    /// <summary>
    /// Gets or Sets ClientUri
    /// </summary>
    [DataMember(Name="clientUri", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "clientUri")]
    public string ClientUri { get; set; }

    /// <summary>
    /// Gets or Sets TermsOfServiceUri
    /// </summary>
    [DataMember(Name="termsOfServiceUri", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "termsOfServiceUri")]
    public string TermsOfServiceUri { get; set; }

    /// <summary>
    /// Gets or Sets SsaJwt
    /// </summary>
    [DataMember(Name="ssaJwt", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ssaJwt")]
    public string SsaJwt { get; set; }

    /// <summary>
    /// Gets or Sets ClientId
    /// </summary>
    [DataMember(Name="clientId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "clientId")]
    public string ClientId { get; set; }

    /// <summary>
    /// Gets or Sets ClientSecret
    /// </summary>
    [DataMember(Name="clientSecret", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "clientSecret")]
    public string ClientSecret { get; set; }

    /// <summary>
    /// Gets or Sets SigningKeyStore
    /// </summary>
    [DataMember(Name="signingKeyStore", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "signingKeyStore")]
    public string SigningKeyStore { get; set; }

    /// <summary>
    /// Gets or Sets TransportKeyStore
    /// </summary>
    [DataMember(Name="transportKeyStore", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "transportKeyStore")]
    public string TransportKeyStore { get; set; }

    /// <summary>
    /// Gets or Sets RegistrationResponse
    /// </summary>
    [DataMember(Name="registrationResponse", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "registrationResponse")]
    public string RegistrationResponse { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class RegistrationResult {\n");
      sb.Append("  ApplicationId: ").Append(ApplicationId).Append("\n");
      sb.Append("  InstitutionId: ").Append(InstitutionId).Append("\n");
      sb.Append("  TppId: ").Append(TppId).Append("\n");
      sb.Append("  SoftwareId: ").Append(SoftwareId).Append("\n");
      sb.Append("  ClientName: ").Append(ClientName).Append("\n");
      sb.Append("  SigningKeyId: ").Append(SigningKeyId).Append("\n");
      sb.Append("  SigningCertificateId: ").Append(SigningCertificateId).Append("\n");
      sb.Append("  TransportKeyId: ").Append(TransportKeyId).Append("\n");
      sb.Append("  TransportCertificateId: ").Append(TransportCertificateId).Append("\n");
      sb.Append("  ClientUri: ").Append(ClientUri).Append("\n");
      sb.Append("  TermsOfServiceUri: ").Append(TermsOfServiceUri).Append("\n");
      sb.Append("  SsaJwt: ").Append(SsaJwt).Append("\n");
      sb.Append("  ClientId: ").Append(ClientId).Append("\n");
      sb.Append("  ClientSecret: ").Append(ClientSecret).Append("\n");
      sb.Append("  SigningKeyStore: ").Append(SigningKeyStore).Append("\n");
      sb.Append("  TransportKeyStore: ").Append(TransportKeyStore).Append("\n");
      sb.Append("  RegistrationResponse: ").Append(RegistrationResponse).Append("\n");
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
