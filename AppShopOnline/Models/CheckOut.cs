using System.ComponentModel.DataAnnotations;

namespace AppShopOnline.Models
{
    public class CheckOut
    {
        [Key]
        public int Id { get; set; }

        public int CustomerId { get; set; }
        [Required]
        [StringLength(300)]
        [Display(Name ="Tên CheckOu")]
        public string Name { get; set; } = null!;
        [Required]
        public string Email { get; set; } = null!;
        [Required]        
        [Display(Name = "Địa chỉ")]
        public string Address { get; set; } = null!;
        [Required]
        [Display(Name = "Địện thoại")]
        public string PhoneNumber { get; set; }
        [Required]
        [StringLength(30)]
        [Display(Name = "Mã Code")]

        public string ZipCode { get; set; }
        [Display(Name = "Ngày CheckOut")]
        public DateTime CreatedDate { get; set; }
        [Display(Name = "Trạng thái")]
        public byte Status { get; set; }
    }
}
