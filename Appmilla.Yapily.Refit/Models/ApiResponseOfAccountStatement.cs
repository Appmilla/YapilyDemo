﻿using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Refit;

namespace Cms
{
    /// <summary>
    /// ApiResponseOfAccountStatement
    /// </summary>    
    public class ApiResponseOfAccountStatement
    {

        /// <summary>
        /// Meta
        /// </summary> 

        [AliasAs("meta")]
        public ResponseMeta Meta { get; set; }


        /// <summary>
        /// Data
        /// </summary> 

        [AliasAs("data")]
        public AccountStatement Data { get; set; }


        /// <summary>
        /// Links
        /// </summary> 

        [AliasAs("links")]
        public System.Collections.Generic.IDictionary<string, string> Links { get; set; }

    }
}