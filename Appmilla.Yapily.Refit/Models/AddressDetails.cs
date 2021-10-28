using Refit;

namespace Appmilla.Yapily.Refit.Models
{
    /// <summary>
    /// AddressDetails
    /// </summary>    
    public class AddressDetails
    {

        /// <summary>
        /// AddressLine
        /// </summary> 

        [AliasAs("addressLine")]
        public string AddressLine { get; set; }

    }
}