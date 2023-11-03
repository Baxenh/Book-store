using System.ComponentModel.DataAnnotations;

namespace AppShopOnline.Models
{
    public class Blog
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(300)]
        [Display(Name ="Tên Blog")] 
        public string Name { get; set; }
        [Required]
        [StringLength(300)]
        [Display(Name = "Ảnh đại diện")]
        public string Image { get; set; } 
        [Required]
        [StringLength(300)]
        [Display(Name = "Mô tả")]
        public string Description { get; set; }
        [Display(Name = "Ngày tạo")]
        public DateTime CreatedDate { get; set; }

        [Display(Name = "Trạng thái")]
        public byte Status { get; set; }
        [Display(Name = "Lượt xem")]
        public int ViewCount { get; set; }
      
    }
}
