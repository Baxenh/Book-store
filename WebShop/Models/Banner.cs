using System.ComponentModel.DataAnnotations;

using System.ComponentModel.DataAnnotations.Schema;


namespace WebShop.Models
{
    [Table("Banners")]
    public class Banner
    {
        [Key]
        public int Id { get; set; }

        [StringLength(300)]
        public string? Image { get; set; }
        [Required]
        [StringLength(300)]
        public string? Name { get; set; }

        public string? SubTitle { get; set; }

        public string? Urls { get; set; }

        public int Orders { get; set; }

        public string? Type { get; set; }

        public DateTime? CreatedDate { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public string? AdminCreated { get; set; }

        public string? AdminUpdated { get; set; }

        public string? Notes { get; set; }

        public int Status { get; set; }

        public bool Isdelete { get; set; }

    }
}
