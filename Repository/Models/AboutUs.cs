using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Repository.Models
{
    public class AboutUs : BaseEntity
    {
        [Required]
        [MaxLength(50)]
        public string Title { get; set; }
        [Required]
        [MaxLength(1000)]
        public string Text { get; set; }
        [Required]
        [MaxLength(50)]
        public string FirstImage { get; set; }
        [Required]
        [MaxLength(50)]
        public string SecondImage { get; set; }
        public ICollection<Team> Teams { get; set; }
    }
}
