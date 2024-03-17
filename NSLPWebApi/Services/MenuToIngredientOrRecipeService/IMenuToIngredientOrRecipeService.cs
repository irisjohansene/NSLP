using NSLPWebApi.Models;

namespace NSLPWebApi.Services.MenuToIngredientService
{
    public interface IMenuToIngredientOrRecipeService
    {
        Task AddMenuToIngredientOrRecipeAsync(IEnumerable<MenuToIngredientOrRecipe> mti);
        Task AddOneMenuToIngredientOrRecipeAsync(MenuToIngredientOrRecipe mti);
        Task<List<MenuToIngredientOrRecipe>> GetAllDataByDateAndIdAsync(DateTime dateTime, int menuTypeId);
        Task<List<MenuToIngredientOrRecipe>> GetAllMenuToIngredientOrRecipeAsync();
        Task RemoveMenuToIngredientOrRecipeAsync(MenuToIngredientOrRecipe mti);
        Task UpdateMenuToIngredientOrRecipeAsync(MenuToIngredientOrRecipe mti);
    }
}