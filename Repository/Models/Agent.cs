using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Repository.Models
{
    public class Agent : BaseEntity
    {
        public int AgencyId { get; set; }
        public int CityId { get; set; }
        public int CategoryId { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        [Required]
        [MaxLength(50)]
        public string OfficePhone { get; set; }
        [Required]
        [MaxLength(50)]
        public string MobilePhone { get; set; }
        [Required]
        [MaxLength(50)]
        public string Fax { get; set; }
        [Required]
        [MaxLength(50)]
        public string Email { get; set; }
        [Required]
        [MaxLength(500)]
        public string Description { get; set; }
        [Required]
        [MaxLength(100)]
        public string Photo { get; set; }
        public Agency Agency { get; set; }
        public City City { get; set; }
        public Category Category { get; set; }
        public ICollection<Property> Properties { get; set; }
        public ICollection<AgentReview> Reviews { get; set; }
    }
}
