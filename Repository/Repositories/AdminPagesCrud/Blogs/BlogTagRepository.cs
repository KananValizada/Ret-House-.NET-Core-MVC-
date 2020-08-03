using Repository.Data;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.Repositories.AdminPagesCrud.Blogs
{
    public interface IBlogTagRepository
    {
        IEnumerable<BlogTag> GetBlogTags(int count);
        IEnumerable<BlogTag> GetAllBlogTags();
        void CreateBlogTag(BlogTag model);
        BlogTag GetBlogTagById(int id);
        void UpdateBlogTag(BlogTag BlogTagToUpdate, BlogTag model);
        void DeleteBlogTag(BlogTag BlogTag);
    }
    public class BlogTagRepository : IBlogTagRepository
    {
        private readonly RetHouseDbContext _context;
        public BlogTagRepository(RetHouseDbContext context)
        {
            _context = context;
        }

        public void CreateBlogTag(BlogTag model)
        {
            model.CreatedAt = DateTime.Now;
            _context.BlogTags.Add(model);
            _context.SaveChanges();
        }

        public void DeleteBlogTag(BlogTag BlogTag)
        {
            _context.BlogTags.Remove(BlogTag);
            _context.SaveChanges();
        }

        public BlogTag GetBlogTagById(int id)
        {
            return _context.BlogTags.Find(id);
        }

        public IEnumerable<BlogTag> GetBlogTags(int count)
        {
            return _context.BlogTags.Where(a => a.Status).Take(count).ToList();
        }

        public IEnumerable<BlogTag> GetAllBlogTags()
        {
            return _context.BlogTags.ToList();
        }

        public void UpdateBlogTag(BlogTag BlogTagToUpdate, BlogTag model)
        {
            BlogTagToUpdate.Status = model.Status;
            BlogTagToUpdate.Name = model.Name;
            BlogTagToUpdate.ModifiedBy = model.ModifiedBy;
            BlogTagToUpdate.ModifiedAt = DateTime.Now;
            _context.SaveChanges();
        }


    }
}
