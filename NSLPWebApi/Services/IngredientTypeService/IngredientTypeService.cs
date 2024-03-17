using NSLPWebApi.Data;
using NSLPWebApi.Models;
using NSLPWebApi.Repositories;

namespace NSLPWebApi.Services.IngredientTypeService
{
    public class IngredientTypeService : IIngredientTypeService
    {
        private readonly IngredientTypeRepository _repo;
        private readonly AppDbContext _db;
        public IngredientTypeService(IngredientTypeRepository repo, AppDbContext db)
        {
            _db = db;
            _repo = repo;
        }

        public async Task<List<IngredientType>> GetAllIngredientTypeAsync()
        {
            var ingredients = await _repo.GetAllAsListAsync();
            return ingredients;
        }

        public async Task AddIngredientTypeAsync(IngredientType ingredient)
        {
            await _repo.AddAsync(ingredient);
            await _repo.CompleteAsync();
            await _db.SaveChangesAsync();
        }

        public async Task UpdateIngredientTypeAsync(IngredientType ingredient)
        {
            _db.IngredientTypes.Update(ingredient);
            await _db.SaveChangesAsync();
        }

        public async Task RemoveIngredientTypeAsync(IngredientType ingredient)
        {
            _db.IngredientTypes.Remove(ingredient);
            await _db.SaveChangesAsync();
        }
    }
}
