using System.ComponentModel.DataAnnotations.Schema;

namespace NSLPWebApi.Models
{
    public class Menu
    {
        public int MenuId { get; set; }
        public DateTime MenuDate { get; set; }
        public int MenuTypeId {  get; set; }
        public MenuType? MenuType {  get; set; }
        public List<MenuToIngredientOrRecipe> MenuToIngredientOrRecipes { get; set; }
    }
}
