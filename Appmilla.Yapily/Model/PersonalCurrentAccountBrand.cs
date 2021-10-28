using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Appmilla.Yapily.Model {

  /// <summary>
  /// Brand registered by the banking group at https://register.fca.org.uk/
  /// </summary>
  [DataContract]
  public class PersonalCurrentAccountBrand {
    /// <summary>
    /// Gets or Sets BrandName
    /// </summary>
    [DataMember(Name="BrandName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "BrandName")]
    public string BrandName { get; set; }

    /// <summary>
    /// Gets or Sets PCA
    /// </summary>
    [DataMember(Name="PCA", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PCA")]
    public List<PersonalCurrentAccountPCA> PCA { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PersonalCurrentAccountBrand {\n");
      sb.Append("  BrandName: ").Append(BrandName).Append("\n");
      sb.Append("  PCA: ").Append(PCA).Append("\n");
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
