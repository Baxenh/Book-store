using System.ComponentModel.DataAnnotations;

using System.ComponentModel.DataAnnotations.Schema;

namespace WebShop.Models
{
    [Table("Colors")]
    public class Color
    {
        [Key]
        public int ColorId { get; set; }
        [StringLength(10)]
        public string? ColorName { get; set; }

    }
}
