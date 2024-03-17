using System.ComponentModel.DataAnnotations.Schema;

namespace NSLPWebApi.Models
{
    public class Measurement
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MeasurementId { get; set; }
        public string MeasurementName { get; set; }
    }
}
