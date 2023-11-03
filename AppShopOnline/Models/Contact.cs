using System.ComponentModel.DataAnnotations;

namespace AppShopOnline.Models
{
    public class Contact
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(300)]
        [Display(Name = "Tên Kết nối")]
        public string Title { get; set; }
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
        [Required]
        [Display(Name = "Điện thoại")]
        public string Phone { get; set; }
        [Required]
        [StringLength(3000)]
        [Display(Name = "Địa chỉ")]
        public string Address { get; set; }
        [Required]
        [StringLength(300)]
        [Display(Name = "Nội dung")]
        public string Content { get; set; }
        [Display(Name = "Ngày tạo")]
        public DateTime CreatedDate { get; set; }
        [Display(Name = "Ngày sửa")]
        public DateTime UpdatedDate { get; set; }
        [Display(Name = "Người tạo")]
        public string AdminCreated { get; set; }
        [Display(Name = "Người sửa")]
        public string AdminUpdated { get; set; }
        [Display(Name = "Trạng thái")]
        public byte Status { get; set; }
        [Display(Name = "Xóa")]
        public bool Isdelete { get; set; }
    }
}
