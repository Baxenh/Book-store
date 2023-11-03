using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppShopOnline.Models
{
    public class Cart1
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(300)]
        [Display(Name = "Tên sản phẩm")]
        public string Name { get; set; }
        [StringLength(300)]
        [Display(Name = "Hình")]
        public string Image { get; set; }
        [Display(Name = "Số lượng")]
        public int Quantity { get; set; }
        [Display(Name = "Giá")]
        public double Price { get; set; }
        [Display(Name = "Thành tiền")]
        public double Total {
            get {
                return  Quantity* Price ;
            } 
        }
    }
}
