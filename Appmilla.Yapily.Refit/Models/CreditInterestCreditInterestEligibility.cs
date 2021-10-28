using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Refit;

namespace Cms
{
    /// <summary>
    /// Eligibility for credit interest    /// </summary>    
    public class CreditInterestCreditInterestEligibility
    {

        /// <summary>
        /// Amount
        /// </summary> 

        [AliasAs("Amount")]
        public string Amount { get; set; }


        /// <summary>
        /// Description
        /// </summary> 

        [AliasAs("Description")]
        public string Description { get; set; }


        /// <summary>
        /// Indicator
        /// </summary> 

        [AliasAs("Indicator")]
        public bool? Indicator { get; set; }


        /// <summary>
        /// Name
        /// </summary> 

        [AliasAs("Name")]
        public string Name { get; set; }


        /// <summary>
        /// Notes
        /// </summary> 

        [AliasAs("Notes")]
        public List<string> Notes { get; set; }


        /// <summary>
        /// OtherType
        /// </summary> 

        [AliasAs("OtherType")]
        public OtherType OtherType { get; set; }


        /// <summary>
        /// Period
        /// </summary> 

        [AliasAs("Period")]
        public CreditInterestCreditInterestEligibilityPeriod? Period { get; set; }


        /// <summary>
        /// Textual
        /// </summary> 

        [AliasAs("Textual")]
        public string Textual { get; set; }


        /// <summary>
        /// Type
        /// </summary> 

        [AliasAs("Type")]
        public CreditInterestCreditInterestEligibilityType? Type { get; set; }

    }
}