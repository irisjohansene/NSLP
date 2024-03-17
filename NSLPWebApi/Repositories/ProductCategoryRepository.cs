using NSLPWebApi.Data;
using NSLPWebApi.Models;

namespace NSLPWebApi.Repositories
{
    public class ProductCategoryRepository : Repository<ProductCategory>
    {
        private readonly AppDbContext _db;

        public ProductCategoryRepository(AppDbContext db) : base(db)
        {
            _db = db;
        }
    }
}
