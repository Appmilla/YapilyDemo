using Newtonsoft.Json;
using Refit;

namespace Appmilla.Yapily.Refit.Models
{
    /// <summary>
    /// Amount
    /// </summary>    
    public class Amount
    {

        /// <summary>
        /// Amount1
        /// </summary> 

        [AliasAs("amount")]
        [JsonProperty(PropertyName="amount")]
        public double Amount1 { get; set; }

        /// <summary>
        /// ISO 4217 currency code
        /// </summary>        //[Required(AllowEmptyStrings = true)]

        [AliasAs("currency")]
        public string Currency { get; set; }

    }
}