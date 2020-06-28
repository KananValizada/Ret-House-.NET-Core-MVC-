using System.ComponentModel.DataAnnotations;

namespace Repository.Models
{
    public class AgencyReview : BaseEntity
    {
        public int AgencyId { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        [Required]
        [MaxLength(500)]
        public string Comment { get; set; }
        [Required]
        public byte Star { get; set; }
        public Agency Agency { get; set; }
    }
}
