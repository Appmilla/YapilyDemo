using Refit;

namespace Appmilla.Yapily.Refit.Models
{
    /// <summary>
    /// Geographic location of the ATM specified by geographic coordinates or UTM coordinates.    /// </summary>    
    public class GeoLocation1
    {

        /// <summary>
        /// GeographicCoordinates
        /// </summary> 

        [AliasAs("GeographicCoordinates")]
        public GeographicCoordinates1 GeographicCoordinates { get; set; }

    }
}