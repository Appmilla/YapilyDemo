using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Refit;

namespace Cms
{
    /// <summary>
    /// Information that locates and identifies a specific branch of a financial institution.    /// </summary>    
    public class Branch
    {

        /// <summary>
        /// Identification
        /// </summary> 

        [AliasAs("Identification")]
        public string Identification { get; set; }

    }
}