using Repository.Data;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.Repositories.AdminPagesCrud.Blogs
{
    public interface IBlogTagRelateRepository
    {
        IEnumerable<BlogTagRelate> GetBlogTagRelates(int count);
        IEnumerable<BlogTagRelate> GetAllBlogTagRelates();
        void CreateBlogTagRelate(BlogTagRelate model);
        BlogTagRelate GetBlogTagRelateById(int id);
        void UpdateBlogTagRelate(BlogTagRelate BlogTagRelateToUpdate, BlogTagRelate model);
        void DeleteBlogTagRelate(BlogTagRelate BlogTagRelate);
    }
    public class BlogTagRelateRepository : IBlogTagRelateRepository
    {
        private readonly RetHouseDbContext _context;
        public BlogTagRelateRepository(RetHouseDbContext context)
        {
            _context = context;
        }

        public void CreateBlogTagRelate(BlogTagRelate model)
        {
            _context.BlogTagRelates.Add(model);
            _context.SaveChanges();
        }

        public void DeleteBlogTagRelate(BlogTagRelate BlogTagRelate)
        {
            _context.BlogTagRelates.Remove(BlogTagRelate);
            _context.SaveChanges();
        }

        public BlogTagRelate GetBlogTagRelateById(int id)
        {
            return _context.BlogTagRelates.Find(id);
        }

        public IEnumerable<BlogTagRelate> GetBlogTagRelates(int count)
        {
            return _context.BlogTagRelates.Take(count).ToList();
        }

        public IEnumerable<BlogTagRelate> GetAllBlogTagRelates()
        {
            return _context.BlogTagRelates.ToList();
        }

        public void UpdateBlogTagRelate(BlogTagRelate BlogTagRelateToUpdate, BlogTagRelate model)
        {
            BlogTagRelateToUpdate.BlogId = model.BlogId;
            BlogTagRelateToUpdate.BlogTagId = model.BlogTagId;
            _context.SaveChanges();
        }


    }
}
