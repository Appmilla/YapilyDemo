using Refit;

namespace Appmilla.Yapily.Refit.Models
{
    /// <summary>
    /// ChargeDetails
    /// </summary>    
    public class ChargeDetails
    {
        /// <summary>
        /// Amount paid by charge bearer
        /// </summary>
        [AliasAs("chargeAmount")]
        public Amount ChargeAmount { get; set; }

    }
}