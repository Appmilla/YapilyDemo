using System.Collections.Generic;
using Refit;

namespace Appmilla.Yapily.Refit.Models
{
    /// <summary>
    /// Balances
    /// </summary>    
    public class Balances
    {

        /// <summary>
        /// MainBalanceAmount
        /// </summary> 

        [AliasAs("mainBalanceAmount")]
        public Amount MainBalanceAmount { get; set; }


        /// <summary>
        /// Balances1
        /// </summary> 

        [AliasAs("balances")]
        public List<AccountBalance> Balances1 { get; set; }

    }
}