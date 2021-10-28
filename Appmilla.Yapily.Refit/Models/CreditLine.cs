using Refit;

namespace Appmilla.Yapily.Refit.Models
{
    /// <summary>
    /// CreditLine
    /// </summary>    
    public class CreditLine
    {

        /// <summary>
        /// Type
        /// </summary> 

        [AliasAs("type")]
        public CreditLineType? Type { get; set; }


        /// <summary>
        /// CreditLineAmount
        /// </summary> 

        [AliasAs("creditLineAmount")]
        public Amount CreditLineAmount { get; set; }

    }
}