using Refit;

namespace Appmilla.Yapily.Refit.Models
{
    /// <summary>
    /// MonitoringFeatureStatus
    /// </summary>    
    public class MonitoringFeatureStatus
    {

        /// <summary>
        /// LastTested
        /// </summary> 

        [AliasAs("lastTested")]
        public System.DateTimeOffset? LastTested { get; set; }


        /// <summary>
        /// Span
        /// </summary> 

        [AliasAs("span")]
        public string Span { get; set; }


        /// <summary>
        /// Status
        /// </summary> 

        [AliasAs("status")]
        public MonitoringFeatureStatusStatus? Status { get; set; }

    }
}