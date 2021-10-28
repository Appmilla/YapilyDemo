using Refit;

namespace Appmilla.Yapily.Refit.Models
{
    /// <summary>
    /// URL
    /// </summary>    
    public class URL
    {

        /// <summary>
        /// Authority
        /// </summary> 

        [AliasAs("authority")]
        public string Authority { get; set; }


        /// <summary>
        /// Content
        /// </summary> 

        [AliasAs("content")]
        public object Content { get; set; }


        /// <summary>
        /// DefaultPort
        /// </summary> 

        [AliasAs("defaultPort")]
        public int? DefaultPort { get; set; }


        /// <summary>
        /// File
        /// </summary> 

        [AliasAs("file")]
        public string File { get; set; }


        /// <summary>
        /// Host
        /// </summary> 

        [AliasAs("host")]
        public string Host { get; set; }


        /// <summary>
        /// Path
        /// </summary> 

        [AliasAs("path")]
        public string Path { get; set; }


        /// <summary>
        /// Port
        /// </summary> 

        [AliasAs("port")]
        public int? Port { get; set; }


        /// <summary>
        /// Protocol
        /// </summary> 

        [AliasAs("protocol")]
        public string Protocol { get; set; }


        /// <summary>
        /// Query
        /// </summary> 

        [AliasAs("query")]
        public string Query { get; set; }


        /// <summary>
        /// Ref
        /// </summary> 

        [AliasAs("ref")]
        public string Ref { get; set; }


        /// <summary>
        /// UserInfo
        /// </summary> 

        [AliasAs("userInfo")]
        public string UserInfo { get; set; }

    }
}