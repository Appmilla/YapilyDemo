using System.Collections.Generic;
using Refit;

namespace Appmilla.Yapily.Refit.Models
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