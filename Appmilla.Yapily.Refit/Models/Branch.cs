using Refit;

namespace Appmilla.Yapily.Refit.Models
{
    /// <summary>
    /// Information that locates and identifies a specific branch of a financial institution.    /// </summary>    
    public class Branch
    {

        /// <summary>
        /// Identification
        /// </summary> 

        [AliasAs("Identification")]
        public string Identification { get; set; }

    }
}