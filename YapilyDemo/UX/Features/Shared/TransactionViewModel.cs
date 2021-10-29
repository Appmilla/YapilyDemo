using System;
using System.Collections.Generic;
using Appmilla.Yapily.Refit.Models;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;

namespace YapilyDemo.UX.Features.Shared
{
    public class TransactionViewModel : ReactiveObject
    {
        [Reactive]
        public Guid CacheKey { get; set; }
        
        /// <summary>
        /// Transaction Id returned by the institution if present
        /// </summary>
        [Reactive]
        public string Id { get; set; }

        /// <summary>
        /// Transaction date as defined by the institution
        /// </summary>
        [Reactive]
        public System.DateTimeOffset? Date { get; set; }

        public string FormattedDate => Date?.ToString("D");
        
        /// <summary>
        /// Date and (if available) time that transaction is posted
        /// </summary>
        [Reactive]
        public System.DateTimeOffset? BookingDateTime { get; set; }

        /// <summary>
        /// The actual or expected date and time transaction is cleared
        /// </summary>
        [Reactive]
        public System.DateTimeOffset? ValueDateTime { get; set; }

        /// <summary>
        /// The status of the transaction
        /// </summary>
        [Reactive]
        public TransactionStatus? Status { get; set; }

        /// <summary>
        /// Deprecated. Use the amount value in `transactionAmount` instead
        /// </summary>
        [Reactive]
        public double? Amount { get; set; }

        /// <summary>
        /// Deprecated. Use the currency value in `transactionAmount` instead
        /// </summary>
        [Reactive]
        public string Currency { get; set; }


        /// <summary>
        /// TransactionAmount
        /// </summary> 

        [Reactive]
        public TransactionAmount TransactionAmount { get; set; }

        [Reactive]
        public string FormattedAmount { get; set; }
        
        /// <summary>
        /// GrossAmount
        /// </summary> 

        [Reactive]
        public Amount GrossAmount { get; set; }


        /// <summary>
        /// CurrencyExchange
        /// </summary> 

        [Reactive]
        public CurrencyExchange CurrencyExchange { get; set; }

        /// <summary>
        /// If present, contains details of any charges applied during this transaction
        /// </summary>
        [Reactive]
        public ChargeDetails ChargeDetails { get; set; }

        /// <summary>
        /// Transaction reference
        /// </summary>
        [Reactive]
        public string Reference { get; set; }


        /// <summary>
        /// StatementReferences
        /// </summary> 

        [Reactive]
        public List<StatementReference> StatementReferences { get; set; }

        /// <summary>
        /// Unstructured text containing details of the transaction. Usage varies according to the institution
        /// </summary>
        [Reactive]
        public string Description { get; set; }

        /// <summary>
        /// Further information related to the transaction. Usage varies according to the institution
        /// </summary>
        [Reactive]
        public List<string> TransactionInformation { get; set; }


        /// <summary>
        /// AddressDetails
        /// </summary> 

        [Reactive]
        public AddressDetails AddressDetails { get; set; }


        /// <summary>
        /// IsoBankTransactionCode
        /// </summary> 

        [Reactive]
        public IsoBankTransactionCode IsoBankTransactionCode { get; set; }


        /// <summary>
        /// ProprietaryBankTransactionCode
        /// </summary> 

        [Reactive]
        public ProprietaryBankTransactionCode ProprietaryBankTransactionCode { get; set; }

        /// <summary>
        /// Running account balance after transaction has been applied
        /// </summary>
        [Reactive]
        public Balance Balance { get; set; }

        /// <summary>
        /// Payee details
        /// </summary>
        [Reactive]
        public Payee PayeeDetails { get; set; }

        /// <summary>
        /// Payer details
        /// </summary>
        [Reactive]
        public Payer PayerDetails { get; set; }

        /// <summary>
        /// Merchant details
        /// </summary>
        [Reactive]
        public Merchant Merchant { get; set; }

        /// <summary>
        /// Enrichment
        /// </summary>
        [Reactive]
        public Enrichment Enrichment { get; set; }

        /// <summary>
        /// Additional information that can not be captured in the structured fields and/or any other specific block.
        /// </summary>
        [Reactive]
        public object SupplementaryData { get; set; }

    }
}