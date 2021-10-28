using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Refit;

namespace Cms
{
    /// <summary>
    /// Enter a new code , name and description for any other ATM Service    /// </summary>    
    public class InlineResponse2001OtherATMServices
    {

        /// <summary>
        /// Code
        /// </summary> 

        [AliasAs("Code")]
        public string Code { get; set; }


        /// <summary>
        /// Description
        /// </summary> 

        [AliasAs("Description")]
        public string Description { get; set; }


        /// <summary>
        /// Name
        /// </summary> 

        [AliasAs("Name")]
        public string Name { get; set; }

    }
}