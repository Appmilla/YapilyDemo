using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Refit;

namespace Cms
{
    /// <summary>
    /// PersonalCurrentAccountPCAMarketingState
    /// </summary>    
    public class PersonalCurrentAccountPCAMarketingState
    {

        /// <summary>
        /// CoreProduct
        /// </summary> 

        [AliasAs("CoreProduct")]
        public CoreProduct CoreProduct { get; set; }


        /// <summary>
        /// CreditInterest
        /// </summary> 

        [AliasAs("CreditInterest")]
        public CreditInterest CreditInterest { get; set; }


        /// <summary>
        /// Eligibility
        /// </summary> 

        [AliasAs("Eligibility")]
        public Eligibility Eligibility { get; set; }


        /// <summary>
        /// FirstMarketedDate
        /// </summary> 

        [AliasAs("FirstMarketedDate")]
        public System.DateTimeOffset? FirstMarketedDate { get; set; }


        /// <summary>
        /// Identification
        /// </summary> 

        [AliasAs("Identification")]
        public string Identification { get; set; }


        /// <summary>
        /// LastMarketedDate
        /// </summary> 

        [AliasAs("LastMarketedDate")]
        public System.DateTimeOffset? LastMarketedDate { get; set; }


        /// <summary>
        /// MarketingState
        /// </summary> 

        [AliasAs("MarketingState")]
        public string MarketingState { get; set; }


        /// <summary>
        /// Notes
        /// </summary> 

        [AliasAs("Notes")]
        public List<string> Notes { get; set; }


        /// <summary>
        /// Overdraft
        /// </summary> 

        [AliasAs("Overdraft")]
        public Overdraft Overdraft { get; set; }


        /// <summary>
        /// PredecessorID
        /// </summary> 

        [AliasAs("PredecessorID")]
        public string PredecessorID { get; set; }


        /// <summary>
        /// StateTenureLength
        /// </summary> 

        [AliasAs("StateTenureLength")]
        public float? StateTenureLength { get; set; }


        /// <summary>
        /// StateTenurePeriod
        /// </summary> 

        [AliasAs("StateTenurePeriod")]
        public string StateTenurePeriod { get; set; }

    }
}