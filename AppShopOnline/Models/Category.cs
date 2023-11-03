using System.ComponentModel.DataAnnotations;

namespace AppShopOnline.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(300)]
        [Display(Name = "Tên sản phẩm")]
        public string Name { get; set; }
        [StringLength(300)]
        [Display(Name = "Hình")]
        public string Image { get; set; }
        [Display(Name = "Tên Icon")]
        public string Icon { get; set; }
        [Display(Name = "Sale")]
        public string MateName { get; set; }
        [Display(Name = "Từ khóa sale")]
        public string MetaKeyword { get; set; }
        [Display(Name = "Mô tả")]
        public string MetaDescription { get; set; }
        [Display(Name = "Sên")]
        public string Slug { get; set; }
        [Display(Name = "Tên Order")]
        public int Order { get; set; }
        public int? Parentid { get; set; }
        [Display(Name = "Ngày tạo")]
        public DateTime CreatedDate { get; set; }
        [Display(Name = "Ngày sửa")]
        public DateTime UpdatedDate { get; set; }
        [Display(Name = "Người tạo")]
        public string AdminCreated { get; set; }
        [Display(Name = "Người sửa")]
        public string AdminUpdated { get; set; }
        [Display(Name = "Ghi chú")]
        public string Notes { get; set; }
        [Display(Name = "Trạng thái")]
        public byte Status { get; set; }
        [Display(Name = "Xóa")]
        public bool Isdelete { get; set; }
    }
}
