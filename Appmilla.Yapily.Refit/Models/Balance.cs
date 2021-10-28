using Refit;

namespace Appmilla.Yapily.Refit.Models
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