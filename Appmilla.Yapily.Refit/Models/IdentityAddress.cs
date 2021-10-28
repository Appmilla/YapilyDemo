using System.Collections.Generic;
using Refit;

namespace Appmilla.Yapily.Refit.Models
{
    /// <summary>
    /// IdentityAddress
    /// </summary>    
    public class IdentityAddress
    {

        /// <summary>
        /// AddressLines
        /// </summary> 

        [AliasAs("addressLines")]
        public List<string> AddressLines { get; set; }


        /// <summary>
        /// City
        /// </summary> 

        [AliasAs("city")]
        public string City { get; set; }


        /// <summary>
        /// PostalCode
        /// </summary> 

        [AliasAs("postalCode")]
        public string PostalCode { get; set; }


        /// <summary>
        /// Country
        /// </summary> 

        [AliasAs("country")]
        public string Country { get; set; }


        /// <summary>
        /// StreetName
        /// </summary> 

        [AliasAs("streetName")]
        public string StreetName { get; set; }


        /// <summary>
        /// BuildingNumber
        /// </summary> 

        [AliasAs("buildingNumber")]
        public string BuildingNumber { get; set; }


        /// <summary>
        /// Type
        /// </summary> 

        [AliasAs("type")]
        public IdentityAddressType? Type { get; set; }


        /// <summary>
        /// County
        /// </summary> 

        [AliasAs("county")]
        public string County { get; set; }

    }
}