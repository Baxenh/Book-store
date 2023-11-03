using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppShopOnline.Models
{
    public class OrderDetail
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Số order")]
       
        public int OrderId { get; set; }
        [ForeignKey("Order")]
        public Order Orders { get; set; }
        [Display(Name = "Sản phẩm order")]
        public int ProductId { get; set; }
        [ForeignKey("Product")]
        public Product Products { get; set; }
        
        
    }
}
