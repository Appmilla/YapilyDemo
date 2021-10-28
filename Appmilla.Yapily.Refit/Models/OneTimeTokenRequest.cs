using Refit;

namespace Appmilla.Yapily.Refit.Models
{
    /// <summary>
    /// OneTimeTokenRequest
    /// </summary>    
    public class OneTimeTokenRequest
    {

        /// <summary>
        /// OneTimeToken
        /// </summary> 
        //[Required(AllowEmptyStrings = true)]

        [AliasAs("oneTimeToken")]
        public string OneTimeToken { get; set; }

    }
}