using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebShop.Models
{
    [Table("Shares")]
    public class Share
    {
        [Key]
        public int ShareId { get; set; }
        [StringLength(100)]
        public string? ShareName { get; set; }
    }
}
