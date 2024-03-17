using System.ComponentModel.DataAnnotations.Schema;

namespace NSLPWebApi.Models
{
    public class Order
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime From { get; set; }
        public DateTime Till { get; set; }
        public bool Completed { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }
    }
}
