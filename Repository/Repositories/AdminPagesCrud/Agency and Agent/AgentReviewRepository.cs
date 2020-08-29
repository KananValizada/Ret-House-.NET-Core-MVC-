using Microsoft.EntityFrameworkCore;
using Repository.Data;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.Repositories.AdminPagesCrud.Agency_and_Agent
{
    public interface IAgentReviewRepository
    {
        IEnumerable<AgentReview> GetAgentReviews(int count);
        IEnumerable<AgentReview> GetAllAgentReviews();
        void CreateAgentReview(AgentReview model);
        AgentReview GetAgentReviewById(int id);
        void UpdateAgentReview(AgentReview AgentReviewToUpdate, AgentReview model);
        void DeleteAgentReview(AgentReview AgentReview);
    }
    public class AgentReviewRepository : IAgentReviewRepository
    {
        private readonly RetHouseDbContext _context;
        public AgentReviewRepository(RetHouseDbContext context)
        {
            _context = context;
        }

        public void CreateAgentReview(AgentReview model)
        {
            model.CreatedAt = DateTime.Now;
            _context.AgentReviews.Add(model);
            _context.SaveChanges();
        }

        public void DeleteAgentReview(AgentReview AgentReview)
        {
            _context.AgentReviews.Remove(AgentReview);
            _context.SaveChanges();
        }

        public AgentReview GetAgentReviewById(int id)
        {
            return _context.AgentReviews.Find(id);
        }

        public IEnumerable<AgentReview> GetAgentReviews(int count)
        {
            return _context.AgentReviews.Where(a => a.Status).Take(count).ToList();
        }

        public IEnumerable<AgentReview> GetAllAgentReviews()
        {
            return _context.AgentReviews.Include("Agent").ToList();
        }

        public void UpdateAgentReview(AgentReview AgentReviewToUpdate, AgentReview model)
        {
            AgentReviewToUpdate.Status = model.Status;
            AgentReviewToUpdate.AgentId = model.AgentId;
            AgentReviewToUpdate.Name = model.Name;
            AgentReviewToUpdate.Comment = model.Comment;
            AgentReviewToUpdate.Star = model.Star;
            AgentReviewToUpdate.ModifiedBy = model.ModifiedBy;
            AgentReviewToUpdate.ModifiedAt = DateTime.Now;
            _context.SaveChanges();
        }


    }
}
