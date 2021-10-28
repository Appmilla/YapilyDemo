using System.Collections.Generic;
using Refit;

namespace Appmilla.Yapily.Refit.Models
{
    /// <summary>
    /// Transaction
    /// </summary>    
    public class Transaction
    {
        /// <summary>
        /// Transaction Id returned by the institution if present
        /// </summary>
        [AliasAs("id")]
        public string Id { get; set; }

        /// <summary>
        /// Transaction date as defined by the institution
        /// </summary>
        [AliasAs("date")]
        public System.DateTimeOffset? Date { get; set; }

        /// <summary>
        /// Date and (if available) time that transaction is posted
        /// </summary>
        [AliasAs("bookingDateTime")]
        public System.DateTimeOffset? BookingDateTime { get; set; }

        /// <summary>
        /// The actual or expected date and time transaction is cleared
        /// </summary>
        [AliasAs("valueDateTime")]
        public System.DateTimeOffset? ValueDateTime { get; set; }

        /// <summary>
        /// The status of the transaction
        /// </summary>
        [AliasAs("status")]
        public TransactionStatus? Status { get; set; }

        /// <summary>
        /// Deprecated. Use the amount value in `transactionAmount` instead
        /// </summary>
        [AliasAs("amount")]
        public double? Amount { get; set; }

        /// <summary>
        /// Deprecated. Use the currency value in `transactionAmount` instead
        /// </summary>
        [AliasAs("currency")]
        public string Currency { get; set; }


        /// <summary>
        /// TransactionAmount
        /// </summary> 

        [AliasAs("transactionAmount")]
        public TransactionAmount TransactionAmount { get; set; }


        /// <summary>
        /// GrossAmount
        /// </summary> 

        [AliasAs("grossAmount")]
        public Amount GrossAmount { get; set; }


        /// <summary>
        /// CurrencyExchange
        /// </summary> 

        [AliasAs("currencyExchange")]
        public CurrencyExchange CurrencyExchange { get; set; }

        /// <summary>
        /// If present, contains details of any charges applied during this transaction
        /// </summary>
        [AliasAs("chargeDetails")]
        public ChargeDetails ChargeDetails { get; set; }

        /// <summary>
        /// Transaction reference
        /// </summary>
        [AliasAs("reference")]
        public string Reference { get; set; }


        /// <summary>
        /// StatementReferences
        /// </summary> 

        [AliasAs("statementReferences")]
        public List<StatementReference> StatementReferences { get; set; }

        /// <summary>
        /// Unstructured text containing details of the transaction. Usage varies according to the institution
        /// </summary>
        [AliasAs("description")]
        public string Description { get; set; }

        /// <summary>
        /// Further information related to the transaction. Usage varies according to the institution
        /// </summary>
        [AliasAs("transactionInformation")]
        public List<string> TransactionInformation { get; set; }


        /// <summary>
        /// AddressDetails
        /// </summary> 

        [AliasAs("addressDetails")]
        public AddressDetails AddressDetails { get; set; }


        /// <summary>
        /// IsoBankTransactionCode
        /// </summary> 

        [AliasAs("isoBankTransactionCode")]
        public IsoBankTransactionCode IsoBankTransactionCode { get; set; }


        /// <summary>
        /// ProprietaryBankTransactionCode
        /// </summary> 

        [AliasAs("proprietaryBankTransactionCode")]
        public ProprietaryBankTransactionCode ProprietaryBankTransactionCode { get; set; }

        /// <summary>
        /// Running account balance after transaction has been applied
        /// </summary>
        [AliasAs("balance")]
        public Balance Balance { get; set; }

        /// <summary>
        /// Payee details
        /// </summary>
        [AliasAs("payeeDetails")]
        public Payee PayeeDetails { get; set; }

        /// <summary>
        /// Payer details
        /// </summary>
        [AliasAs("payerDetails")]
        public Payer PayerDetails { get; set; }

        /// <summary>
        /// Merchant details
        /// </summary>
        [AliasAs("merchant")]
        public Merchant Merchant { get; set; }

        /// <summary>
        /// Enrichment
        /// </summary>
        [AliasAs("enrichment")]
        public Enrichment Enrichment { get; set; }

        /// <summary>
        /// Additional information that can not be captured in the structured fields and/or any other specific block.
        /// </summary>
        [AliasAs("supplementaryData")]
        public object SupplementaryData { get; set; }

    }
}