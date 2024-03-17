using System.ComponentModel.DataAnnotations.Schema;

namespace NSLPWebApi.Models
{
    public class MenuType
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MenuTypeId { get; set; }
        public string MenuTypeName { get; set; }
    }
}
