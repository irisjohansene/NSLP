using NSLPWasm.Dto;

namespace NSLPWasm.Services.MenuToIngredientService
{
    public interface IMenuToIngredientOrRecipeService
    {
        Task<IEnumerable<MenuToIngredientOrRecipeDto>> AddMenuToIngredientOrRecipe(IEnumerable<MenuToIngredientOrRecipeDto> model);
        Task<MenuToIngredientOrRecipeDto> AddOneMenuToIngredientOrRecipe(MenuToIngredientOrRecipeDto model);
        Task<List<MenuToIngredientOrRecipeDto>> GetAllDataByDateAndId(DateTime dateTime, int menutypeid);
        Task<List<MenuToIngredientOrRecipeDto>> GetAllMenuToIngredientOrRecipe();
        Task<MenuToIngredientOrRecipeDto> RemoveMenuToIngredientOrRecipe(MenuToIngredientOrRecipeDto model);
        Task<MenuToIngredientOrRecipeDto> UpdateMenuToIngredientOrRecipe(MenuToIngredientOrRecipeDto model);
    }
}