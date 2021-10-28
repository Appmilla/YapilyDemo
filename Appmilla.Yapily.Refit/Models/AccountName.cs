using Refit;

namespace Appmilla.Yapily.Refit.Models
{
    /// <summary>
    /// AccountName
    /// </summary>    
    public class AccountName
    {

        /// <summary>
        /// Name
        /// </summary> 
        //[Required(AllowEmptyStrings = true)]

        [AliasAs("name")]
        public string Name { get; set; }

    }
}