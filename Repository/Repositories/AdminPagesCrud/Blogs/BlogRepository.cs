using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Repository.Data;
using Repository.Models;

namespace Repository.Repositories.AdminPagesCrud.Blogs
{

    public interface IBlogRepository
    {
        IEnumerable<Blog> GetBlogs(int count);
        IEnumerable<Blog> GetAllBlogs();
        void CreateBlog(Blog model);
        Blog GetBlogById(int id);
        void UpdateBlog(Blog BlogToUpdate, Blog model);
        void DeleteBlog(Blog Blog);
    }
    public class BlogRepository : IBlogRepository
    {
        private readonly RetHouseDbContext _context;
        public BlogRepository(RetHouseDbContext context)
        {
            _context = context;
        }

        public void CreateBlog(Blog model)
        {
            model.CreatedAt = DateTime.Now;
            _context.Blogs.Add(model);
            _context.SaveChanges();
        }

        public void DeleteBlog(Blog Blog)
        {
            _context.Blogs.Remove(Blog);
            _context.SaveChanges();
        }

        public Blog GetBlogById(int id)
        {
            return _context.Blogs.Find(id);
        }

        public IEnumerable<Blog> GetBlogs(int count)
        {
            return _context.Blogs.Where(a => a.Status).Take(count).ToList();
        }

        public IEnumerable<Blog> GetAllBlogs()
        {
            return _context.Blogs.Include("BlogPhase").ToList();
        }

        public void UpdateBlog(Blog BlogToUpdate, Blog model)
        {
            BlogToUpdate.Status = model.Status;
            BlogToUpdate.BlogPhaseId = model.BlogPhaseId;
            BlogToUpdate.Image = model.Image;
            BlogToUpdate.Title = model.Title;
            BlogToUpdate.Text = model.Text;
            BlogToUpdate.EndText = model.EndText;
            BlogToUpdate.ModifiedBy = model.ModifiedBy;
            BlogToUpdate.ModifiedAt = DateTime.Now;
            _context.SaveChanges();
        }


    }
}
