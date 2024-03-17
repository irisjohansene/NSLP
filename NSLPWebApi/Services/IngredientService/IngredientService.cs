using Microsoft.EntityFrameworkCore;
using NSLPWebApi.Data;
using NSLPWebApi.Models;
using NSLPWebApi.Repositories;

namespace NSLPWebApi.Services.IngredientService
{
    public class IngredientService : IIngredientService
    {
        private readonly IngredientRepository _repo;
        private readonly AppDbContext _db;
        public IngredientService(IngredientRepository repo, AppDbContext db)
        {
            _db = db;
            _repo = repo;
        }

        public async Task<List<Ingredient>> GetAllIngredientAsync()
        {
            var ingredients = await _repo.GetAllAsListAsync();
            return ingredients;
        }

        public async Task AddIngredientAsync(Ingredient ingredient)
        {
            try
            {
                await _repo.AddAsync(ingredient);
                await _repo.CompleteAsync();
                await _db.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                // Log or print the details of the inner exception
                var innerException = ex.InnerException;
                while (innerException != null)
                {
                    // Log or print inner exception details
                    innerException = innerException.InnerException;
                }

                throw; // Re-throw the exception after logging details
            }
        }

        public async Task UpdateIngredientAsync(Ingredient ingredient)
        {
            _db.Ingredients.Update(ingredient);
            await _db.SaveChangesAsync();
        }

        public async Task RemoveIngredientAsync(Ingredient ingredient)
        {
            _db.Ingredients.Remove(ingredient);
            await _db.SaveChangesAsync();
        }
    }
}
