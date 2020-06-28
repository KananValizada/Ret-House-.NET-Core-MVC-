using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace Repository.Models
{
    public class Blog : BaseEntity
    {
        public int BlogPhaseId { get; set; }
        [Required]
        [MaxLength(50)]
        public string Title { get; set; }
        [Required]
        [MaxLength(100)]
        public string Image { get; set; }
        [Required]
        [MaxLength(500)]
        public string Text { get; set; }
        [Required]
        [MaxLength(500)]
        public string EndText { get; set; }
        public BlogPhase BlogPhase { get; set; }
        public ICollection<BlogTagRelate> BlogTagRelates { get; set; }
        public ICollection<BlogReview> BlogReviews { get; set; }
    }
}
