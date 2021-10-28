using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Refit;

namespace Cms
{
    /// <summary>
    /// ConsentAuthCodeRequest
    /// </summary>    
    public class ConsentAuthCodeRequest
    {

        /// <summary>
        /// AuthCode
        /// </summary> 
        [Required(AllowEmptyStrings = true)]

        [AliasAs("authCode")]
        public string AuthCode { get; set; }


        /// <summary>
        /// AuthState
        /// </summary> 
        [Required(AllowEmptyStrings = true)]

        [AliasAs("authState")]
        public string AuthState { get; set; }

    }
}