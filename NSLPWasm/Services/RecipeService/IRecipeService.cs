using NSLPWasm.Dto;

namespace NSLPWasm.Services.RecipeService
{
    public interface IRecipeService
    {
        Task<int?> AddRecipe(RecipeDto model);
        Task<List<RecipeDto>> GetAllRecipe();
        Task<RecipeDto> GetRecipeByRecipeId(int recipeId);
        Task<RecipeDto> RemoveRecipe(RecipeDto model);
        Task<RecipeDto> UpdateRecipe(RecipeDto model);
    }
}