using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Refit;

namespace Cms
{
    /// <summary>
    /// ATM information.    /// </summary>    
    public class InlineResponse2001ATM
    {

        /// <summary>
        /// ATMServices
        /// </summary> 

        [AliasAs("ATMServices")]
        public List<ATMServices> ATMServices { get; set; }


        /// <summary>
        /// Access24HoursIndicator
        /// </summary> 

        [AliasAs("Access24HoursIndicator")]
        public bool? Access24HoursIndicator { get; set; }


        /// <summary>
        /// Accessibility
        /// </summary> 

        [AliasAs("Accessibility")]
        public List<Accessibility> Accessibility { get; set; }


        /// <summary>
        /// Branch
        /// </summary> 

        [AliasAs("Branch")]
        public Branch Branch { get; set; }


        /// <summary>
        /// Identification
        /// </summary> 

        [AliasAs("Identification")]
        public string Identification { get; set; }


        /// <summary>
        /// Location
        /// </summary> 

        [AliasAs("Location")]
        public Location Location { get; set; }


        /// <summary>
        /// MinimumPossibleAmount
        /// </summary> 

        [AliasAs("MinimumPossibleAmount")]
        public string MinimumPossibleAmount { get; set; }


        /// <summary>
        /// Note
        /// </summary> 

        [AliasAs("Note")]
        public List<string> Note { get; set; }


        /// <summary>
        /// OtherATMServices
        /// </summary> 

        [AliasAs("OtherATMServices")]
        public List<InlineResponse2001OtherATMServices> OtherATMServices { get; set; }


        /// <summary>
        /// OtherAccessibility
        /// </summary> 

        [AliasAs("OtherAccessibility")]
        public List<InlineResponse2001OtherAccessibility> OtherAccessibility { get; set; }


        /// <summary>
        /// SupportedCurrencies
        /// </summary> 

        [AliasAs("SupportedCurrencies")]
        public List<string> SupportedCurrencies { get; set; }


        /// <summary>
        /// SupportedLanguages
        /// </summary> 

        [AliasAs("SupportedLanguages")]
        public List<string> SupportedLanguages { get; set; }

    }
}