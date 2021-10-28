using Refit;

namespace Appmilla.Yapily.Refit.Models
{
    /// <summary>
    /// Next
    /// </summary>    
    public class Next
    {

        /// <summary>
        /// Before
        /// </summary> 

        [AliasAs("before")]
        public System.DateTimeOffset? Before { get; set; }


        /// <summary>
        /// Cursor
        /// </summary> 

        [AliasAs("cursor")]
        public string Cursor { get; set; }


        /// <summary>
        /// From
        /// </summary> 

        [AliasAs("from")]
        public System.DateTimeOffset? From { get; set; }


        /// <summary>
        /// Limit
        /// </summary> 

        [AliasAs("limit")]
        public int? Limit { get; set; }

    }
}