using System.ComponentModel.DataAnnotations;

namespace Repository.Models
{
    public class PropFeature
    {
        public int Id { get; set; }
        public int PropertyId { get; set; }
        [Required]
        [MaxLength(50)]
        public string Key { get; set; }
        [Required]
        [MaxLength(50)]
        public bool Value { get; set; }
        public Property Property { get; set; }
    }
}
