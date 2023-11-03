using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebShop.Models
{
    [Table("News")]
    public class New
    {
        [Key]
        public int Id { get; set; }

        public string? Code { get; set; }
        [Required]
        [StringLength(300)]
        public string? Name { get; set; }

        [StringLength(3000)]
        public string? Description { get; set; }

        public string? Content { get; set; }
        [Required]
        [StringLength(300)]
        public string? Image { get; set; }

        public string? MetaTitle { get; set; }

        public string? MainKeyword { get; set; }

        public string? MetaKeyword { get; set; }

        public string? MetaDescription { get; set; }

        public string? Slug { get; set; }

        public int? Views { get; set; }

        public int? Likes { get; set; }

        public double? Star { get; set; }

        public DateTime? CreatedDate { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public string? AdminCreated { get; set; }

        public string? AdminUpdated { get; set; }

        public int Status { get; set; }

        public bool? Isdelete { get; set; }
        [ForeignKey("Share")]
        public int? ShareId { get; set; }
        public Share? Shares { get; set; }

    }
}
