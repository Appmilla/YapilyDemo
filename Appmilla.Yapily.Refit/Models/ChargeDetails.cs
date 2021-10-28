using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Refit;

namespace Cms
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