using Microsoft.EntityFrameworkCore;
using Repository.Data;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.Repositories.Pages
{
    public interface IBlogRepository
    {
        IEnumerable<BlogPhase> GetBlogPhases();
        BlogPhase GetBlogPhaseById(int id);
        IEnumerable<Blog> GetLatestBlogs(int count);
    }
    public class BlogRepository : IBlogRepository
    {
        private readonly RetHouseDbContext _context;
        public BlogRepository(RetHouseDbContext context)
        {
            _context = context;
        }

        public BlogPhase GetBlogPhaseById(int id)
        {
            return _context.BlogPhases.Include("Blogs")
                                      .Include("Blogs.BlogTagRelates")
                                      .Include("Blogs.BlogReviews")
                                      .Include("Blogs.BlogTagRelates.BlogTag").FirstOrDefault(b => b.Id == id);
        }

        public IEnumerable<BlogPhase> GetBlogPhases()
        {
            return _context.BlogPhases.Include("Blogs").Include("Blogs.BlogTagRelates.BlogTag").Where(b => b.Status).ToList();
        }

        public IEnumerable<Blog> GetLatestBlogs(int count)
        {
            return _context.Blogs.Where(b=>b.Status).OrderBy(b=>b.CreatedAt).Take(count).ToList();
        }
    }
}
