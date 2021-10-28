using Refit;

namespace Appmilla.Yapily.Refit.Models
{
    /// <summary>
    /// Location on the earth specified by two numbers representing vertical and horizontal position.    /// </summary>    
    public class GeographicCoordinates1
    {

        /// <summary>
        /// Latitude
        /// </summary> 

        [AliasAs("Latitude")]
        public string Latitude { get; set; }


        /// <summary>
        /// Longitude
        /// </summary> 

        [AliasAs("Longitude")]
        public string Longitude { get; set; }

    }
}