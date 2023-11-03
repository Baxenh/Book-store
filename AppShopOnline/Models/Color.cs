using System.ComponentModel.DataAnnotations;

namespace AppShopOnline.Models
{
    public class Color
    {
        [Key]
        public int ColorId { get; set; }
        [StringLength(10)]
        [Display(Name = "Tên Màu")]
        public string ColorName { get; set; }
    }
}
