using System.ComponentModel.DataAnnotations;

using System.ComponentModel.DataAnnotations.Schema;


namespace WebShop.Models
{
    [Table("Blogs")]
    public class Blog
    {

        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(300)]
        public string Name { get; set; } = null!;

        public int Status { get; set; }

        public int ViewCount { get; set; }

        public DateTime CreatedDate { get; set; }
       
        [StringLength(300)]
        public string Image { get; set; } = null!;
        [Required]
        [StringLength(300)]
        public string Description { get; set; } = null!;



    }
}
