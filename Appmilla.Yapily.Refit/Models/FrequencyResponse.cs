using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Refit;

namespace Cms
{
    /// <summary>
    /// FrequencyResponse
    /// </summary>    
    public class FrequencyResponse
    {

        /// <summary>
        /// ExecutionDay
        /// </summary> 

        [AliasAs("executionDay")]
        public int? ExecutionDay { get; set; }


        /// <summary>
        /// FrequencyType
        /// </summary> 

        [AliasAs("frequencyType")]
        public FrequencyResponseFrequencyType? FrequencyType { get; set; }


        /// <summary>
        /// IntervalMonth
        /// </summary> 

        [AliasAs("intervalMonth")]
        public int? IntervalMonth { get; set; }


        /// <summary>
        /// IntervalWeek
        /// </summary> 

        [AliasAs("intervalWeek")]
        public int? IntervalWeek { get; set; }

    }
}