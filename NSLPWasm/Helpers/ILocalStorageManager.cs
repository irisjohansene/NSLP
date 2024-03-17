using NSLPWasm.Dto;

namespace NSLPWasm.Helpers
{
    public interface ILocalStorageManager
    {
        Task<IEnumerable<IngredientTypeDto>> GetAllIngredientTypesFromLocalStorage();
        Task<IEnumerable<MeasurementDto>> GetAllMeasurementsFromLocalStorage();
        Task<IEnumerable<MenuTypeDto>> GetAllMenuTypesFromLocalStorage();
        Task<IEnumerable<ProductCategoryDto>> GetAllProductCategoriesFromLocalStorage();
        void SaveIngredientTypesToLocalStorage(IEnumerable<IngredientTypeDto> ingredientTypes);
        void SaveMeasurementsToLocalStorage(IEnumerable<MeasurementDto> measurements);
        void SaveMenuTypesToLocalStorage(IEnumerable<MenuTypeDto> menuTypes);
        void SaveProductCategoriesToLocalStorage(IEnumerable<ProductCategoryDto> productCategories);
    }
}