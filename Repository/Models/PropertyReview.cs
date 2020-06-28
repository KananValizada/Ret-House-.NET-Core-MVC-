using System.ComponentModel.DataAnnotations;

namespace Repository.Models
{
    public class PropertyReview : BaseEntity
    {
        public int PropertyId { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        [Required]
        [MaxLength(500)]
        public string Comment { get; set; }
        [Required]
        public byte Star { get; set; }
        public Property Property { get; set; }
    }
}
