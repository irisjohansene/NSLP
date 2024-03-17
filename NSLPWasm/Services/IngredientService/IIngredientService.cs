using NSLPWasm.Dto;
using NSLPWasm.DTO;

namespace NSLPWasm.Services.IngredientService.IngredientService
{
    public interface IIngredientService
    {
        Task<IngredientDto> AddIngredient(IngredientDto model);
        Task<List<IngredientDto>> GetAllIngredient();
        Task<IngredientDto> RemoveIngredient(IngredientDto model);
        Task<IngredientDto> UpdateIngredient(IngredientDto model);
    }
}