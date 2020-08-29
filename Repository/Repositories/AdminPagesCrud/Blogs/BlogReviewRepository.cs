using Microsoft.EntityFrameworkCore;
using Repository.Data;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.Repositories.AdminPagesCrud.Blogs
{
    public interface IBlogReviewRepository
    {
        IEnumerable<BlogReview> GetBlogReviews(int count);
        IEnumerable<BlogReview> GetAllBlogReviews();
        void CreateBlogReview(BlogReview model);
        BlogReview GetBlogReviewById(int id);
        void UpdateBlogReview(BlogReview BlogReviewToUpdate, BlogReview model);
        void DeleteBlogReview(BlogReview BlogReview);
    }
    public class BlogReviewRepository : IBlogReviewRepository
    {
        private readonly RetHouseDbContext _context;
        public BlogReviewRepository(RetHouseDbContext context)
        {
            _context = context;
        }

        public void CreateBlogReview(BlogReview model)
        {
            model.CreatedAt = DateTime.Now;
            _context.BlogReviews.Add(model);
            _context.SaveChanges();
        }

        public void DeleteBlogReview(BlogReview BlogReview)
        {
            _context.BlogReviews.Remove(BlogReview);
            _context.SaveChanges();
        }

        public BlogReview GetBlogReviewById(int id)
        {
            return _context.BlogReviews.Find(id);
        }

        public IEnumerable<BlogReview> GetBlogReviews(int count)
        {
            return _context.BlogReviews.Where(a => a.Status).Take(count).ToList();
        }

        public IEnumerable<BlogReview> GetAllBlogReviews()
        {
            return _context.BlogReviews.Include("Blog").ToList();
        }

        public void UpdateBlogReview(BlogReview BlogReviewToUpdate, BlogReview model)
        {
            BlogReviewToUpdate.Status = model.Status;
            BlogReviewToUpdate.BlogId = model.BlogId;
            BlogReviewToUpdate.Name = model.Name;
            BlogReviewToUpdate.Comment = model.Comment;
            BlogReviewToUpdate.Star = model.Star;
            BlogReviewToUpdate.ModifiedBy = model.ModifiedBy;
            BlogReviewToUpdate.ModifiedAt = DateTime.Now;
            _context.SaveChanges();
        }


    }
}
