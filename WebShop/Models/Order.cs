using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebShop.Models
{
    [Table("Orders")]
    public class Order
    {
        [Key]
        public int Id { get; set; }
         public int CustomerId { get; set; }
        [Required]
        [StringLength(300)]
        public string Name { get; set; } = null!;

        public string Email { get; set; } = null!;

        public string Address { get; set; } = null!;

        public DateTime CreatedDate { get; set; }

        public int Status { get; set; }

    }
}
