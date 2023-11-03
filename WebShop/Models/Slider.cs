using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebShop.Models
{
    [Table("Sliders")]
    public class Slider
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(300)]
        public string? Name { get; set; }
        [Required]
        public string? SubTitle { get; set; }
        [Required]
        public string? Urls { get; set; }
        [Required]
        public string? Image { get; set; }
        [Required]
        public int Orders { get; set; }

        public DateTime? CreatedDate { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public string? AdminCreated { get; set; }

        public string? AdminUpdated { get; set; }

        public string? Notes { get; set; }

        public int Status { get; set; }

        public bool Isdelete { get; set; }

    }
}
