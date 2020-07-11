using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Repository.Models
{
    public class City : BaseEntity
    {
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        [Required]
        [MaxLength(100)]
        public string Photo { get; set; }
        public ICollection<Agent> Agents { get; set; }
    }
}
