﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Repository.Models
{
    public class Category : BaseEntity
    {
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        public int? catId { get; set; }
        public int? othrId { get; set; }
        public ICollection<Agent> Agents { get; set; }
        public ICollection<Agency> Agencies { get; set; }
    }
}
