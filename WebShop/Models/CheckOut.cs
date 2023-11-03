using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebShop.Models
{
    [Table("CheckOuts")]
    public class CheckOut
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Customer")]
        public int CustomerId { get; set; }
        public Customer? Customers { get; set; }


        [Required]
        [StringLength(300)]
        public string Content { get; set; } = null!;
        [Required]
        [EmailAddress()]
        public string Email { get; set; } = null!;

        public string Address { get; set; } = null!;
        [Required]
        public string? PhoneNumber { get; set; }

        public string? ZipCode { get; set; }

        public DateTime CreatedDate { get; set; }

        public int Status { get; set; }

    }
}
