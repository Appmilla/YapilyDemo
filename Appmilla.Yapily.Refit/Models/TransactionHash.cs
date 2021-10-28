using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Refit;

namespace Cms
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