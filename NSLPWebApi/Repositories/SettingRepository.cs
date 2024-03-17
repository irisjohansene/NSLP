using NSLPWebApi.Data;
using NSLPWebApi.Models;

namespace NSLPWebApi.Repositories
{
    public class SettingRepository : Repository<Setting>
    {
        private readonly AppDbContext _db;

        public SettingRepository(AppDbContext db) : base(db)
        {
            _db = db;
        }
    }
}
