using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Repository.Models
{
    public class Team : BaseEntity
    {
        [Required]
        public int AboutUsId { get; set; }
        [Required]
        public int OrderBy { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        [Required]
        [MaxLength(50)]
        public string Profession { get; set; }
        [Required]
        [MaxLength(100)]
        public string Image { get; set; }
        public AboutUs AboutUs { get; set; }
    }
}
