using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Refit;

namespace Cms
{
    /// <summary>
    /// Balance
    /// </summary>    
    public class Balance
    {

        /// <summary>
        /// Type
        /// </summary> 

        [AliasAs("type")]
        public BalanceType? Type { get; set; }


        /// <summary>
        /// BalanceAmount
        /// </summary> 

        [AliasAs("balanceAmount")]
        public Amount BalanceAmount { get; set; }

    }
}