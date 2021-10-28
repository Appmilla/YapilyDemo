using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Refit;

namespace Cms
{
    /// <summary>
    /// Details about any caps (maximum charges) that apply to a particular fee/charge    /// </summary>    
    public class OverdraftOverdraftFeeChargeCap
    {

        /// <summary>
        /// CappingPeriod
        /// </summary> 

        [AliasAs("CappingPeriod")]
        public OverdraftOverdraftFeeChargeCapCappingPeriod? CappingPeriod { get; set; }


        /// <summary>
        /// FeeCapAmount
        /// </summary> 

        [AliasAs("FeeCapAmount")]
        public string FeeCapAmount { get; set; }


        /// <summary>
        /// FeeCapOccurrence
        /// </summary> 

        [AliasAs("FeeCapOccurrence")]
        public float? FeeCapOccurrence { get; set; }


        /// <summary>
        /// FeeType
        /// </summary> 

        [AliasAs("FeeType")]
        public List<FeeType> FeeType { get; set; }


        /// <summary>
        /// MinMaxType
        /// </summary> 

        [AliasAs("MinMaxType")]
        public OverdraftOverdraftFeeChargeCapMinMaxType? MinMaxType { get; set; }


        /// <summary>
        /// Notes
        /// </summary> 

        [AliasAs("Notes")]
        public List<string> Notes { get; set; }


        /// <summary>
        /// OtherFeeType
        /// </summary> 

        [AliasAs("OtherFeeType")]
        public List<OverdraftOtherFeeType> OtherFeeType { get; set; }


        /// <summary>
        /// OverdraftControlIndicator
        /// </summary> 

        [AliasAs("OverdraftControlIndicator")]
        public bool? OverdraftControlIndicator { get; set; }

    }
}