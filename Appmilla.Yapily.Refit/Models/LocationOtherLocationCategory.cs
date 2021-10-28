using Refit;

namespace Appmilla.Yapily.Refit.Models
{
    /// <summary>
    /// Enter a new code , name and description for any other location category    /// </summary>    
    public class LocationOtherLocationCategory
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