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
        List<BlogTagRelate> GetBlogsByTagId(int Id);
        IEnumerable<Blog> GetBlogsByIds(List<BlogTagRelate> model);
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

        public IEnumerable<Blog> GetBlogsByIds(List<BlogTagRelate> model)
        {
            List<Blog> Blogs = new List<Blog>();
            for (int i = 0; i < model.Count(); i++)
            {
                var blog = _context.Blogs.Include("BlogTagRelates").Include("BlogTagRelates.BlogTag")
                                        .Include("BlogPhase").FirstOrDefault(b=>b.Id == model[i].BlogId);
                Blogs.Add(blog);
            }
            IEnumerable<Blog> newModel = Blogs;
            return newModel;
        }

        public List<BlogTagRelate> GetBlogsByTagId(int Id)
        {
            return _context.BlogTagRelates.Where(b => b.BlogTagId == Id).ToList();
        }

        public IEnumerable<Blog> GetLatestBlogs(int count)
        {
            return _context.Blogs.Where(b=>b.Status).OrderBy(b=>b.CreatedAt).Take(count).ToList();
        }
    }
}
