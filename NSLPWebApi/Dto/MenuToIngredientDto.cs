using NSLPWebApi.Models;

namespace NSLPWebApi.Dto
{
    public class MenuToIngredientDto
    {
        public int MenuToIngredientId { get; set; }
        public int MenuId { get; set; }
        public int IngredientId { get; set; }
    }
}
