using Blazored.LocalStorage;
using NSLPWasm.Dto;
using NSLPWasm.MVVM;

namespace NSLPWasm.Helpers
{
    public class LocalStorageManager : ILocalStorageManager
    {
        private readonly ILocalStorageService _localStorage;

        public LocalStorageManager(ILocalStorageService localStorage)
        {
            _localStorage = localStorage;
        }

        public void SaveIngredientTypesToLocalStorage(IEnumerable<IngredientTypeDto> ingredientTypes)
        {
            _localStorage.SetItemAsync("IngredientTypes", ingredientTypes);
        }

        public void SaveMeasurementsToLocalStorage(IEnumerable<MeasurementDto> measurements)
        {
            _localStorage.SetItemAsync("Measurements", measurements);
        }

        public void SaveMenuTypesToLocalStorage(IEnumerable<MenuTypeDto> menuTypes)
        {
            _localStorage.SetItemAsync("MenuTypes", menuTypes);
        }

        public void SaveProductCategoriesToLocalStorage(IEnumerable<ProductCategoryDto> productCategories)
        {
            _localStorage.SetItemAsync("ProductCategories", productCategories);
        }

        public async Task<IEnumerable<IngredientTypeDto>> GetAllIngredientTypesFromLocalStorage()
        {
            IEnumerable<IngredientTypeDto> ingredientTypes = await _localStorage.GetItemAsync<IEnumerable<IngredientTypeDto>>("IngredientTypes");
            return ingredientTypes;
        }

        public async Task<IEnumerable<MeasurementDto>> GetAllMeasurementsFromLocalStorage()
        {
            IEnumerable<MeasurementDto> measurements = await _localStorage.GetItemAsync<IEnumerable<MeasurementDto>>("Measurements");
            return measurements;
        }

        public async Task<IEnumerable<MenuTypeDto>> GetAllMenuTypesFromLocalStorage()
        {
            IEnumerable<MenuTypeDto> menuTypes = await _localStorage.GetItemAsync<IEnumerable<MenuTypeDto>>("MenuType");
            return menuTypes;
        }

        public async Task<IEnumerable<ProductCategoryDto>> GetAllProductCategoriesFromLocalStorage()
        {
            IEnumerable<ProductCategoryDto> productCategories = await _localStorage.GetItemAsync<IEnumerable<ProductCategoryDto>>("ProductCategories");
            return productCategories;
        }
    }
}
