using Refit;

namespace Appmilla.Yapily.Refit.Models
{
    /// <summary>
    /// NewApplicationUser
    /// </summary>    
    public class NewApplicationUser
    {

        /// <summary>
        /// ApplicationUserId
        /// </summary> 

        [AliasAs("applicationUserId")]
        public string ApplicationUserId { get; set; }


        /// <summary>
        /// ReferenceId
        /// </summary> 

        [AliasAs("referenceId")]
        public string ReferenceId { get; set; }

    }
}