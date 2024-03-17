using NSLPWebApi.Models;

namespace NSLPWebApi.Services.IngredientService
{
    public interface IIngredientService
    {
        Task AddIngredientAsync(Ingredient ingredient);
        Task<List<Ingredient>> GetAllIngredientAsync();
        Task RemoveIngredientAsync(Ingredient ingredient);
        Task UpdateIngredientAsync(Ingredient ingredient);
    }
}