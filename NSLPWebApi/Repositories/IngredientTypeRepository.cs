using NSLPWebApi.Data;
using NSLPWebApi.Models;

namespace NSLPWebApi.Repositories
{
    public class IngredientTypeRepository : Repository<IngredientType>
    {
        private readonly AppDbContext _db;

        public IngredientTypeRepository(AppDbContext db) : base(db)
        {
            _db = db;
        }
    }
}
