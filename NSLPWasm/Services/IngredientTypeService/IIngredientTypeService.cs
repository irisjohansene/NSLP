using NSLPWasm.Dto;

namespace NSLPWasm.Services.IngredientTypeService
{
    public interface IIngredientTypeService
    {
        Task<IngredientTypeDto> AddIngredientType(IngredientTypeDto model);
        Task<List<IngredientTypeDto>> GetAllIngredientType();
        Task<IngredientTypeDto> RemoveIngredientType(IngredientTypeDto model);
        Task<IngredientTypeDto> UpdateIngredientType(IngredientTypeDto model);
    }
}