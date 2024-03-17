using NSLPWebApi.Models;

namespace NSLPWebApi.Dto
{
    public class PredefinedTableDto
    {
        public IEnumerable<IngredientType> IngredientTypes { get; set;}
        public IEnumerable<Measurement> Measurements { get; set;}
        public IEnumerable<MenuType> MenuTypes { get; set;}
        public IEnumerable<ProductCategory> ProductCategories { get; set;}
    }
}
