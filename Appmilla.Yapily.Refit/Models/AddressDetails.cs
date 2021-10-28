using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Refit;

namespace Cms
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