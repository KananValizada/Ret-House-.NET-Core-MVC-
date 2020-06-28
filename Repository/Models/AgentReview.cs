using System.ComponentModel.DataAnnotations;

namespace Repository.Models
{
    public class AgentReview : BaseEntity
    {
        public int AgentId { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        [Required]
        [MaxLength(500)]
        public string Comment { get; set; }
        [Required]
        public byte Star { get; set; }
        public Agent Agent { get; set; }
    }
}
