using System.ComponentModel.DataAnnotations;

namespace AppShopOnline.Models
{
    public class Slider
    {
        [Key]
        public int Id { get; set; }
      
        [Required]
        [StringLength(300)]
        [Display(Name = "Tiêu đề")]
        public string Title { get; set; }
        [Display(Name = "Hình")]
        public string Image { get; set; }
        [Display(Name = "Tiêu đề Sub")]
        public string SubTitle { get; set; }
        [Display(Name = "Đường link")]
        public string Urls { get; set; }
        [Display(Name = "Order")]
        public int Orders { get; set; }
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
        [Display(Name = "Tình trạng")]
        public byte Status { get; set; }
        [Display(Name = "Xóa")]
        public bool Isdelete { get; set; }
    }
}
