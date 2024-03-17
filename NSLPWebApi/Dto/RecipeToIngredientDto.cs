using NSLPWebApi.Models;

namespace NSLPWebApi.Dto
{
    public class RecipeToIngredientDto
    {
        public int RecipeToIngredientId { get; set; }
        public int Quantity { get; set; }
        public int IngredientId { get; set; }
        public int RecipeId { get; set; }
        public int MeasurementId { get; set; }

    }
}
