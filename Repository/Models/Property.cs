using Repository.Enums;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Repository.Models
{
    public class Property : BaseEntity
    {
        public int CountryId { get; set; }
        public int AgentId { get; set; }
        public int AgencyId { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        [Required]
        public byte RoomCount { get; set; }
        [Required]
        public byte BathCount { get; set; }
        [Required]
        public byte BedCount { get; set; }
        [Required]
        [MaxLength(50)]
        public string Price { get; set; }
        [Required]
        [MaxLength(100)]
        public string Adress { get; set; }
        [Required]
        [MaxLength(500)]
        public string Description { get; set; }
        [Required]
        [MaxLength(100)]
        public string Area { get; set; }
        [Required]
        [MaxLength(100)]
        public string Video { get; set; }
        [Required]
        public bool IsFeatured { get; set; }
        [Required]
        public PropStatus PropStatus { get; set; }
        public PropFilter PropFilter { get; set; }
        public Country Country { get; set; }
        public Agent Agent { get; set; }
        public Agency Agency { get; set; }
        public ICollection<PropDetail> PropDetails { get; set; }
        public ICollection<PropFeature> PropFeatures { get; set; }
        public ICollection<PropFloor> PropFloors { get; set; }
        public ICollection<PropImage> PropImages { get; set; }
        public ICollection<PropertyReview> Reviews { get; set; }
    }
}
