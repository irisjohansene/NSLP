using NSLPWasm.Dto;

namespace NSLPWasm.MVVM
{
    public class PredefinedTableDto
    {
        public IEnumerable<IngredientTypeDto> IngredientTypes { get; set;}
        public IEnumerable<MeasurementDto> Measurements { get; set;}
        public IEnumerable<MenuTypeDto> MenuTypes { get; set;}
        public IEnumerable<ProductCategoryDto> ProductCategories { get; set; }
    }
}
