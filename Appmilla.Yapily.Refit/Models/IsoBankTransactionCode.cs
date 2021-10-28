using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Refit;

namespace Cms
{
    /// <summary>
    /// IsoBankTransactionCode
    /// </summary>    
    public class IsoBankTransactionCode
    {

        /// <summary>
        /// DomainCode
        /// </summary> 

        [AliasAs("domainCode")]
        public IsoCodeDetails DomainCode { get; set; }


        /// <summary>
        /// FamilyCode
        /// </summary> 

        [AliasAs("familyCode")]
        public IsoCodeDetails FamilyCode { get; set; }


        /// <summary>
        /// SubFamilyCode
        /// </summary> 

        [AliasAs("subFamilyCode")]
        public IsoCodeDetails SubFamilyCode { get; set; }

    }
}