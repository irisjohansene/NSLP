using NSLPWebApi.Data;
using NSLPWebApi.Models;
using NSLPWebApi.Repositories;

namespace NSLPWebApi.Services.ProductCategoryService
{
    public class ProductCategoryService : IProductCategoryService
    {
        private readonly ProductCategoryRepository _repo;
        private readonly AppDbContext _db;
        public ProductCategoryService(ProductCategoryRepository repo, AppDbContext db)
        {
            _db = db;
            _repo = repo;
        }

        public async Task<List<ProductCategory>> GetAllProductCategoryAsync()
        {
            var pcs = await _repo.GetAllAsListAsync();
            return pcs;
        }

        public async Task AddProductCategoryAsync(ProductCategory pc)
        {
            await _repo.AddAsync(pc);
            await _repo.CompleteAsync();
            await _db.SaveChangesAsync();
        }

        public async Task UpdateProductCategoryAsync(ProductCategory pc)
        {
            _db.ProductCategories.Update(pc);
            await _db.SaveChangesAsync();
        }

        public async Task RemoveProductCategoryAsync(ProductCategory pc)
        {
            _db.ProductCategories.Remove(pc);
            await _db.SaveChangesAsync();
        }
    }
}
