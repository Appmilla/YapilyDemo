using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Appmilla.Yapily.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class PaymentAuthorisationRequestResponse {
    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }

    /// <summary>
    /// Gets or Sets UserUuid
    /// </summary>
    [DataMember(Name="userUuid", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "userUuid")]
    public string UserUuid { get; set; }

    /// <summary>
    /// Gets or Sets ApplicationUserId
    /// </summary>
    [DataMember(Name="applicationUserId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "applicationUserId")]
    public string ApplicationUserId { get; set; }

    /// <summary>
    /// Gets or Sets ReferenceId
    /// </summary>
    [DataMember(Name="referenceId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "referenceId")]
    public string ReferenceId { get; set; }

    /// <summary>
    /// Gets or Sets InstitutionId
    /// </summary>
    [DataMember(Name="institutionId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "institutionId")]
    public string InstitutionId { get; set; }

    /// <summary>
    /// Gets or Sets Status
    /// </summary>
    [DataMember(Name="status", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "status")]
    public string Status { get; set; }

    /// <summary>
    /// Gets or Sets CreatedAt
    /// </summary>
    [DataMember(Name="createdAt", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "createdAt")]
    public DateTime? CreatedAt { get; set; }

    /// <summary>
    /// Gets or Sets TransactionFrom
    /// </summary>
    [DataMember(Name="transactionFrom", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "transactionFrom")]
    public DateTime? TransactionFrom { get; set; }

    /// <summary>
    /// Gets or Sets TransactionTo
    /// </summary>
    [DataMember(Name="transactionTo", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "transactionTo")]
    public DateTime? TransactionTo { get; set; }

    /// <summary>
    /// Gets or Sets ExpiresAt
    /// </summary>
    [DataMember(Name="expiresAt", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "expiresAt")]
    public DateTime? ExpiresAt { get; set; }

    /// <summary>
    /// Deprecated. Use `timeToExpire` instead.
    /// </summary>
    /// <value>Deprecated. Use `timeToExpire` instead.</value>
    [DataMember(Name="timeToExpireInMillis", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "timeToExpireInMillis")]
    public long? TimeToExpireInMillis { get; set; }

    /// <summary>
    /// ISO 8601 duration
    /// </summary>
    /// <value>ISO 8601 duration</value>
    [DataMember(Name="timeToExpire", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "timeToExpire")]
    public string TimeToExpire { get; set; }

    /// <summary>
    /// Gets or Sets FeatureScope
    /// </summary>
    [DataMember(Name="featureScope", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "featureScope")]
    public List<string> FeatureScope { get; set; }

    /// <summary>
    /// Gets or Sets Charges
    /// </summary>
    [DataMember(Name="charges", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "charges")]
    public List<ChargeDetails> Charges { get; set; }

    /// <summary>
    /// Gets or Sets ExchangeRateInformation
    /// </summary>
    [DataMember(Name="exchangeRateInformation", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "exchangeRateInformation")]
    public ExchangeRateInformationResponse ExchangeRateInformation { get; set; }

    /// <summary>
    /// Gets or Sets ConsentToken
    /// </summary>
    [DataMember(Name="consentToken", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "consentToken")]
    public string ConsentToken { get; set; }

    /// <summary>
    /// Gets or Sets AuthorisationUrl
    /// </summary>
    [DataMember(Name="authorisationUrl", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "authorisationUrl")]
    public string AuthorisationUrl { get; set; }

    /// <summary>
    /// Gets or Sets State
    /// </summary>
    [DataMember(Name="state", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "state")]
    public string State { get; set; }

    /// <summary>
    /// Gets or Sets QrCodeUrl
    /// </summary>
    [DataMember(Name="qrCodeUrl", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "qrCodeUrl")]
    public string QrCodeUrl { get; set; }

    /// <summary>
    /// Gets or Sets AuthorizedAt
    /// </summary>
    [DataMember(Name="authorizedAt", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "authorizedAt")]
    public DateTime? AuthorizedAt { get; set; }

    /// <summary>
    /// Gets or Sets Explanation
    /// </summary>
    [DataMember(Name="explanation", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "explanation")]
    public string Explanation { get; set; }

    /// <summary>
    /// Gets or Sets InstitutionConsentId
    /// </summary>
    [DataMember(Name="institutionConsentId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "institutionConsentId")]
    public string InstitutionConsentId { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PaymentAuthorisationRequestResponse {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  UserUuid: ").Append(UserUuid).Append("\n");
      sb.Append("  ApplicationUserId: ").Append(ApplicationUserId).Append("\n");
      sb.Append("  ReferenceId: ").Append(ReferenceId).Append("\n");
      sb.Append("  InstitutionId: ").Append(InstitutionId).Append("\n");
      sb.Append("  Status: ").Append(Status).Append("\n");
      sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
      sb.Append("  TransactionFrom: ").Append(TransactionFrom).Append("\n");
      sb.Append("  TransactionTo: ").Append(TransactionTo).Append("\n");
      sb.Append("  ExpiresAt: ").Append(ExpiresAt).Append("\n");
      sb.Append("  TimeToExpireInMillis: ").Append(TimeToExpireInMillis).Append("\n");
      sb.Append("  TimeToExpire: ").Append(TimeToExpire).Append("\n");
      sb.Append("  FeatureScope: ").Append(FeatureScope).Append("\n");
      sb.Append("  Charges: ").Append(Charges).Append("\n");
      sb.Append("  ExchangeRateInformation: ").Append(ExchangeRateInformation).Append("\n");
      sb.Append("  ConsentToken: ").Append(ConsentToken).Append("\n");
      sb.Append("  AuthorisationUrl: ").Append(AuthorisationUrl).Append("\n");
      sb.Append("  State: ").Append(State).Append("\n");
      sb.Append("  QrCodeUrl: ").Append(QrCodeUrl).Append("\n");
      sb.Append("  AuthorizedAt: ").Append(AuthorizedAt).Append("\n");
      sb.Append("  Explanation: ").Append(Explanation).Append("\n");
      sb.Append("  InstitutionConsentId: ").Append(InstitutionConsentId).Append("\n");
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
