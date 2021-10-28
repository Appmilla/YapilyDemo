using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Refit;

namespace Cms
{
    /// <summary>
    /// FilterAndSort
    /// </summary>    
    public class FilterAndSort
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


        /// <summary>
        /// Offset
        /// </summary> 

        [AliasAs("offset")]
        public int? Offset { get; set; }


        /// <summary>
        /// Sort
        /// </summary> 

        [AliasAs("sort")]
        public FilterAndSortSort? Sort { get; set; }

    }
}