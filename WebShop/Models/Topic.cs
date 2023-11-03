using System.ComponentModel.DataAnnotations;

namespace WebShop.Models
{
    public class Topic
    {
        public int Id { get; set; }
      
        [StringLength(300)]
        public string? Title { get; set; }

        public string? Slug { get; set; }
        public int? Orders { get; set; }

        public int? Parentid { get; set; }

        public DateTime? CreateDate { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public string? AdminCreated { get; set; }

        public string? AdminUpdated { get; set; }

        public int Status { get; set; }
    }
}
