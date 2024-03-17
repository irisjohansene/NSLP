namespace NSLPWasm.Dto
{
    public class RecipeDto
    {
        public int RecipeId { get; set; }
        public string RecipeName { get; set; }
        public bool Hot { get; set; }
        public bool Cold { get; set; }
        public int ProductCategoryId { get; set; }
        public List<RecipeToIngredientDto> RecipeToIngredients { get; set; }
    }
}
