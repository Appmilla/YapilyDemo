using Refit;

namespace Appmilla.Yapily.Refit.Models
{
    /// <summary>
    /// CurrencyExchange
    /// </summary>    
    public class CurrencyExchange
    {
        /// <summary>
        /// ISO 4217 currency code denoting the currency of the creditor
        /// </summary>
        [AliasAs("sourceCurrency")]
        public string SourceCurrency { get; set; }

        /// <summary>
        /// ISO 4217 currency code denoting the currency of the debtor
        /// </summary>
        [AliasAs("targetCurrency")]
        public string TargetCurrency { get; set; }

        /// <summary>
        /// ISO 4217 currency code denoting the currency used to set the exchange rate (GBP is the unit currency in the conversion of 1 GBP = x CUR)
        /// </summary>
        [AliasAs("unitCurrency")]
        public string UnitCurrency { get; set; }

        /// <summary>
        /// Currency exchange rate
        /// </summary>
        [AliasAs("exchangeRate")]
        public double? ExchangeRate { get; set; }

    }
}