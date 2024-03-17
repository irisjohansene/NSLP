using NSLPWebApi.Dto;
using NSLPWebApi.Models;

namespace NSLPWebApi.Services.RecipeService
{
    public interface IRecipeService
    {
        Task<int?> AddRecipeAsync(Recipe recipe);
        Task<List<Recipe>> GetAllRecipeAsync();
        Task<Recipe> GetRecipeByRecipeIdAsync(int recipeId);
        Task RemoveRecipeAsync(Recipe recipe);
        Task UpdateRecipeAsync(Recipe recipe);
    }
}