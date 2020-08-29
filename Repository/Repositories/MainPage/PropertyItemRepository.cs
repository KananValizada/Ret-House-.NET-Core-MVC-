using Microsoft.EntityFrameworkCore;
using Repository.Data;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.Repositories.MainPage
{
    public interface IMainRepository
    {
        IEnumerable<Agent> GetAgents();
        IEnumerable<Category> GetCategories();
        IEnumerable<City> GetPopularCities(int count);
        IEnumerable<Partner> GetPartners(int count);
        IEnumerable<PeopleSay> GetPeopleSays();
        IEnumerable<BlogPhase> GetBlogItem(int count);
        Category GetCategoryById(int id);
    }
    public class MainRepository : IMainRepository
    {
        private readonly RetHouseDbContext _context;
        public MainRepository(RetHouseDbContext context)
        {
            _context = context; 
        }
        public IEnumerable<Agent> GetAgents()
        {
            return _context.Agents.Include("Properties").Include("Category").Include("Properties.PropImages").Where(p => p.Status).ToList();
                                                            
        }

        public IEnumerable<BlogPhase> GetBlogItem(int count)
        {
            return _context.BlogPhases.Include("Blogs").Include("Blogs.BlogTagRelates")
                                      .Include("Blogs.BlogTagRelates.BlogTag").Where(b => b.Status).Take(count).ToList();
        }

        public IEnumerable<Category> GetCategories()
        {
            return _context.Categories.Include("Agents")
                                      .Include("Agencies")
                                      .Include("Agencies.Agents")
                                      .Include("Agencies.Agents.Properties.PropImages")
                                      .Include("Agents.Properties")
                                      .Include("Agents.Properties.PropImages")
                                      .Where(c => c.Status).ToList();
        }

        public IEnumerable<Partner> GetPartners(int count)
        {
            return _context.Partners.Where(p => p.Status).OrderBy(p => p.OrderBy).Take(count).ToList();
        }

        public IEnumerable<PeopleSay> GetPeopleSays()
        {
            return _context.PeopleSays.Where(p => p.Status).ToList();
        }

        public IEnumerable<City> GetPopularCities(int count)
        {
            return _context.Cities.Include("Agents").Include("Agents.Properties").Where(c => c.Status).Take(count).ToList();
        }

        public Category GetCategoryById(int id)
        {
            return _context.Categories.Include("Agents").Include("Agents.Properties")
                                      .Include("Agents.Reviews")
                                      .Include("Agencies")
                                      .Include("Agencies.Reviews")
                                      .Include("Agencies.Agents")
                                      .Include("Agencies.Agents.Properties")
                                      .Include("Agencies.Agents.Properties.PropImages")
                                      .Include("Agents.Properties.PropImages")
                                      .Include("Agents.Properties.PropDetails")
                                      .Include("Agents.Properties.PropFeatures")
                                      .Include("Agents.Properties.PropFloors")
                                      .Include("Agents.Properties.Reviews").FirstOrDefault(c=>c.Id == id);
        }

    }
}
