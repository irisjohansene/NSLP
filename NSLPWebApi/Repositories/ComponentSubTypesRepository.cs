using NSLPWebApi.Data;
using NSLPWebApi.Models;

namespace NSLPWebApi.Repositories
{
    public class ComponentSubTypesRepository : Repository<ComponentSubType>
    {
        private readonly AppDbContext _db;

        public ComponentSubTypesRepository(AppDbContext db) : base(db)
        {
            _db = db;
        }
    }
}
