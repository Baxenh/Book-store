using System.ComponentModel.DataAnnotations;

namespace AppShopOnline.Models
{
    public class New
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(300)]
        [Display(Name = "Mã code")]
        public string Code { get; set; }
        [Required]
        [StringLength(300)]
        [Display(Name = "Tiêu đề")]
        public string Title { get; set; }

        [StringLength(3000)]
        [Display(Name = "Mô tả")]
        public string Description { get; set; }
        [Display(Name = "Nội dung")]
        [StringLength(3000)]
        public string Content { get; set; }
        [Required]
        [StringLength(300)]
        [Display(Name = "Hình ")]
        public string Image { get; set; }
        [Display(Name = "Nội dung Sale")]
        public string MetaTitle { get; set; }
        [Display(Name = "Main Sale")]
        public string MainKeyword { get; set; }
        [Display(Name = "Từ Khóa Sale")]
        public string MetaKeyword { get; set; }
        [Display(Name = "Mô tả")]
        public string MetaDescription { get; set; }
        [Display(Name = "Sên")]
        public string Slug { get; set; }
        [Display(Name = "Lượt xem")]
        public int Views { get; set; }
        [Display(Name = "Lượt thích")]
        public int Likes { get; set; }
        [Display(Name = "Sao")]
        public double Star { get; set; }
        [Display(Name = "Ngày tạo")]
        public DateTime CreatedDatge { get; set; }
        [Display(Name = "Ngày sửa")]
        public DateTime UpdatedDate { get; set; }
        [Display(Name = "Ngày sửa")]
        public string AdminCreated { get; set; }
        [Display(Name = "Người sửa")]
        public string AdminUpdated { get; set; }
        [Display(Name = "tình trạng")]
        public byte Status { get; set; }
        [Display(Name = "Xóa")]
        public bool Isdelete { get; set; }
    }

}
