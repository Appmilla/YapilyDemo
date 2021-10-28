using SQLite;

namespace Appmilla.Yapily.Refit.Database
{
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
}