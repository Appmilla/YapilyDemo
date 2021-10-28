using System;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Appmilla.Yapily.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class Next {
    /// <summary>
    /// Gets or Sets Before
    /// </summary>
    [DataMember(Name="before", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "before")]
    public DateTime? Before { get; set; }

    /// <summary>
    /// Gets or Sets Cursor
    /// </summary>
    [DataMember(Name="cursor", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "cursor")]
    public string Cursor { get; set; }

    /// <summary>
    /// Gets or Sets From
    /// </summary>
    [DataMember(Name="from", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "from")]
    public DateTime? From { get; set; }

    /// <summary>
    /// Gets or Sets Limit
    /// </summary>
    [DataMember(Name="limit", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "limit")]
    public int? Limit { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Next {\n");
      sb.Append("  Before: ").Append(Before).Append("\n");
      sb.Append("  Cursor: ").Append(Cursor).Append("\n");
      sb.Append("  From: ").Append(From).Append("\n");
      sb.Append("  Limit: ").Append(Limit).Append("\n");
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
