namespace NSLPWasm.Dto
{
    public class IngredientDto
    {
        public int IngredientId { get; set; }
        public string Name { get; set; }
        public double AmountPerServing { get; set; }
        public int APSM { get; set; }
        public double AmountPerUnit { get; set; }
        public int APUM { get; set; }
        public double AmountPerBulkUnit { get; set; }
        public int APBM { get; set; }
        public double Sodiummg { get; set; }
        public bool MadeInUSA { get; set; }
        public bool Hot { get; set; }
        public bool Cold { get; set; }

        public int ProductCategoryId { get; set; }
        public int IngredientTypeId { get; set; }
    }
}
