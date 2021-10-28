using Refit;

namespace Appmilla.Yapily.Refit.Models
{
    /// <summary>
    /// Pagination
    /// </summary>    
    public class Pagination
    {

        /// <summary>
        /// Next
        /// </summary> 

        [AliasAs("next")]
        public Next Next { get; set; }


        /// <summary>
        /// Self
        /// </summary> 

        [AliasAs("self")]
        public FilterAndSort Self { get; set; }


        /// <summary>
        /// TotalCount
        /// </summary> 

        [AliasAs("totalCount")]
        public long? TotalCount { get; set; }

    }
}