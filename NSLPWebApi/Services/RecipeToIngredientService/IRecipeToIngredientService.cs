using NSLPWebApi.Models;

namespace NSLPWebApi.Services.RecipeToIngredientService
{
    public interface IRecipeToIngredientService
    {
        Task AddRecipeToIngredientAsync(RecipeToIngredient ingredient);
        Task<List<RecipeToIngredient>> GetAllRecipeToIngredientAsync();
        Task<List<RecipeToIngredient>> GetAllRecipeToIngredientByRecipeIdAsync(int recipeId);
        Task RemoveRecipeToIngredientAsync(RecipeToIngredient ingredient);
        Task UpdateRecipeToIngredientAsync(RecipeToIngredient ingredient);
    }
}