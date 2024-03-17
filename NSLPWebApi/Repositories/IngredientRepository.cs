using NSLPWebApi.Data;
using NSLPWebApi.Models;

namespace NSLPWebApi.Repositories
{
    public class IngredientRepository : Repository<Ingredient>
    {
        private readonly AppDbContext _db;

        public IngredientRepository(AppDbContext db) : base(db)
        {
            _db = db;
        }
    }
}
