using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace AppShopOnline.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Category")]
        [Display(Name = "Danh mục")]
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public string Code { get; set; }

        [Required]
        [StringLength(300)]
        [Display(Name = "Tên sản phẩm")]
        public string Name { get; set; }
        [StringLength(3000)]
        [Display(Name = "Mô tả")]
        public string Description { get; set; }
        [StringLength(3000)]
        [Display(Name = "Nội dung")]
        public string Content { get; set; }
        [StringLength(300)]
        [Display(Name = "Ảnh đại diện")]
        public string Image { get; set; }
        [Display(Name = "Tiêu đề")]
        public string MetaTitle { get; set; }
        [Display(Name = "Từ khóa")]
        public string MetaKeyword { get; set; }
        [Display(Name = "Mô tả tiêu")]
        public string MetaDescription { get; set; }
        [Display(Name = "Sên")]
        public string Slug { get; set; }
        [Display(Name = "Giá mới")]
        public double PriceOld { get; set; }
        [Display(Name = "Gía cũ")]
        public double PriceNew { get; set; }

        [Display(Name = "Giảm giá")]
        public double DisCount { get; set; }
        [Display(Name = "Cỡ")]
        public string Size { get; set; }
        [Display(Name = "Xem")]
        public int Views { get; set; }
        [Display(Name = "Thích")]
        public int Likes { get; set; }
        [Display(Name = "Sao")]
        public double Star { get; set; }
        [Display(Name = "Home")]
        public byte Home { get; set; }
        [Display(Name = "Hot")]
        public byte Hot { get; set; }
        [Display(Name = "Ngày tạo")]
        public DateTime CreatedDate { get; set; }
        [Display(Name = "Ngày sửa")]
        public DateTime UpdatedDate { get; set; }
        [Display(Name = "Người tạo")]
        public string AdminCreated { get; set; }
        [Display(Name = "Người sửa")]
        public string AdminUpdated { get; set; }
        [Display(Name = "Tình trạng")]
        public byte? Status { get; set; }
        [Display(Name = "Xóa")]
        public bool Isdelete { get; set; }
        [ForeignKey("Size")]
        public int SizeId { get; set; }
        public Size Siez { get; set; }

        [ForeignKey("Color")]
        public int? ColorId { get; set; }        
        public Color Color { get; set; }
        [Display(Name = "Check Sản phẩm Arrived")]
        public bool? IsArrived { get; set; }
        [Display(Name = "Check Sản phẩm Trandy")]
        public bool? Istrandy { get; set; }
    }
}
