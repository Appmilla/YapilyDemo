using System.Collections.Generic;
using Refit;

namespace Appmilla.Yapily.Refit.Models
{
    /// <summary>
    /// Identity
    /// </summary>    
    public class Identity
    {

        /// <summary>
        /// Id
        /// </summary> 

        [AliasAs("id")]
        public string Id { get; set; }


        /// <summary>
        /// FirstName
        /// </summary> 

        [AliasAs("firstName")]
        public string FirstName { get; set; }


        /// <summary>
        /// LastName
        /// </summary> 

        [AliasAs("lastName")]
        public string LastName { get; set; }


        /// <summary>
        /// FullName
        /// </summary> 

        [AliasAs("fullName")]
        public string FullName { get; set; }


        /// <summary>
        /// Gender
        /// </summary> 

        [AliasAs("gender")]
        public string Gender { get; set; }


        /// <summary>
        /// Birthdate
        /// </summary> 

        [AliasAs("birthdate")]
        public string Birthdate { get; set; }


        /// <summary>
        /// Email
        /// </summary> 

        [AliasAs("email")]
        public string Email { get; set; }


        /// <summary>
        /// Phone
        /// </summary> 

        [AliasAs("phone")]
        public string Phone { get; set; }


        /// <summary>
        /// Addresses
        /// </summary> 

        [AliasAs("addresses")]
        public List<IdentityAddress> Addresses { get; set; }

    }
}