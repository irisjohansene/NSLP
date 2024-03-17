using AutoMapper;
using Microsoft.EntityFrameworkCore;
using NSLPWebApi.Data;
using NSLPWebApi.Dto;
using NSLPWebApi.Models;
using NSLPWebApi.Repositories;

namespace NSLPWebApi.Services.RecipeService
{
    public class RecipeService : IRecipeService
    {
        private readonly RecipeRepository _repo;
        private readonly AppDbContext _db;
        private readonly IMapper _mapper;
        public RecipeService(RecipeRepository repo, AppDbContext db, IMapper mapper)
        {
            _db = db;
            _repo = repo;
            _mapper = mapper;
        }

        public async Task<List<Recipe>> GetAllRecipeAsync()
        {
            var recipes = await _repo.GetAllAsListAsync();
            return recipes;
        }

        public async Task<Recipe> GetRecipeByRecipeIdAsync(int recipeId)
        {
            var recipe = await _repo.GetAsync(x => x.RecipeId == recipeId);
            await _db.RecipeToIngredients.Where(x => x.RecipeId == recipe.RecipeId).LoadAsync();
            return recipe;
        }

        public async Task<int?> AddRecipeAsync(Recipe recipe)
        {
            try
            {
                await _repo.AddAsync(recipe);
                await _repo.CompleteAsync();
                await _db.SaveChangesAsync();

                // Return the RecipeId after it's been generated
                return recipe.RecipeId;
            }
            catch (Exception ex)
            {
                // Handle any exceptions that occur during the operation
                Console.WriteLine($"An error occurred: {ex.Message}");
                return null;
            }
        }



        public async Task UpdateRecipeAsync(Recipe recipe)
        {
            _db.Recipes.Update(recipe);
            await _db.SaveChangesAsync();
        }

        public async Task RemoveRecipeAsync(Recipe recipe)
        {
            _db.Recipes.Remove(recipe);
            await _db.SaveChangesAsync();
        }
    }
}
