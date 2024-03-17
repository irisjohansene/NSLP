using NSLPWebApi.Data;
using NSLPWebApi.Models;

namespace NSLPWebApi.Repositories
{
    public class MenuToIngredientRepository : Repository<MenuToIngredient>
    {
        private readonly AppDbContext _db;

        public MenuToIngredientRepository(AppDbContext db) : base(db)
        {
            _db = db;
        }
    }
}
