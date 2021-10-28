using Refit;

namespace Appmilla.Yapily.Refit.Models
{
    /// <summary>
    /// Enrichment
    /// </summary>    
    public class Enrichment
    {
        /// <summary>
        /// Categorisation
        /// </summary>
        [AliasAs("categorisation")]
        public Categorisation Categorisation { get; set; }

        /// <summary>
        /// TransactionHash
        /// </summary>
        [AliasAs("transactionHash")]
        public TransactionHash TransactionHash { get; set; }

        /// <summary>
        /// CleansedDescription
        /// </summary>
        [AliasAs("cleansedDescription")]
        public string CleansedDescription { get; set; }

        /// <summary>
        /// Merchant
        /// </summary>
        [AliasAs("merchant")]
        public EnrichmentMerchant Merchant { get; set; }

        /// <summary>
        /// Location
        /// </summary>
        [AliasAs("location")]
        public string Location { get; set; }

        /// <summary>
        /// PaymentProcessor
        /// </summary>
        [AliasAs("paymentProcessor")]
        public string PaymentProcessor { get; set; }

        /// <summary>
        /// CorrectedDate
        /// </summary>
        [AliasAs("correctedDate")]
        public System.DateTimeOffset? CorrectedDate { get; set; }

    }
}