using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebShop.Models
{
    [Table("Products")]
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Category")]
        public int? CategoryId { get; set; }
        public Category? Category { get; set; }
        public string? Code { get; set; }

        [Required]
        [StringLength(300)]
        public string Name { get; set; }
        [StringLength(3000)]
        public string? Description { get; set; }
        [StringLength(3000)]
        public string? Content { get; set; }
        [StringLength(300)]
        [Display(Name = "Ảnh đại diện")]
        public string? Image { get; set; }

        public string? MetaTitle { get; set; }

        public string? MetaKeyword { get; set; }

        public string? MetaDescription { get; set; }

        public string? Slug { get; set; }
        [Display(Name = "Giá mới")]
        public double PriceOld { get; set; }
        [Display(Name = "Gía cũ")]
        public double PriceNew { get; set; }

        [Display(Name = "Giảm giá")]
        public double DisCount { get; set; }
        public string? Size { get; set; }
        public int Number { get; set; }
        public int Views { get; set; }

        public int? Likes { get; set; }

        public double? Star { get; set; }

        public byte? Home { get; set; }

        public byte? Hot { get; set; }

        public DateTime? CreateDate { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public string? AdminCreated { get; set; }

        public string? AdminUpdated { get; set; }

        public byte? Status { get; set; }

        public bool? Isdelete { get; set; }
        [ForeignKey("Size")]
        public int? SizeId { get; set; }
        public Size? Sizes { get; set; }

        [ForeignKey("Color")]
        public int? ColorId { get; set; }
        public Color? Color { get; set; }
        [ForeignKey("Share")]
        public int? ShareId { get; set; }
        public Share? Shares { get; set; }

        public bool? IsArrived { get; set; }

        public bool? Istrandy { get; set; }


    }
}
