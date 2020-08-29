using Microsoft.EntityFrameworkCore;
using Repository.Data;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.Repositories.AdminPagesCrud.Properties
{
    public interface IPropertyReviewRepository
    {
        IEnumerable<PropertyReview> GetPropertyReviews(int count);
        IEnumerable<PropertyReview> GetAllPropertyReviews();
        void CreatePropertyReview(PropertyReview model);
        PropertyReview GetPropertyReviewById(int id);
        void UpdatePropertyReview(PropertyReview PropertyReviewToUpdate, PropertyReview model);
        void DeletePropertyReview(PropertyReview PropertyReview);
    }
    public class PropertyReviewRepository : IPropertyReviewRepository
    {
        private readonly RetHouseDbContext _context;
        public PropertyReviewRepository(RetHouseDbContext context)
        {
            _context = context;
        }

        public void CreatePropertyReview(PropertyReview model)
        {
            model.CreatedAt = DateTime.Now;
            _context.PropertyReviews.Add(model);
            _context.SaveChanges();
        }

        public void DeletePropertyReview(PropertyReview PropertyReview)
        {
            _context.PropertyReviews.Remove(PropertyReview);
            _context.SaveChanges();
        }

        public PropertyReview GetPropertyReviewById(int id)
        {
            return _context.PropertyReviews.Find(id);
        }

        public IEnumerable<PropertyReview> GetPropertyReviews(int count)
        {
            return _context.PropertyReviews.Where(p=> p.Status).Take(count).ToList();
        }

        public IEnumerable<PropertyReview> GetAllPropertyReviews()
        {
            return _context.PropertyReviews.Include("Property").ToList();
        }

        public void UpdatePropertyReview(PropertyReview PropertyReviewToUpdate, PropertyReview model)
        {
            PropertyReviewToUpdate.Status = model.Status;
            PropertyReviewToUpdate.PropertyId = model.PropertyId;
            PropertyReviewToUpdate.Name = model.Name;
            PropertyReviewToUpdate.Comment = model.Comment;
            PropertyReviewToUpdate.Star = model.Star;
            PropertyReviewToUpdate.ModifiedBy = model.ModifiedBy;
            PropertyReviewToUpdate.ModifiedAt = DateTime.Now;
            _context.SaveChanges();
        }


    }
}
