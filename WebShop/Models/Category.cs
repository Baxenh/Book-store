using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebShop.Models
{
    [Table("Categories")]
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        [Required]
        [StringLength(300)]
        [Display(Name ="Tên Danh mục")]
        public string? CategoryName { get; set; }
        [StringLength(300)]
        [Display(Name = "Ảnh")]
        public string? Image { get; set; }
        public string? Icon { get; set; }

        public string? MateName { get; set; }

        public string? MetaKeyword { get; set; }

        public string? MetaDescription { get; set; }

        public string? Slug { get; set; }

        public int? Orders { get; set; }

        public int? Parentid { get; set; }

        public DateTime? CreateDate { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public string? AdminCreated { get; set; }

        public string? AdminUpdated { get; set; }

        public string? Notes { get; set; }

        public int Status { get; set; }

        public bool? Isdelete { get; set; }


    }
}
