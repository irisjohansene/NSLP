using NSLPWebApi.Models;

namespace NSLPWebApi.Services.IngredientTypeService
{
    public interface IIngredientTypeService
    {
        Task AddIngredientTypeAsync(IngredientType ingredient);
        Task<List<IngredientType>> GetAllIngredientTypeAsync();
        Task RemoveIngredientTypeAsync(IngredientType ingredient);
        Task UpdateIngredientTypeAsync(IngredientType ingredient);
    }
}