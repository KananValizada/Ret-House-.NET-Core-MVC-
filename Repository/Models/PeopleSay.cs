using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Repository.Models
{
    public class PeopleSay : BaseEntity
    {
        [Required]
        [MaxLength(50)]
        public string PersonName { get; set; }
        [Required]
        [MaxLength(50)]
        public string PersonJob { get; set; }
        [Required]
        [MaxLength(250)]
        public string PersonComment { get; set; }
        [Required]
        [MaxLength(100)]
        public string PersonImage { get; set; }
    }
}
