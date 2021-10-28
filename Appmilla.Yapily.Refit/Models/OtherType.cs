using Refit;

namespace Appmilla.Yapily.Refit.Models
{
    /// <summary>
    /// Non-standard eligibility type code.    /// </summary>    
    public class OtherType
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