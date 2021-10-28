using Refit;

namespace Appmilla.Yapily.Refit.Models
{
    /// <summary>
    /// RedirectRequest
    /// </summary>    
    public class RedirectRequest
    {

        /// <summary>
        /// Url
        /// </summary> 
        //[Required(AllowEmptyStrings = true)]

        [AliasAs("url")]
        public string Url { get; set; }

    }
}