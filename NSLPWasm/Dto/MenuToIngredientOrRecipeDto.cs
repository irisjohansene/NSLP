namespace NSLPWasm.Dto
{
    public class MenuToIngredientOrRecipeDto
    {
        public int MenuToIngredientOrRecipeId { get; set; }
        public double QuantityOffered { get; set; }
        public double QtyMeasurement { get; set; }
        public double QtyServed { get; set; }
        public double Leftovers { get; set; }
        public string Temperature { get; set; }
        public int Attendance { get; set; }
        public int? IngredientId { get; set; }
        public int? RecipeId { get; set; }
        public int MeasurementId { get; set; }
        public int MenuId { get; set; }
    }
}
