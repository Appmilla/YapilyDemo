using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Appmilla.Yapily.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class PersonalCurrentAccountPCA {
    /// <summary>
    /// Gets or Sets Identification
    /// </summary>
    [DataMember(Name="Identification", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Identification")]
    public string Identification { get; set; }

    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name="Name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Name")]
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets PCAMarketingState
    /// </summary>
    [DataMember(Name="PCAMarketingState", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PCAMarketingState")]
    public List<PersonalCurrentAccountPCAMarketingState> PCAMarketingState { get; set; }

    /// <summary>
    /// Gets or Sets Segment
    /// </summary>
    [DataMember(Name="Segment", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Segment")]
    public List<string> Segment { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PersonalCurrentAccountPCA {\n");
      sb.Append("  Identification: ").Append(Identification).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  PCAMarketingState: ").Append(PCAMarketingState).Append("\n");
      sb.Append("  Segment: ").Append(Segment).Append("\n");
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
