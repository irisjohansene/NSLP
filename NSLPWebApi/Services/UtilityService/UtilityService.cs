using NSLPWebApi.Data;
using NSLPWebApi.Dto;
using NSLPWebApi.Repositories;

namespace NSLPWebApi.Services.UtilityService
{
    public class UtilityService : IUtilityService
    {
        private readonly AppDbContext _db;
        private readonly IngredientTypeRepository _itrepo;
        private readonly MeasurementRepository _measurementrepo;
        private readonly MenuTypeRepository _menutyperepo;
        private readonly ProductCategoryRepository _productcategoryrepo;

        public UtilityService(AppDbContext db, IngredientTypeRepository itrepo, MeasurementRepository measurementrepo, MenuTypeRepository menutyperepo, ProductCategoryRepository productcategoryrepo)
        {
            _db = db;
            _itrepo = itrepo;
            _measurementrepo = measurementrepo;
            _menutyperepo = menutyperepo;
            _productcategoryrepo = productcategoryrepo;
        }

        public async Task<PredefinedTableDto> GetAllPredefinedTable()
        {
            var data = new PredefinedTableDto();
            var ingredientTypes = await _itrepo.GetAllAsListAsync();
            var measurements = await _measurementrepo.GetAllAsListAsync();
            var menuTypes = await _menutyperepo.GetAllAsListAsync();
            var productCategories = await _productcategoryrepo.GetAllAsListAsync();

            data.IngredientTypes = ingredientTypes;
            data.Measurements = measurements;
            data.MenuTypes = menuTypes;
            data.ProductCategories = productCategories;

            return data;
        }
    }
}
