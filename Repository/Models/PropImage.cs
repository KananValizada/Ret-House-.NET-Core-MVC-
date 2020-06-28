using System.ComponentModel.DataAnnotations;

namespace Repository.Models
{
    public class PropImage : BaseEntity
    {
        public int PropertyId { get; set; }
        [Required]
        [MaxLength(100)]
        public string Photo { get; set; }
        public Property Property { get; set; }
    }
}
