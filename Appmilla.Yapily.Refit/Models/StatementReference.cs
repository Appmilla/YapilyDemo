using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Refit;

namespace Cms
{
    /// <summary>
    /// StatementReference
    /// </summary>    
    public class StatementReference
    {

        /// <summary>
        /// Value
        /// </summary> 

        [AliasAs("value")]
        public string Value { get; set; }

    }
}