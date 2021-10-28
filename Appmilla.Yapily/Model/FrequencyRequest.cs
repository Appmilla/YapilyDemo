using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Appmilla.Yapily.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class FrequencyRequest {
    /// <summary>
    /// Gets or Sets Type
    /// </summary>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }

    /// <summary>
    /// Gets or Sets IntervalWeek
    /// </summary>
    [DataMember(Name="intervalWeek", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "intervalWeek")]
    public int? IntervalWeek { get; set; }

    /// <summary>
    /// Gets or Sets IntervalMonth
    /// </summary>
    [DataMember(Name="intervalMonth", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "intervalMonth")]
    public int? IntervalMonth { get; set; }

    /// <summary>
    /// Gets or Sets ExecutionDay
    /// </summary>
    [DataMember(Name="executionDay", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "executionDay")]
    public int? ExecutionDay { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class FrequencyRequest {\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
      sb.Append("  IntervalWeek: ").Append(IntervalWeek).Append("\n");
      sb.Append("  IntervalMonth: ").Append(IntervalMonth).Append("\n");
      sb.Append("  ExecutionDay: ").Append(ExecutionDay).Append("\n");
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
