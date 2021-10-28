using Refit;

namespace Appmilla.Yapily.Refit.Models
{
    /// <summary>
    /// ResponseMeta
    /// </summary>    
    public class ResponseMeta
    {

        /// <summary>
        /// TracingId
        /// </summary> 

        [AliasAs("tracingId")]
        public string TracingId { get; set; }

    }
}