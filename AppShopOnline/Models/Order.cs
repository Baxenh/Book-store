using System.ComponentModel.DataAnnotations;

namespace AppShopOnline.Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Khách hàng")]
        public int CustomerId { get; set; }
        [Required]
        [StringLength(300)]
        [Display(Name = "Tên order")]
        public string Name { get; set; } = null!;
        [StringLength(300)]
        [Display(Name = "Email")]
        public string Email { get; set; } = null!;
        [StringLength(300)]
        [Display(Name = "Địa chỉ")]
        public string Address { get; set; } = null!;
        [Display(Name = "Ngày Order")]
        public DateTime CreatedDate { get; set; }
        [Display(Name = "Tình trạng")]
        public byte Status { get; set; }
    }
}
