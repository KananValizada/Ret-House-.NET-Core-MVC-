using System.ComponentModel.DataAnnotations;

namespace Repository.Models
{
    public class PropFloor : BaseEntity
    {
        public int PropertyId { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        [Required]
        [MaxLength(50)]
        public string Area { get; set; }
        [Required]
        [MaxLength(100)]
        public string Photo { get; set; }
        public Property Property { get; set; }
    }
}
