using System.ComponentModel.DataAnnotations;

namespace AppShopOnline.Models
{
    public class Share
    {
        [Key]
        public int ShareId { get; set; }
        [StringLength(100)]
        [Display(Name ="Mạng xã hội")]
        public string ShareName { get; set; }
    }
}
