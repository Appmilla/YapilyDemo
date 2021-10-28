using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Refit;

namespace Cms
{
    /// <summary>
    /// File
    /// </summary>    
    public class File
    {

        /// <summary>
        /// Absolute
        /// </summary> 

        [AliasAs("absolute")]
        public bool? Absolute { get; set; }


        /// <summary>
        /// AbsoluteFile
        /// </summary> 

        [AliasAs("absoluteFile")]
        public File AbsoluteFile { get; set; }


        /// <summary>
        /// AbsolutePath
        /// </summary> 

        [AliasAs("absolutePath")]
        public string AbsolutePath { get; set; }


        /// <summary>
        /// CanonicalFile
        /// </summary> 

        [AliasAs("canonicalFile")]
        public File CanonicalFile { get; set; }


        /// <summary>
        /// CanonicalPath
        /// </summary> 

        [AliasAs("canonicalPath")]
        public string CanonicalPath { get; set; }


        /// <summary>
        /// Directory
        /// </summary> 

        [AliasAs("directory")]
        public bool? Directory { get; set; }


        /// <summary>
        /// File1
        /// </summary> 

        [AliasAs("file")]
        public bool? File1 { get; set; }


        /// <summary>
        /// FreeSpace
        /// </summary> 

        [AliasAs("freeSpace")]
        public long? FreeSpace { get; set; }


        /// <summary>
        /// Hidden
        /// </summary> 

        [AliasAs("hidden")]
        public bool? Hidden { get; set; }


        /// <summary>
        /// Name
        /// </summary> 

        [AliasAs("name")]
        public string Name { get; set; }


        /// <summary>
        /// Parent
        /// </summary> 

        [AliasAs("parent")]
        public string Parent { get; set; }


        /// <summary>
        /// ParentFile
        /// </summary> 

        [AliasAs("parentFile")]
        public File ParentFile { get; set; }


        /// <summary>
        /// Path
        /// </summary> 

        [AliasAs("path")]
        public string Path { get; set; }


        /// <summary>
        /// TotalSpace
        /// </summary> 

        [AliasAs("totalSpace")]
        public long? TotalSpace { get; set; }


        /// <summary>
        /// UsableSpace
        /// </summary> 

        [AliasAs("usableSpace")]
        public long? UsableSpace { get; set; }

    }
}