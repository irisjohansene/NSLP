using Microsoft.EntityFrameworkCore;
using NSLPWebApi.Data;
using NSLPWebApi.Models;
using NSLPWebApi.Repositories;

namespace NSLPWebApi.Services.RecipeToIngredientService
{
    public class RecipeToIngredientService : IRecipeToIngredientService
    {
        private readonly RecipeToIngredientRepository _repo;
        private readonly AppDbContext _db;
        public RecipeToIngredientService(RecipeToIngredientRepository repo, AppDbContext db)
        {
            _db = db;
            _repo = repo;
        }

        public async Task<List<RecipeToIngredient>> GetAllRecipeToIngredientAsync()
        {
            var ingredients = await _repo.GetAllAsListAsync();
            return ingredients;
        }

        public async Task AddRecipeToIngredientAsync(RecipeToIngredient ingredient)
        {
            await _repo.AddAsync(ingredient);
            await _repo.CompleteAsync();
            await _db.SaveChangesAsync();
        }

        public async Task UpdateRecipeToIngredientAsync(RecipeToIngredient ingredient)
        {
            _db.RecipeToIngredients.Update(ingredient);
            await _db.SaveChangesAsync();
        }

        public async Task RemoveRecipeToIngredientAsync(RecipeToIngredient ingredient)
        {
            _db.RecipeToIngredients.Remove(ingredient);
            await _db.SaveChangesAsync();
        }

        public async Task<List<RecipeToIngredient>> GetAllRecipeToIngredientByRecipeIdAsync(int recipeId)
        {
            var rtiList = await _db.RecipeToIngredients.Where(x => x.RecipeId == recipeId).ToListAsync();
            //var ingredients = await _repo.GetAllAsListAsync();
            return rtiList;
        }
    }
}
