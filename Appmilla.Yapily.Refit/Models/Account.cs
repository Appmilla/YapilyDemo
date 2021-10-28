using System.Collections.Generic;
using Refit;

namespace Appmilla.Yapily.Refit.Models
{
    /// <summary>
    /// Account
    /// </summary>    
    public class Account
    {
        /// <summary>
        /// Account Id returned by the institution if present
        /// </summary>
        [AliasAs("id")]
        public string Id { get; set; }


        /// <summary>
        /// Type
        /// </summary> 

        [AliasAs("type")]
        public string Type { get; set; }

        /// <summary>
        /// Product name as defined by the financial institution for this account
        /// </summary>
        [AliasAs("description")]
        public string Description { get; set; }


        /// <summary>
        /// Balance
        /// </summary> 

        [AliasAs("balance")]
        public double? Balance { get; set; }

        /// <summary>
        /// ISO 4217 currency code
        /// </summary>
        [AliasAs("currency")]
        public string Currency { get; set; }


        /// <summary>
        /// UsageType
        /// </summary> 

        [AliasAs("usageType")]
        public AccountUsageType? UsageType { get; set; }


        /// <summary>
        /// AccountType
        /// </summary> 

        [AliasAs("accountType")]
        public AccountType? AccountType { get; set; }

        /// <summary>
        /// Name of the account as defined by the financial institution or the end user
        /// </summary>
        [AliasAs("nickname")]
        public string Nickname { get; set; }

        /// <summary>
        /// Specifications that might be provided by the institution
        /// - characteristics of the account
        /// - characteristics of the relevant card
        /// </summary>
        [AliasAs("details")]
        public string Details { get; set; }


        /// <summary>
        /// AccountNames
        /// </summary> 

        [AliasAs("accountNames")]
        public List<AccountName> AccountNames { get; set; }


        /// <summary>
        /// AccountIdentifications
        /// </summary> 

        [AliasAs("accountIdentifications")]
        public List<AccountIdentification> AccountIdentifications { get; set; }


        /// <summary>
        /// AccountBalances
        /// </summary> 

        [AliasAs("accountBalances")]
        public List<AccountBalance> AccountBalances { get; set; }

    }
}