using System.ComponentModel.DataAnnotations.Schema;

namespace NSLPWebApi.Models
{
    public class Document
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DocumentId { get; set; }
        public string DocumentName { get; set; }
        public string Description { get; set; }
        public bool IsRequired { get; set; }
    }
}
