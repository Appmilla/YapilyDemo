using Refit;

namespace Appmilla.Yapily.Refit.Models
{
    /// <summary>
    /// URI
    /// </summary>    
    public class URI
    {

        /// <summary>
        /// Absolute
        /// </summary> 

        [AliasAs("absolute")]
        public bool? Absolute { get; set; }


        /// <summary>
        /// Authority
        /// </summary> 

        [AliasAs("authority")]
        public string Authority { get; set; }


        /// <summary>
        /// Fragment
        /// </summary> 

        [AliasAs("fragment")]
        public string Fragment { get; set; }


        /// <summary>
        /// Host
        /// </summary> 

        [AliasAs("host")]
        public string Host { get; set; }


        /// <summary>
        /// Opaque
        /// </summary> 

        [AliasAs("opaque")]
        public bool? Opaque { get; set; }


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
        /// Query
        /// </summary> 

        [AliasAs("query")]
        public string Query { get; set; }


        /// <summary>
        /// RawAuthority
        /// </summary> 

        [AliasAs("rawAuthority")]
        public string RawAuthority { get; set; }


        /// <summary>
        /// RawFragment
        /// </summary> 

        [AliasAs("rawFragment")]
        public string RawFragment { get; set; }


        /// <summary>
        /// RawPath
        /// </summary> 

        [AliasAs("rawPath")]
        public string RawPath { get; set; }


        /// <summary>
        /// RawQuery
        /// </summary> 

        [AliasAs("rawQuery")]
        public string RawQuery { get; set; }


        /// <summary>
        /// RawSchemeSpecificPart
        /// </summary> 

        [AliasAs("rawSchemeSpecificPart")]
        public string RawSchemeSpecificPart { get; set; }


        /// <summary>
        /// RawUserInfo
        /// </summary> 

        [AliasAs("rawUserInfo")]
        public string RawUserInfo { get; set; }


        /// <summary>
        /// Scheme
        /// </summary> 

        [AliasAs("scheme")]
        public string Scheme { get; set; }


        /// <summary>
        /// SchemeSpecificPart
        /// </summary> 

        [AliasAs("schemeSpecificPart")]
        public string SchemeSpecificPart { get; set; }


        /// <summary>
        /// UserInfo
        /// </summary> 

        [AliasAs("userInfo")]
        public string UserInfo { get; set; }

    }
}