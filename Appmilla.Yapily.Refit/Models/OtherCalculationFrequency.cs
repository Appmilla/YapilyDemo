using Refit;

namespace Appmilla.Yapily.Refit.Models
{
    /// <summary>
    /// Other calculation frequency which is not available in the standard code set.    /// </summary>    
    public class OtherCalculationFrequency
    {

        /// <summary>
        /// Code
        /// </summary> 

        [AliasAs("Code")]
        public string Code { get; set; }


        /// <summary>
        /// Description
        /// </summary> 

        [AliasAs("Description")]
        public string Description { get; set; }


        /// <summary>
        /// Name
        /// </summary> 

        [AliasAs("Name")]
        public string Name { get; set; }

    }
}