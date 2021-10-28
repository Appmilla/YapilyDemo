using System.Collections.Generic;
using Refit;

namespace Appmilla.Yapily.Refit.Models
{
    /// <summary>
    /// Details about the fees/charges    /// </summary>    
    public class OverdraftOverdraftFeeChargeDetail
    {

        /// <summary>
        /// ApplicationFrequency
        /// </summary> 

        [AliasAs("ApplicationFrequency")]
        public OverdraftOverdraftFeeChargeDetailApplicationFrequency? ApplicationFrequency { get; set; }


        /// <summary>
        /// CalculationFrequency
        /// </summary> 

        [AliasAs("CalculationFrequency")]
        public OverdraftOverdraftFeeChargeDetailCalculationFrequency? CalculationFrequency { get; set; }


        /// <summary>
        /// FeeAmount
        /// </summary> 

        [AliasAs("FeeAmount")]
        public string FeeAmount { get; set; }


        /// <summary>
        /// FeeRate
        /// </summary> 

        [AliasAs("FeeRate")]
        public string FeeRate { get; set; }


        /// <summary>
        /// FeeRateType
        /// </summary> 

        [AliasAs("FeeRateType")]
        public OverdraftOverdraftFeeChargeDetailFeeRateType? FeeRateType { get; set; }


        /// <summary>
        /// FeeType
        /// </summary> 

        [AliasAs("FeeType")]
        public OverdraftOverdraftFeeChargeDetailFeeType? FeeType { get; set; }


        /// <summary>
        /// IncrementalBorrowingAmount
        /// </summary> 

        [AliasAs("IncrementalBorrowingAmount")]
        public string IncrementalBorrowingAmount { get; set; }


        /// <summary>
        /// Notes
        /// </summary> 

        [AliasAs("Notes")]
        public List<string> Notes { get; set; }


        /// <summary>
        /// OtherApplicationFrequency
        /// </summary> 

        [AliasAs("OtherApplicationFrequency")]
        public OtherApplicationFrequency OtherApplicationFrequency { get; set; }


        /// <summary>
        /// OtherCalculationFrequency
        /// </summary> 

        [AliasAs("OtherCalculationFrequency")]
        public OtherCalculationFrequency OtherCalculationFrequency { get; set; }


        /// <summary>
        /// OtherFeeRateType
        /// </summary> 

        [AliasAs("OtherFeeRateType")]
        public OtherFeeRateType OtherFeeRateType { get; set; }


        /// <summary>
        /// OtherFeeType
        /// </summary> 

        [AliasAs("OtherFeeType")]
        public OtherFeeType OtherFeeType { get; set; }


        /// <summary>
        /// OverdraftControlIndicator
        /// </summary> 

        [AliasAs("OverdraftControlIndicator")]
        public bool? OverdraftControlIndicator { get; set; }


        /// <summary>
        /// OverdraftFeeChargeCap
        /// </summary> 

        [AliasAs("OverdraftFeeChargeCap")]
        public OverdraftOverdraftFeeChargeCap OverdraftFeeChargeCap { get; set; }

    }
}