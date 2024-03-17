using NSLPWebApi.Data;
using NSLPWebApi.Models;

namespace NSLPWebApi.Repositories
{
    public class MenuToIngredientOrRecipeRepository : Repository<MenuToIngredientOrRecipe>
    {
        private readonly AppDbContext _db;

        public MenuToIngredientOrRecipeRepository(AppDbContext db) : base(db)
        {
            _db = db;
        }
    }
}
