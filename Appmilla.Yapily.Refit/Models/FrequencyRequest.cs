using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Refit;

namespace Cms
{
    /// <summary>
    /// FrequencyRequest
    /// </summary>    
    public class FrequencyRequest
    {

        /// <summary>
        /// Type
        /// </summary> 

        [AliasAs("type")]
        public FrequencyRequestType? Type { get; set; }


        /// <summary>
        /// IntervalWeek
        /// </summary> 

        [AliasAs("intervalWeek")]
        public int? IntervalWeek { get; set; }


        /// <summary>
        /// IntervalMonth
        /// </summary> 

        [AliasAs("intervalMonth")]
        public int? IntervalMonth { get; set; }


        /// <summary>
        /// ExecutionDay
        /// </summary> 

        [AliasAs("executionDay")]
        public int? ExecutionDay { get; set; }

    }
}