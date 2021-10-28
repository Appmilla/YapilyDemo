using Refit;

namespace Appmilla.Yapily.Refit.Models
{
    /// <summary>
    /// Used by a Financial Institution internally to identify the location of an ATM.    /// </summary>    
    public class Site
    {

        /// <summary>
        /// Identification
        /// </summary> 

        [AliasAs("Identification")]
        public string Identification { get; set; }


        /// <summary>
        /// Name
        /// </summary> 

        [AliasAs("Name")]
        public string Name { get; set; }

    }
}