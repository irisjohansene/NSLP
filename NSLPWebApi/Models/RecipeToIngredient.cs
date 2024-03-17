using System.ComponentModel.DataAnnotations.Schema;

namespace NSLPWebApi.Models
{
    public class RecipeToIngredient
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RecipeToIngredientId { get; set; }
        public int Quantity { get; set; }
        public int IngredientId { get; set; }
        public int RecipeId { get; set; }
        public int MeasurementId { get; set; }
        
        public Ingredient Ingredient { get; set; }
        public Recipe Recipe { get; set; }
        public Measurement Measurement { get; set; }
    }
}
