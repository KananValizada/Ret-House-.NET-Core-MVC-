using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Repository.Models
{
    public class PropDetail 
    {
        public int Id { get; set; }
        public int PropertyId { get; set; }
        [Required]
        [MaxLength(50)]
        public string Key { get; set; }
        [Required]
        [MaxLength(50)]
        public string Value { get; set; }
        public Property Property { get; set; }
    }
}
