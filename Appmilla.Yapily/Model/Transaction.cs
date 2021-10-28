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
  public class Transaction {
    /// <summary>
    /// Transaction Id returned by the institution if present
    /// </summary>
    /// <value>Transaction Id returned by the institution if present</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }

    /// <summary>
    /// Transaction date as defined by the institution
    /// </summary>
    /// <value>Transaction date as defined by the institution</value>
    [DataMember(Name="date", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "date")]
    public DateTime? Date { get; set; }

    /// <summary>
    /// Date and (if available) time that transaction is posted
    /// </summary>
    /// <value>Date and (if available) time that transaction is posted</value>
    [DataMember(Name="bookingDateTime", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "bookingDateTime")]
    public DateTime? BookingDateTime { get; set; }

    /// <summary>
    /// The actual or expected date and time transaction is cleared
    /// </summary>
    /// <value>The actual or expected date and time transaction is cleared</value>
    [DataMember(Name="valueDateTime", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "valueDateTime")]
    public DateTime? ValueDateTime { get; set; }

    /// <summary>
    /// The status of the transaction
    /// </summary>
    /// <value>The status of the transaction</value>
    [DataMember(Name="status", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "status")]
    public string Status { get; set; }

    /// <summary>
    /// Deprecated. Use the amount value in `transactionAmount` instead
    /// </summary>
    /// <value>Deprecated. Use the amount value in `transactionAmount` instead</value>
    [DataMember(Name="amount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "amount")]
    public decimal? Amount { get; set; }

    /// <summary>
    /// Deprecated. Use the currency value in `transactionAmount` instead
    /// </summary>
    /// <value>Deprecated. Use the currency value in `transactionAmount` instead</value>
    [DataMember(Name="currency", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "currency")]
    public string Currency { get; set; }

    /// <summary>
    /// Gets or Sets TransactionAmount
    /// </summary>
    [DataMember(Name="transactionAmount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "transactionAmount")]
    public TransactionAmount TransactionAmount { get; set; }

    /// <summary>
    /// Gets or Sets GrossAmount
    /// </summary>
    [DataMember(Name="grossAmount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "grossAmount")]
    public Amount GrossAmount { get; set; }

    /// <summary>
    /// Gets or Sets CurrencyExchange
    /// </summary>
    [DataMember(Name="currencyExchange", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "currencyExchange")]
    public CurrencyExchange CurrencyExchange { get; set; }

    /// <summary>
    /// Gets or Sets ChargeDetails
    /// </summary>
    [DataMember(Name="chargeDetails", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "chargeDetails")]
    public ChargeDetails ChargeDetails { get; set; }

    /// <summary>
    /// Transaction reference
    /// </summary>
    /// <value>Transaction reference</value>
    [DataMember(Name="reference", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "reference")]
    public string Reference { get; set; }

    /// <summary>
    /// Gets or Sets StatementReferences
    /// </summary>
    [DataMember(Name="statementReferences", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "statementReferences")]
    public List<StatementReference> StatementReferences { get; set; }

    /// <summary>
    /// Unstructured text containing details of the transaction. Usage varies according to the institution
    /// </summary>
    /// <value>Unstructured text containing details of the transaction. Usage varies according to the institution</value>
    [DataMember(Name="description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    /// <summary>
    /// Further information related to the transaction. Usage varies according to the institution
    /// </summary>
    /// <value>Further information related to the transaction. Usage varies according to the institution</value>
    [DataMember(Name="transactionInformation", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "transactionInformation")]
    public List<string> TransactionInformation { get; set; }

    /// <summary>
    /// Gets or Sets AddressDetails
    /// </summary>
    [DataMember(Name="addressDetails", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "addressDetails")]
    public AddressDetails AddressDetails { get; set; }

    /// <summary>
    /// Gets or Sets IsoBankTransactionCode
    /// </summary>
    [DataMember(Name="isoBankTransactionCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "isoBankTransactionCode")]
    public IsoBankTransactionCode IsoBankTransactionCode { get; set; }

    /// <summary>
    /// Gets or Sets ProprietaryBankTransactionCode
    /// </summary>
    [DataMember(Name="proprietaryBankTransactionCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "proprietaryBankTransactionCode")]
    public ProprietaryBankTransactionCode ProprietaryBankTransactionCode { get; set; }

    /// <summary>
    /// Gets or Sets Balance
    /// </summary>
    [DataMember(Name="balance", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "balance")]
    public Balance Balance { get; set; }

    /// <summary>
    /// Gets or Sets PayeeDetails
    /// </summary>
    [DataMember(Name="payeeDetails", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "payeeDetails")]
    public Payee PayeeDetails { get; set; }

    /// <summary>
    /// Gets or Sets PayerDetails
    /// </summary>
    [DataMember(Name="payerDetails", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "payerDetails")]
    public Payer PayerDetails { get; set; }

    /// <summary>
    /// Gets or Sets Merchant
    /// </summary>
    [DataMember(Name="merchant", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "merchant")]
    public Merchant Merchant { get; set; }

    /// <summary>
    /// Gets or Sets Enrichment
    /// </summary>
    [DataMember(Name="enrichment", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "enrichment")]
    public Enrichment Enrichment { get; set; }

    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    /// <value>Additional information that can not be captured in the structured fields and/or any other specific block.</value>
    [DataMember(Name="supplementaryData", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "supplementaryData")]
    public Object SupplementaryData { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Transaction {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Date: ").Append(Date).Append("\n");
      sb.Append("  BookingDateTime: ").Append(BookingDateTime).Append("\n");
      sb.Append("  ValueDateTime: ").Append(ValueDateTime).Append("\n");
      sb.Append("  Status: ").Append(Status).Append("\n");
      sb.Append("  Amount: ").Append(Amount).Append("\n");
      sb.Append("  Currency: ").Append(Currency).Append("\n");
      sb.Append("  TransactionAmount: ").Append(TransactionAmount).Append("\n");
      sb.Append("  GrossAmount: ").Append(GrossAmount).Append("\n");
      sb.Append("  CurrencyExchange: ").Append(CurrencyExchange).Append("\n");
      sb.Append("  ChargeDetails: ").Append(ChargeDetails).Append("\n");
      sb.Append("  Reference: ").Append(Reference).Append("\n");
      sb.Append("  StatementReferences: ").Append(StatementReferences).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  TransactionInformation: ").Append(TransactionInformation).Append("\n");
      sb.Append("  AddressDetails: ").Append(AddressDetails).Append("\n");
      sb.Append("  IsoBankTransactionCode: ").Append(IsoBankTransactionCode).Append("\n");
      sb.Append("  ProprietaryBankTransactionCode: ").Append(ProprietaryBankTransactionCode).Append("\n");
      sb.Append("  Balance: ").Append(Balance).Append("\n");
      sb.Append("  PayeeDetails: ").Append(PayeeDetails).Append("\n");
      sb.Append("  PayerDetails: ").Append(PayerDetails).Append("\n");
      sb.Append("  Merchant: ").Append(Merchant).Append("\n");
      sb.Append("  Enrichment: ").Append(Enrichment).Append("\n");
      sb.Append("  SupplementaryData: ").Append(SupplementaryData).Append("\n");
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
