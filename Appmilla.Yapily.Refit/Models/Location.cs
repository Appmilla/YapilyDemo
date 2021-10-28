using System.Collections.Generic;
using Refit;

namespace Appmilla.Yapily.Refit.Models
{
    /// <summary>
    /// Location of the ATM.    /// </summary>    
    public class Location
    {

        /// <summary>
        /// LocationCategory
        /// </summary> 

        [AliasAs("LocationCategory")]
        public List<LocationCategory> LocationCategory { get; set; }


        /// <summary>
        /// OtherLocationCategory
        /// </summary> 

        [AliasAs("OtherLocationCategory")]
        public List<LocationOtherLocationCategory> OtherLocationCategory { get; set; }


        /// <summary>
        /// PostalAddress
        /// </summary> 

        [AliasAs("PostalAddress")]
        public PostalAddress1 PostalAddress { get; set; }


        /// <summary>
        /// Site
        /// </summary> 

        [AliasAs("Site")]
        public Site Site { get; set; }


        /// <summary>
        /// MapServiceLinks
        /// </summary> 

        [AliasAs("mapServiceLinks")]
        public ATMMapServiceLinks MapServiceLinks { get; set; }

    }
}