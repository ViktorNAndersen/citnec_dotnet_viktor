using System.ComponentModel.DataAnnotations;

namespace RazorPagesPlayground.Models
{
    public class Post
    {
        public int ID { get; set; }

        [Required]
        public required string Title { get; set; }

        public string Content { get; set; } = string.Empty;
    }
}
