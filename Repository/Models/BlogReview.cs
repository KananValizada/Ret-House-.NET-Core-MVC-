using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Repository.Models
{
    public class BlogReview : BaseEntity
    {
        public int BlogId { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        [Required]
        [MaxLength(500)]
        public string Comment { get; set; }
        [Required]
        public byte Star { get; set; }
        public Blog Blog { get; set; }
    }
}
