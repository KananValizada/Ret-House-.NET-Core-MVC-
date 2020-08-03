using Repository.Data;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.Repositories.AdminPagesCrud.Blogs
{
    public interface IBlogPhaseRepository
    {
        IEnumerable<BlogPhase> GetBlogPhases(int count);
        IEnumerable<BlogPhase> GetAllBlogPhases();
        void CreateBlogPhase(BlogPhase model);
        BlogPhase GetBlogPhaseById(int id);
        void UpdateBlogPhase(BlogPhase BlogPhaseToUpdate, BlogPhase model);
        void DeleteBlogPhase(BlogPhase BlogPhase);
    }
    public class BlogPhaseRepository : IBlogPhaseRepository
    {
        private readonly RetHouseDbContext _context;
        public BlogPhaseRepository(RetHouseDbContext context)
        {
            _context = context;
        }

        public void CreateBlogPhase(BlogPhase model)
        {
            model.CreatedAt = DateTime.Now;
            _context.BlogPhases.Add(model);
            _context.SaveChanges();
        }

        public void DeleteBlogPhase(BlogPhase BlogPhase)
        {
            _context.BlogPhases.Remove(BlogPhase);
            _context.SaveChanges();
        }

        public BlogPhase GetBlogPhaseById(int id)
        {
            return _context.BlogPhases.Find(id);
        }

        public IEnumerable<BlogPhase> GetBlogPhases(int count)
        {
            return _context.BlogPhases.Where(a => a.Status).Take(count).ToList();
        }

        public IEnumerable<BlogPhase> GetAllBlogPhases()
        {
            return _context.BlogPhases.ToList();
        }

        public void UpdateBlogPhase(BlogPhase BlogPhaseToUpdate, BlogPhase model)
        {
            BlogPhaseToUpdate.Status = model.Status;
            BlogPhaseToUpdate.Name = model.Name;
            BlogPhaseToUpdate.Phase = model.Phase;
            BlogPhaseToUpdate.ModifiedBy = model.ModifiedBy;
            BlogPhaseToUpdate.ModifiedAt = DateTime.Now;
            _context.SaveChanges();
        }


    }
}
