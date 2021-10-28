using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Refit;

namespace Cms
{
    /// <summary>
    /// Links on popular map services pointing the ATM Location on the earth.    /// </summary>    
    public class ATMMapServiceLinks
    {

        /// <summary>
        /// BingMapsUrl
        /// </summary> 

        [AliasAs("bingMapsUrl")]
        public string BingMapsUrl { get; set; }


        /// <summary>
        /// GoogleMapsUrl
        /// </summary> 

        [AliasAs("googleMapsUrl")]
        public string GoogleMapsUrl { get; set; }


        /// <summary>
        /// HereMapsUrl
        /// </summary> 

        [AliasAs("hereMapsUrl")]
        public string HereMapsUrl { get; set; }

    }
}