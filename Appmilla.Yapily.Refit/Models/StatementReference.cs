using Refit;

namespace Appmilla.Yapily.Refit.Models
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