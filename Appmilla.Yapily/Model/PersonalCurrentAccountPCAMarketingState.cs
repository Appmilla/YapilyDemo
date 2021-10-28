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
  public class PersonalCurrentAccountPCAMarketingState {
    /// <summary>
    /// Gets or Sets CoreProduct
    /// </summary>
    [DataMember(Name="CoreProduct", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CoreProduct")]
    public CoreProduct CoreProduct { get; set; }

    /// <summary>
    /// Gets or Sets CreditInterest
    /// </summary>
    [DataMember(Name="CreditInterest", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CreditInterest")]
    public CreditInterest CreditInterest { get; set; }

    /// <summary>
    /// Gets or Sets Eligibility
    /// </summary>
    [DataMember(Name="Eligibility", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Eligibility")]
    public Eligibility Eligibility { get; set; }

    /// <summary>
    /// Gets or Sets FirstMarketedDate
    /// </summary>
    [DataMember(Name="FirstMarketedDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "FirstMarketedDate")]
    public DateTime? FirstMarketedDate { get; set; }

    /// <summary>
    /// Gets or Sets Identification
    /// </summary>
    [DataMember(Name="Identification", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Identification")]
    public string Identification { get; set; }

    /// <summary>
    /// Gets or Sets LastMarketedDate
    /// </summary>
    [DataMember(Name="LastMarketedDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "LastMarketedDate")]
    public DateTime? LastMarketedDate { get; set; }

    /// <summary>
    /// Gets or Sets MarketingState
    /// </summary>
    [DataMember(Name="MarketingState", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "MarketingState")]
    public string MarketingState { get; set; }

    /// <summary>
    /// Gets or Sets Notes
    /// </summary>
    [DataMember(Name="Notes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Notes")]
    public List<string> Notes { get; set; }

    /// <summary>
    /// Gets or Sets Overdraft
    /// </summary>
    [DataMember(Name="Overdraft", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Overdraft")]
    public Overdraft Overdraft { get; set; }

    /// <summary>
    /// Gets or Sets PredecessorID
    /// </summary>
    [DataMember(Name="PredecessorID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PredecessorID")]
    public string PredecessorID { get; set; }

    /// <summary>
    /// Gets or Sets StateTenureLength
    /// </summary>
    [DataMember(Name="StateTenureLength", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "StateTenureLength")]
    public float? StateTenureLength { get; set; }

    /// <summary>
    /// Gets or Sets StateTenurePeriod
    /// </summary>
    [DataMember(Name="StateTenurePeriod", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "StateTenurePeriod")]
    public string StateTenurePeriod { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PersonalCurrentAccountPCAMarketingState {\n");
      sb.Append("  CoreProduct: ").Append(CoreProduct).Append("\n");
      sb.Append("  CreditInterest: ").Append(CreditInterest).Append("\n");
      sb.Append("  Eligibility: ").Append(Eligibility).Append("\n");
      sb.Append("  FirstMarketedDate: ").Append(FirstMarketedDate).Append("\n");
      sb.Append("  Identification: ").Append(Identification).Append("\n");
      sb.Append("  LastMarketedDate: ").Append(LastMarketedDate).Append("\n");
      sb.Append("  MarketingState: ").Append(MarketingState).Append("\n");
      sb.Append("  Notes: ").Append(Notes).Append("\n");
      sb.Append("  Overdraft: ").Append(Overdraft).Append("\n");
      sb.Append("  PredecessorID: ").Append(PredecessorID).Append("\n");
      sb.Append("  StateTenureLength: ").Append(StateTenureLength).Append("\n");
      sb.Append("  StateTenurePeriod: ").Append(StateTenurePeriod).Append("\n");
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
