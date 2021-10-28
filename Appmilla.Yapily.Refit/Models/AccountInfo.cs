using Refit;

namespace Appmilla.Yapily.Refit.Models
{
    /// <summary>
    /// AccountInfo
    /// </summary>    
    public class AccountInfo
    {

        /// <summary>
        /// AccountId
        /// </summary> 

        [AliasAs("accountId")]
        public string AccountId { get; set; }


        /// <summary>
        /// AccountIdentification
        /// </summary> 

        [AliasAs("accountIdentification")]
        public AccountIdentification AccountIdentification { get; set; }

    }
}