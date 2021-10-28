using Refit;

namespace Appmilla.Yapily.Refit.Models
{
    /// <summary>
    /// Resource
    /// </summary>    
    public class Resource
    {

        /// <summary>
        /// Description
        /// </summary> 

        [AliasAs("description")]
        public string Description { get; set; }


        /// <summary>
        /// File
        /// </summary> 

        [AliasAs("file")]
        public File File { get; set; }


        /// <summary>
        /// Filename
        /// </summary> 

        [AliasAs("filename")]
        public string Filename { get; set; }


        /// <summary>
        /// InputStream
        /// </summary> 

        [AliasAs("inputStream")]
        public InputStream InputStream { get; set; }


        /// <summary>
        /// Open
        /// </summary> 

        [AliasAs("open")]
        public bool? Open { get; set; }


        /// <summary>
        /// Readable
        /// </summary> 

        [AliasAs("readable")]
        public bool? Readable { get; set; }


        /// <summary>
        /// Uri
        /// </summary> 

        [AliasAs("uri")]
        public URI Uri { get; set; }


        /// <summary>
        /// Url
        /// </summary> 

        [AliasAs("url")]
        public URL Url { get; set; }

    }
}