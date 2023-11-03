using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebShop.Models
{
    public class User
    {
        [Table("Contacts")]
        public class Contact
        {
            [Key]
            public int Id { get; set; }
            [Required]
            [StringLength(300)]

            public string? FullName { get; set; }
            [Required]
            public string? Email { get; set; }
            [Required]
            public string Phone { get; set; }
            [Required]
            public string Address { get; set; }
            [Required]
            public string User { get; set; }
            [Required]
            public string Password { get; set; }
            [Required]
            public string Roles { get; set; }
            public DateTime? CreatedDate { get; set; }

            public DateTime? UpdatedDate { get; set; }

            public string? AdminCreated { get; set; }

            public string? AdminUpdated { get; set; }

            public int Status { get; set; }

            public bool? Isdelete { get; set; }


        }
    }
}
