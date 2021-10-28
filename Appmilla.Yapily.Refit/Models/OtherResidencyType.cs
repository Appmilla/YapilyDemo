using Refit;

namespace Appmilla.Yapily.Refit.Models
{
    /// <summary>
    /// Other residency type which is not available in standard code list.    /// </summary>    
    public class OtherResidencyType
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