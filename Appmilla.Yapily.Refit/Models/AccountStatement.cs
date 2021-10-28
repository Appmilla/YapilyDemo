using Refit;

namespace Appmilla.Yapily.Refit.Models
{
    /// <summary>
    /// AccountStatement
    /// </summary>    
    public class AccountStatement
    {

        /// <summary>
        /// Id
        /// </summary> 

        [AliasAs("id")]
        public string Id { get; set; }


        /// <summary>
        /// StartDateTime
        /// </summary> 

        [AliasAs("startDateTime")]
        public System.DateTimeOffset? StartDateTime { get; set; }


        /// <summary>
        /// EndDateTime
        /// </summary> 

        [AliasAs("endDateTime")]
        public System.DateTimeOffset? EndDateTime { get; set; }


        /// <summary>
        /// CreationDateTime
        /// </summary> 

        [AliasAs("creationDateTime")]
        public System.DateTimeOffset? CreationDateTime { get; set; }

    }
}