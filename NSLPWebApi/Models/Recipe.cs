using System.ComponentModel.DataAnnotations.Schema;

namespace NSLPWebApi.Models
{
    public class Recipe
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RecipeId { get; set; }
        public string RecipeName { get; set; }
        public bool Hot { get; set; }
        public bool Cold { get; set; }
        public int ProductCategoryId { get; set; }
        public ProductCategory ProductCategory { get; set; }
        public List<RecipeToIngredient> RecipeToIngredients { get; set; }
    }
}
