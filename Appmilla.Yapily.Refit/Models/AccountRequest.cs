using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Refit;

namespace Cms
{
    /// <summary>
    /// AccountRequest
    /// </summary>    
    public class AccountRequest
    {

        /// <summary>
        /// TransactionFrom
        /// </summary> 

        [AliasAs("transactionFrom")]
        public System.DateTimeOffset? TransactionFrom { get; set; }


        /// <summary>
        /// TransactionTo
        /// </summary> 

        [AliasAs("transactionTo")]
        public System.DateTimeOffset? TransactionTo { get; set; }


        /// <summary>
        /// ExpiresAt
        /// </summary> 

        [AliasAs("expiresAt")]
        public System.DateTimeOffset? ExpiresAt { get; set; }


        /// <summary>
        /// AccountIdentifiers
        /// </summary> 

        [AliasAs("accountIdentifiers")]
        public AccountInfo AccountIdentifiers { get; set; }


        /// <summary>
        /// AccountIdentifiersForTransaction
        /// </summary> 

        [AliasAs("accountIdentifiersForTransaction")]
        public List<AccountInfo> AccountIdentifiersForTransaction { get; set; }


        /// <summary>
        /// AccountIdentifiersForBalance
        /// </summary> 

        [AliasAs("accountIdentifiersForBalance")]
        public List<AccountInfo> AccountIdentifiersForBalance { get; set; }


        /// <summary>
        /// FeatureScope
        /// </summary> 

        [AliasAs("featureScope")]
        public List<FeatureScope> FeatureScope { get; set; }

    }
}