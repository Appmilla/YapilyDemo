using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Refit;

namespace Cms
{
    /// <summary>
    /// Address
    /// </summary>    
    public class Address
    {

        /// <summary>
        /// AddressLines
        /// </summary> 

        [AliasAs("addressLines")]
        public List<string> AddressLines { get; set; }


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
        /// PostCode
        /// </summary> 

        [AliasAs("postCode")]
        public string PostCode { get; set; }


        /// <summary>
        /// TownName
        /// </summary> 

        [AliasAs("townName")]
        public string TownName { get; set; }


        /// <summary>
        /// County
        /// </summary> 

        [AliasAs("county")]
        public List<string> County { get; set; }


        /// <summary>
        /// AddressType
        /// </summary> 

        [AliasAs("addressType")]
        public AddressType? AddressType { get; set; }


        /// <summary>
        /// Country
        /// </summary> 

        [AliasAs("country")]
        public string Country { get; set; }


        /// <summary>
        /// Department
        /// </summary> 

        [AliasAs("department")]
        public string Department { get; set; }


        /// <summary>
        /// SubDepartment
        /// </summary> 

        [AliasAs("subDepartment")]
        public string SubDepartment { get; set; }

    }
}