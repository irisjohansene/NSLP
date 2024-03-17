using System.ComponentModel.DataAnnotations.Schema;

namespace NSLPWebApi.Models
{
    public class IngredientType
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
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
        public MenuType MenuType { get; set; }

        public Measurement? MPDMeasurement {  get; set; }
        public Measurement? MPWMeasurement {  get; set; }
        public Measurement? MXDMeasurement {  get; set; }
        public Measurement? MXWMeasurement {  get; set; }
    }
}
