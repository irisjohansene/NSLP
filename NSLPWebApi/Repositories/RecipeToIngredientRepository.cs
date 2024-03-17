using NSLPWebApi.Data;
using NSLPWebApi.Models;

namespace NSLPWebApi.Repositories
{
    public class RecipeToIngredientRepository : Repository<RecipeToIngredient>
    {
        private readonly AppDbContext _db;

        public RecipeToIngredientRepository(AppDbContext db) : base(db)
        {
            _db = db;
        }
    }
}
