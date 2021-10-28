using Refit;

namespace Appmilla.Yapily.Refit.Models
{
    /// <summary>
    /// IsoCodeDetails
    /// </summary>    
    public class IsoCodeDetails
    {

        /// <summary>
        /// Code
        /// </summary> 

        [AliasAs("code")]
        public string Code { get; set; }


        /// <summary>
        /// Name
        /// </summary> 

        [AliasAs("name")]
        public string Name { get; set; }

    }
}