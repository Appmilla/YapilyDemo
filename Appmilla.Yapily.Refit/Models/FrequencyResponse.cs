using Refit;

namespace Appmilla.Yapily.Refit.Models
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