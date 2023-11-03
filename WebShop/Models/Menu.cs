using System.ComponentModel.DataAnnotations;

namespace WebShop.Models
{
    public class Menu
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string? Urls { get; set; }
        [Required]
        public string? Type { get; set; }
        public int? Table { get; set; }
        public int? Orders { get; set; }
        public int? Parentid { get; set; }
        public int Status { get; set; }
    }
}
