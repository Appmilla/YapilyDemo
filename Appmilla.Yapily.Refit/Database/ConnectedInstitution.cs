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
    }
}