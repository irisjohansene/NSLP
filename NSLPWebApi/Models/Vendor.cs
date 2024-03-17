using System.ComponentModel.DataAnnotations.Schema;

namespace NSLPWebApi.Models
{
    public class Vendor
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int VendorId { get; set; }
        public string VendorName { get; set; }
        public string Tel { get; set; }
        public string Email { get; set; }
    }
}
