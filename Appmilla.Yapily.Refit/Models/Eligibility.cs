using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Refit;

namespace Cms
{
    /// <summary>
    /// Eligibility details for this product i.e. the criteria that an accountholder has to meet in order to be eligible for the PCA product.    /// </summary>    
    public class Eligibility
    {

        /// <summary>
        /// AgeEligibility
        /// </summary> 

        [AliasAs("AgeEligibility")]
        public AgeEligibility AgeEligibility { get; set; }


        /// <summary>
        /// CreditCheck
        /// </summary> 

        [AliasAs("CreditCheck")]
        public CreditCheck CreditCheck { get; set; }


        /// <summary>
        /// IDVerificationCheck
        /// </summary> 

        [AliasAs("IDVerificationCheck")]
        public IDVerificationCheck IDVerificationCheck { get; set; }


        /// <summary>
        /// OtherEligibility
        /// </summary> 

        [AliasAs("OtherEligibility")]
        public List<EligibilityOtherEligibility> OtherEligibility { get; set; }


        /// <summary>
        /// ResidencyEligibility
        /// </summary> 

        [AliasAs("ResidencyEligibility")]
        public ResidencyEligibility ResidencyEligibility { get; set; }

    }
}