using NSLPWebApi.Data;
using NSLPWebApi.Models;

namespace NSLPWebApi.Repositories
{
    public class MenuRepository : Repository<Menu>
    {
        private readonly AppDbContext _db;

        public MenuRepository(AppDbContext db) : base(db)
        {
            _db = db;
        }
    }
}
