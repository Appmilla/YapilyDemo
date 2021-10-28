using Refit;

namespace Appmilla.Yapily.Refit.Models
{
    /// <summary>
    /// Other application frequencies that are not available in the standard code list    /// </summary>    
    public class OtherApplicationFrequency
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