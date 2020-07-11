using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Repository.Models
{
    public class Partner : BaseEntity
    {
        [Required]
        public int OrderBy { get; set; }
        [Required]
        [MaxLength(100)]
        public string Logo { get; set; }
    }
}
