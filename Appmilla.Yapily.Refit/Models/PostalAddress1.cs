using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Refit;

namespace Cms
{
    /// <summary>
    /// Information that locates and identifies a specific address, as defined by postal services or in free format text.    /// </summary>    
    public class PostalAddress1
    {

        /// <summary>
        /// AddressLine
        /// </summary> 

        [AliasAs("AddressLine")]
        public List<string> AddressLine { get; set; }


        /// <summary>
        /// BuildingNumber
        /// </summary> 

        [AliasAs("BuildingNumber")]
        public string BuildingNumber { get; set; }


        /// <summary>
        /// Country
        /// </summary> 

        [AliasAs("Country")]
        public string Country { get; set; }


        /// <summary>
        /// CountrySubDivision
        /// </summary> 

        [AliasAs("CountrySubDivision")]
        public List<string> CountrySubDivision { get; set; }


        /// <summary>
        /// GeoLocation
        /// </summary> 

        [AliasAs("GeoLocation")]
        public GeoLocation1 GeoLocation { get; set; }


        /// <summary>
        /// PostCode
        /// </summary> 

        [AliasAs("PostCode")]
        public string PostCode { get; set; }


        /// <summary>
        /// StreetName
        /// </summary> 

        [AliasAs("StreetName")]
        public string StreetName { get; set; }


        /// <summary>
        /// TownName
        /// </summary> 

        [AliasAs("TownName")]
        public string TownName { get; set; }

    }
}