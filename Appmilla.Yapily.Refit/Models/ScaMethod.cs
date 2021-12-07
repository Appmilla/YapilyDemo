using System.ComponentModel.DataAnnotations;
using Refit;

namespace Appmilla.Yapily.Refit.Models
{
    /// <summary>
    /// ScaMethod
    /// </summary>    
    public class ScaMethod
    {

        /// <summary>
        /// Id
        /// </summary> 
        [Required(AllowEmptyStrings = true)]
        [AliasAs("id")]
        public string Id { get; set; }


        /// <summary>
        /// Type
        /// </summary> 

        [AliasAs("type")]
        public ScaMethodType? Type { get; set; }


        /// <summary>
        /// Description
        /// </summary> 

        [AliasAs("description")]
        public string Description { get; set; }

    }
}