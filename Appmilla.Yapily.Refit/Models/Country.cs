using Refit;

namespace Appmilla.Yapily.Refit.Models
{
    /// <summary>
    /// An array of `Country` denoting which regions the `Institution` provides coverage for    /// </summary>    
    public class Country
    {

        /// <summary>
        /// CountryCode2
        /// </summary> 

        [AliasAs("countryCode2")]
        public string CountryCode2 { get; set; }


        /// <summary>
        /// DisplayName
        /// </summary> 

        [AliasAs("displayName")]
        public string DisplayName { get; set; }

    }
}