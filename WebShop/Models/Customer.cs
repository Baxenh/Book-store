using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebShop.Models
{
    [Table("Cutomers")]
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Customer")]
        public int CustomerId { get; set; }
        public Customer? Customers { get; set; }


        [StringLength(300)]
        public string FullName { get; set; } = null!;
        [Required]
        public string Email { get; set; } = null!;

        public string Phone { get; set; } = null!;
        [Required]
        public string Address { get; set; } = null!;
        [Required]
        public string Avatar { get; set; } = null!;

        public DateTime Birthday { get; set; }
        [Required]
        public string Gender { get; set; } = null!;
        [Required]
        public string Password { get; set; } = null!;

        public string Facebook { get; set; } = null!;

    }
}
