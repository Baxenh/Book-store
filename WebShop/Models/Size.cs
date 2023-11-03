using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebShop.Models
{
    [Table("Sezis")]
    public class Size
    {
        [Key]
        public int SizeId { get; set; }
        [StringLength(10)]
        public string? SizeName { get; set; }

    }
}
