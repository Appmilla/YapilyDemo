using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Refit;

namespace Cms
{
    /// <summary>
    /// ATMOpenDataResponse
    /// </summary>    
    public class ATMOpenDataResponse
    {

        /// <summary>
        /// Data
        /// </summary> 

        [AliasAs("data")]
        public List<ATMOpenData> Data { get; set; }

    }
}