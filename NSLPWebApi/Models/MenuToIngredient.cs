namespace NSLPWebApi.Models
{
    public class MenuToIngredient
    {
        public int MenuToIngredientId { get; set; }
        public int MenuId { get; set; }
        public Menu Menu { get; set; }
        public int IngredientId { get; set; }
        public Ingredient Ingredient { get; set; }
    }
}
