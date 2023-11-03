using System.ComponentModel.DataAnnotations;

namespace AppShopOnline.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(300)]
        [Display(Name ="Tên khách hàng")]
        public string FullName { get; set; } 
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
        [Required]
        [Display(Name = "Điện thoại")]
        public string Phone { get; set; } 
        [Required]
        [StringLength(300)]
        [Display(Name = "Địa chỉ khách hàng")]
        public string Address { get; set; }
        [Required]
        [Display(Name = "Hình")]
        public string Avatar { get; set; }
        [Display(Name = "Ngày sinh")]
        public DateTime Birthday { get; set; }
        [Required]
        [Display(Name = "Giới tính")]
        public string Gender { get; set; } 
        [Required]
        [Display(Name = "Mật khẩu")]
        public string Password { get; set; }
        [Display(Name = "Mạng xã hội")]
        public string Facebook { get; set; }
       
    }
}
