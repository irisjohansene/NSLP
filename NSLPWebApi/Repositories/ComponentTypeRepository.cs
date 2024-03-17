using NSLPWebApi.Data;
using NSLPWebApi.Models;

namespace NSLPWebApi.Repositories
{
    public class ComponentTypeRepository : Repository<ComponentType>
    {
        private readonly AppDbContext _db;

        public ComponentTypeRepository(AppDbContext db) : base(db)
        {
            _db = db;
        }
    }
}
