using System.ComponentModel.DataAnnotations;

namespace AppShopOnline.Models
{
    public class Banner
    {
        [Key]
        public int Id { get; set; }       
        [Required]
        [StringLength(300)]
        [Display(Name = "Tiêu đề")]
        public string Title { get; set; }
        [StringLength(300)]
        [Display(Name = "Ảnh")]
        public string Image { get; set; }
        [Display(Name = "Nội dung Sub")]
        public string SubTitle { get; set; }

        [StringLength(300)]
        [Display(Name = "Đường link")]
        public string Urls { get; set; }
        [Display(Name = "Order")]
        public int Orders { get; set; }
        [Display(Name = "Ngày tạo")]
        public string Type { get; set; }
        [Display(Name = "Ngày tạo")]
        public DateTime CreatedDate { get; set; }
        [Display(Name = "Ngày sửa")]
        public DateTime UpdatedDate { get; set; }
        [Display(Name = "Ngày tạo")]
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
