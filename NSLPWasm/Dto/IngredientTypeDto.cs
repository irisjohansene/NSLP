namespace NSLPWasm.Dto
{
    public class IngredientTypeDto
    {
        public int IngredientTypeId { get; set; }
        public string IngredientTypeName { get; set; }
        public double MinPerDay { get; set; }
        public int MPDM { get; set; }
        public double MinPerWeek { get; set; }
        public int MPWM { get; set; }
        public double MaxPerDay { get; set; }
        public int MXDM { get; set; }
        public double MaxPerWeek { get; set; }
        public int MXWM { get; set; }
        public string StudentAge { get; set; }
        public int MenuTypeId { get; set; }
    }
}
