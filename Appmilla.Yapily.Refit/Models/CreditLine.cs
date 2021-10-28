using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Refit;

namespace Cms
{
    /// <summary>
    /// CreditLine
    /// </summary>    
    public class CreditLine
    {

        /// <summary>
        /// Type
        /// </summary> 

        [AliasAs("type")]
        public CreditLineType? Type { get; set; }


        /// <summary>
        /// CreditLineAmount
        /// </summary> 

        [AliasAs("creditLineAmount")]
        public Amount CreditLineAmount { get; set; }

    }
}