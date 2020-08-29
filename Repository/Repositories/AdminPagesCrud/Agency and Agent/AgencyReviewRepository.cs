using Microsoft.EntityFrameworkCore;
using Repository.Data;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.Repositories.AdminPagesCrud.Agency_and_Agent
{
    public interface IAgencyReviewRepository
    {
        IEnumerable<AgencyReview> GetAgencyReviews(int count);
        IEnumerable<AgencyReview> GetAllAgencyReviews();
        void CreateAgencyReview(AgencyReview model);
        AgencyReview GetAgencyReviewById(int id);
        void UpdateAgencyReview(AgencyReview AgencyReviewToUpdate, AgencyReview model);
        void DeleteAgencyReview(AgencyReview AgencyReview);
    }
    public class AgencyReviewRepository : IAgencyReviewRepository
    {
        private readonly RetHouseDbContext _context;
        public AgencyReviewRepository(RetHouseDbContext context)
        {
            _context = context;
        }

        public void CreateAgencyReview(AgencyReview model)
        {
            model.CreatedAt = DateTime.Now;
            _context.AgencyReviews.Add(model);
            _context.SaveChanges();
        }

        public void DeleteAgencyReview(AgencyReview AgencyReview)
        {
            _context.AgencyReviews.Remove(AgencyReview);
            _context.SaveChanges();
        }

        public AgencyReview GetAgencyReviewById(int id)
        {
            return _context.AgencyReviews.Find(id);
        }

        public IEnumerable<AgencyReview> GetAgencyReviews(int count)
        {
            return _context.AgencyReviews.Where(a => a.Status).Take(count).ToList();
        }

        public IEnumerable<AgencyReview> GetAllAgencyReviews()
        {
            return _context.AgencyReviews.Include("Agency").ToList();
        }

        public void UpdateAgencyReview(AgencyReview AgencyReviewToUpdate, AgencyReview model)
        {
            AgencyReviewToUpdate.Status = model.Status;
            AgencyReviewToUpdate.AgencyId = model.AgencyId;
            AgencyReviewToUpdate.Name = model.Name;
            AgencyReviewToUpdate.Comment = model.Comment;
            AgencyReviewToUpdate.Star = model.Star;
            AgencyReviewToUpdate.ModifiedBy = model.ModifiedBy;
            AgencyReviewToUpdate.ModifiedAt = DateTime.Now;
            _context.SaveChanges();
        }


    }
}
