using System.Collections.Generic;
using Refit;

namespace Appmilla.Yapily.Refit.Models
{
    /// <summary>
    /// Application
    /// </summary>    
    public class Application
    {
        /// <summary>
        /// Application UUID
        /// </summary>
        [AliasAs("uuid")]
        public string Uuid { get; set; }


        /// <summary>
        /// Name
        /// </summary> 

        [AliasAs("name")]
        public string Name { get; set; }


        /// <summary>
        /// Active
        /// </summary> 

        [AliasAs("active")]
        public bool? Active { get; set; }


        /// <summary>
        /// AuthCallbacks
        /// </summary> 

        [AliasAs("authCallbacks")]
        public List<string> AuthCallbacks { get; set; }


        /// <summary>
        /// Institutions
        /// </summary> 

        [AliasAs("institutions")]
        public List<Institution> Institutions { get; set; }


        /// <summary>
        /// Media
        /// </summary> 

        [AliasAs("media")]
        public List<Media> Media { get; set; }


        /// <summary>
        /// Created
        /// </summary> 

        [AliasAs("created")]
        public System.DateTimeOffset? Created { get; set; }


        /// <summary>
        /// Updated
        /// </summary> 

        [AliasAs("updated")]
        public System.DateTimeOffset? Updated { get; set; }

    }
}