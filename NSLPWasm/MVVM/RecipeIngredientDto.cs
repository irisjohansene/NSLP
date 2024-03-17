using NSLPWasm.Dto;

namespace NSLPWasm.MVVM
{
    public class RecipeIngredientDto
    {
        public int RecipeToIngredientId { get; set; }
        public int RecipeId { get; set; }
        public int IngredientId { get; set; }
        public int Quantity { get; set; }
        public int MeasurementId { get; set; }
        public IngredientDto Ingredient { get; set; } = new IngredientDto();
    }
}
