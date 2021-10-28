using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Appmilla.Yapily.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class IsoBankTransactionCode {
    /// <summary>
    /// Gets or Sets DomainCode
    /// </summary>
    [DataMember(Name="domainCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "domainCode")]
    public IsoCodeDetails DomainCode { get; set; }

    /// <summary>
    /// Gets or Sets FamilyCode
    /// </summary>
    [DataMember(Name="familyCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "familyCode")]
    public IsoCodeDetails FamilyCode { get; set; }

    /// <summary>
    /// Gets or Sets SubFamilyCode
    /// </summary>
    [DataMember(Name="subFamilyCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "subFamilyCode")]
    public IsoCodeDetails SubFamilyCode { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class IsoBankTransactionCode {\n");
      sb.Append("  DomainCode: ").Append(DomainCode).Append("\n");
      sb.Append("  FamilyCode: ").Append(FamilyCode).Append("\n");
      sb.Append("  SubFamilyCode: ").Append(SubFamilyCode).Append("\n");
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
