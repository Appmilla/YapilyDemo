using System.Collections.Generic;
using System.Threading.Tasks;
using SQLite;

namespace Appmilla.Yapily.Refit.Database
{
    public interface IConnectedInstitutionsDb
    {
        bool IsInitialised { get; }
        
        Task<CreateTableResult> CreateTable();

        Task<List<ConnectedInstitution>> GetInstitutionsAsync();

        Task<List<ConnectedInstitution>> GetInstitutionByInstitutionIdAsync(string institutionId);

        Task<ConnectedInstitution> GetInstitutionAsync(int id);

        Task<int> SaveInstitutionAsync(ConnectedInstitution institution);

        Task<int> DeleteInstitutionAsync(ConnectedInstitution institution);
    }
    
    public class ConnectedInstitutionsDb : IConnectedInstitutionsDb
    {
        static SQLiteAsyncConnection Database;

        public bool IsInitialised { get; private set; }
        
        public static readonly AsyncLazy<ConnectedInstitutionsDb> Instance = new AsyncLazy<ConnectedInstitutionsDb>(async () =>
        {
            var instance = new ConnectedInstitutionsDb();
            CreateTableResult result = await Database.CreateTableAsync<ConnectedInstitution>();
            return instance;
        });

        public ConnectedInstitutionsDb()
        {
            Database = new SQLiteAsyncConnection(Constants.DatabasePath, Constants.Flags);
        }

        public async Task<CreateTableResult> CreateTable()
        {
            var createTableResult = await Database.CreateTableAsync<ConnectedInstitution>();

            IsInitialised = createTableResult == CreateTableResult.Created;
            
            return createTableResult;
        }
        
        public Task<List<ConnectedInstitution>> GetInstitutionsAsync()
        {
            return Database.Table<ConnectedInstitution>().ToListAsync();
        }
        
        public Task<List<ConnectedInstitution>> GetInstitutionByInstitutionIdAsync(string institutionId)
        {
            // SQL queries are also possible
            return Database.QueryAsync<ConnectedInstitution>("SELECT * FROM [ConnectedInstitution] WHERE [InstitutionId] = institutionId");
        }

        public Task<ConnectedInstitution> GetInstitutionAsync(int id)
        {
            return Database.Table<ConnectedInstitution>().Where(i => i.Id == id).FirstOrDefaultAsync();
        }

        public Task<int> SaveInstitutionAsync(ConnectedInstitution institution)
        {
            if (institution.Id != 0)
            {
                return Database.UpdateAsync(institution);
            }
            else
            {
                return Database.InsertAsync(institution);
            }
        }

        public Task<int> DeleteInstitutionAsync(ConnectedInstitution institution)
        {
            return Database.DeleteAsync(institution);
        }
    }
}