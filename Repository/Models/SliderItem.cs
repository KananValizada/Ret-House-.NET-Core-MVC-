using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Repository.Models
{
    public class SliderItem : BaseEntity
    {
        public int OrderBy { get; set; }
        [Required]
        [MaxLength(100)]
        [MinLength(10, ErrorMessage = "Minimum 10 xarakter")]
        public string Title { get; set; }
        [Required]
        [MaxLength(50)]
        [MinLength(15, ErrorMessage = "Minimum 15 xarakter")]
        public string Slogan { get; set; }
        [Required]
        [MaxLength(100)]
        public string Image { get; set; }
        [MaxLength(50)]
        public string ActionText { get; set; }
        [MaxLength(200)]
        public string EndPoint { get; set; }
    }
}
