using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Models
{
    public class BlogTagRelate
    {
        public int Id { get; set; }
        public int BlogId { get; set; }
        public int BlogTagId { get; set; }
        public Blog Blog { get; set; }
        public BlogTag BlogTag { get; set; }
    }
}
