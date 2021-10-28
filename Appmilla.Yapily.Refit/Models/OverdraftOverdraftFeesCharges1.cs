using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Refit;

namespace Cms
{
    /// <summary>
    /// Overdraft fees and charges details    /// </summary>    
    public class OverdraftOverdraftFeesCharges1
    {

        /// <summary>
        /// OverdraftFeeChargeCap
        /// </summary> 

        [AliasAs("OverdraftFeeChargeCap")]
        public List<OverdraftOverdraftFeeChargeCap> OverdraftFeeChargeCap { get; set; }


        /// <summary>
        /// OverdraftFeeChargeDetail
        /// </summary> 

        [AliasAs("OverdraftFeeChargeDetail")]
        public List<OverdraftOverdraftFeeChargeDetail> OverdraftFeeChargeDetail { get; set; }

    }
}