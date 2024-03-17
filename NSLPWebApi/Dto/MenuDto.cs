using NSLPWebApi.Models;

namespace NSLPWebApi.Dto
{
    public class MenuDto
    {
        public int MenuId { get; set; }
        public DateTime MenuDate { get; set; }
        public int MenuTypeId { get; set; }
        public List<MenuToIngredientOrRecipeDto> MenuToIngredientOrRecipes { get; set; }
    }
}
