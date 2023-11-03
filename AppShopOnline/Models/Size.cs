using System.ComponentModel.DataAnnotations;

namespace AppShopOnline.Models
{
    public class Size
    {
        [Key]
        public int SizeId { get; set; }
        [StringLength(10)]
        [Display(Name ="Tên cỡ")]
        public string SizeName { get; set; }
    }
}
