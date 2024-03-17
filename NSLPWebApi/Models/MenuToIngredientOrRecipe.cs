using System.ComponentModel.DataAnnotations.Schema;

namespace NSLPWebApi.Models
{
    public class MenuToIngredientOrRecipe
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MenuToIngredientOrRecipeId { get; set; }
        public double QuantityOffered { get; set; }
        public double QtyMeasurement { get; set; }
        public double QtyServed { get; set; }
        public string Leftovers { get; set; }
        public string Temperature { get; set; }
        public int Attendance { get; set; }
        public int? IngredientId { get; set; }
        public int? RecipeId { get; set; }
        public int MeasurementId { get; set; }
        public int MenuId { get; set; }
        public Ingredient Ingredient { get; set; }
        public Recipe Recipe { get; set; }
        public Measurement Measurement { get; set; }
        public Menu Menu { get; set; }
    }
}
