using System;
using Appmilla.Yapily.Refit.Models;
using SQLite;

namespace Appmilla.Yapily.Refit.Database
{
    public class ConnectedInstitution
    {
        public string InstitutionId { get; set; }
        
        public ConsentStatus? Status { get; set; }
        
        public string ConsentToken { get; set; }
       
        public DateTimeOffset? AuthorizedAt { get; set; }
        
        //public string FullName { get; set; }
        
        //public string Name { get; set; }
        
        //public string ImageUrl { get; set; }
    }
    /*
    public class ConnectedInstitution
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        
        [Indexed]
        public string InstitutionId { get; set; }
        
        public string FullName { get; set; }
        
        public string Name { get; set; }
        
        public string ImageUrl { get; set; }
    }
    */
}