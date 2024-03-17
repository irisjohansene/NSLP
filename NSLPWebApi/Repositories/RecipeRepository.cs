using NSLPWebApi.Data;
using NSLPWebApi.Models;

namespace NSLPWebApi.Repositories
{
    public class RecipeRepository : Repository<Recipe>
    {
        private readonly AppDbContext _db;

        public RecipeRepository(AppDbContext db) : base(db)
        {
            _db = db;
        }
    }
}
