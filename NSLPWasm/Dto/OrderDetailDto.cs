namespace NSLPWasm.Dto
{
    public class OrderDetailDto
    {
        public int OrderDetailId { get; set; }
        public double Amount { get; set; }
        public bool Ordered { get; set; }

        public int OrderId { get; set; }
        public int VendorId { get; set; }
        public int IngredientId { get; set; }
        public int MeasurementId { get; set; }
    }
}
