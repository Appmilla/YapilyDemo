using System.Collections.Generic;
using Refit;

namespace Appmilla.Yapily.Refit.Models
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