using System.ComponentModel.DataAnnotations.Schema;

namespace NSLPWebApi.Models
{
    public class OrderDetail
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrderDetailId { get; set; }
        public double Amount { get; set; }
        public bool Ordered { get; set; }

        public int OrderId { get; set; }
        public int VendorId { get; set; }
        public int IngredientId { get; set; }
        public int MeasurementId { get; set; }
        public Order Order { get; set; }
        public Vendor Vendor { get; set; }
        public Ingredient Ingredient { get; set; }
        public Measurement Measurement { get; set; }
    }
}
