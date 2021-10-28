using Refit;

namespace Appmilla.Yapily.Refit.Models
{
    /// <summary>
    /// TransactionHash
    /// </summary>    
    public class TransactionHash
    {
        /// <summary>
        /// hash
        /// </summary>
        [AliasAs("hash")]
        public string Hash { get; set; }

    }
}