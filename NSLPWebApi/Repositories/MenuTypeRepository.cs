using NSLPWebApi.Data;
using NSLPWebApi.Models;

namespace NSLPWebApi.Repositories
{
    public class MenuTypeRepository : Repository<MenuType>
    {
        private readonly AppDbContext _db;

        public MenuTypeRepository(AppDbContext db) : base(db)
        {
            _db = db;
        }
    }
}
