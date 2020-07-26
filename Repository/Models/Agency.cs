using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Repository.Models
{
    public class Agency : BaseEntity
    {
        public int CategoryId { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        [Required]
        [MaxLength(100)]
        public string Logo { get; set; }
        [Required]
        [MaxLength(50)]
        public string OfficePhone { get; set; }
        [Required]
        [MaxLength(50)]
        public string MobilePhone { get; set; }
        [Required]
        [MaxLength(50)]
        public string Adress { get; set; }
        [Required]
        [MaxLength(50)]
        public string Fax { get; set; }
        [Required]
        [MaxLength(50)]
        public string Email { get; set; }
        [Required]
        [MaxLength(500)]
        public string Description { get; set; }
        public Category Category { get; set; }
        public ICollection<Property> Properties { get; set; }
        public ICollection<Agent> Agents { get; set; }
        public ICollection<AgencyReview> Reviews { get; set; }
    }
}
