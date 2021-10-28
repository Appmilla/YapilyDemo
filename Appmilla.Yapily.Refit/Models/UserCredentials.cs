using Refit;

namespace Appmilla.Yapily.Refit.Models
{
    /// <summary>
    /// UserCredentials
    /// </summary>    
    public class UserCredentials
    {

        /// <summary>
        /// Id
        /// </summary> 
        //[Required(AllowEmptyStrings = true)]

        [AliasAs("id")]
        public string Id { get; set; }


        /// <summary>
        /// CorporateId
        /// </summary> 

        [AliasAs("corporateId")]
        public string CorporateId { get; set; }


        /// <summary>
        /// Password
        /// </summary> 
        //[Required(AllowEmptyStrings = true)]

        [AliasAs("password")]
        public string Password { get; set; }

    }
}