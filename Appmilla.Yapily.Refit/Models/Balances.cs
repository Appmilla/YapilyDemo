using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Refit;

namespace Cms
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