using System.ComponentModel.DataAnnotations;

namespace WebShop.Models
{
    [Posts]
    public class Post
    {
        [Key]
        public int Id { get; set; }
        
        public string? TopicId { get; set; }
        [StringLength(300)]
        public string? Title { get; set; }

        public string? Slug { get; set; }

        public string? Detail { get; set; }

        public string? MetaKeyword { get; set; }

        public string? MetaDescription { get; set; }

        public string? Image { get; set; }
        
        public DateTime? CreateDate { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public string? AdminCreated { get; set; }

        public string? AdminUpdated { get; set; }        

        public int Status { get; set; }        

    }
}
