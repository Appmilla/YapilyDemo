using System.Collections.Generic;
using Refit;

namespace Appmilla.Yapily.Refit.Models
{
    /// <summary>
    /// AccountBalance
    /// </summary>    
    public class AccountBalance
    {

        /// <summary>
        /// Type
        /// </summary> 

        [AliasAs("type")]
        public AccountBalanceType? Type { get; set; }

        /// <summary>
        /// Timestamp of the last change of the balance amount
        /// </summary>
        [AliasAs("dateTime")]
        public System.DateTimeOffset? DateTime { get; set; }


        /// <summary>
        /// BalanceAmount
        /// </summary> 

        [AliasAs("balanceAmount")]
        public Amount BalanceAmount { get; set; }

        /// <summary>
        /// Indicates whether or not the credit line is included in the balance
        /// </summary>
        [AliasAs("creditLineIncluded")]
        public bool? CreditLineIncluded { get; set; }


        /// <summary>
        /// CreditLines
        /// </summary> 

        [AliasAs("creditLines")]
        public List<CreditLine> CreditLines { get; set; }

    }
}