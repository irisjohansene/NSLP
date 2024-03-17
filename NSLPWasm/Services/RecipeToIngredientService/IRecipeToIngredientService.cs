using NSLPWasm.Dto;

namespace NSLPWasm.Services.RecipeToIngredientService
{
    public interface IRecipeToIngredientService
    {
        Task<RecipeToIngredientDto> AddRecipeToIngredient(RecipeToIngredientDto model);
        Task<List<RecipeToIngredientDto>> GetAllRecipeToIngredient();
        Task<List<RecipeToIngredientDto>> GetAllRecipeToIngredientByRecipeId(int recipeId);
        Task<RecipeToIngredientDto> RemoveRecipeToIngredient(RecipeToIngredientDto model);
        Task<RecipeToIngredientDto> UpdateRecipeToIngredient(RecipeToIngredientDto model);
    }
}