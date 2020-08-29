using Microsoft.EntityFrameworkCore;
using Repository.Data;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.Repositories.AdminPagesCrud.Agency_and_Agent
{
    public interface IAgentRepository
    {
        IEnumerable<Agent> GetAgents(int count);
        IEnumerable<Agent> GetAllAgents();
        void CreateAgent(Agent model);
        Agent GetAgentById(int id);
        void UpdateAgent(Agent AgentToUpdate, Agent model);
        void DeleteAgent(Agent Agent);
    }
    public class AgentRepository : IAgentRepository
    {
        private readonly RetHouseDbContext _context;
        public AgentRepository(RetHouseDbContext context)
        {
            _context = context;
        }

        public void CreateAgent(Agent model)
        {
            model.CreatedAt = DateTime.Now;
            _context.Agents.Add(model);
            _context.SaveChanges();
        }

        public void DeleteAgent(Agent Agent)
        {
            _context.Agents.Remove(Agent);
            _context.SaveChanges();
        }

        public Agent GetAgentById(int id)
        {
            return _context.Agents.Find(id);
        }

        public IEnumerable<Agent> GetAgents(int count)
        {
            return _context.Agents.Where(a => a.Status).Take(count).ToList();
        }

        public IEnumerable<Agent> GetAllAgents()
        {
            return _context.Agents.Include("City").Include("Agency").ToList();
        }

        public void UpdateAgent(Agent AgentToUpdate, Agent model)
        {
            AgentToUpdate.Status = model.Status;
            AgentToUpdate.CategoryId = model.CategoryId;
            AgentToUpdate.Name = model.Name;
            AgentToUpdate.OfficePhone = model.OfficePhone;
            AgentToUpdate.MobilePhone = model.MobilePhone;
            AgentToUpdate.CityId = model.CityId;
            AgentToUpdate.Fax = model.Fax;
            AgentToUpdate.Email = model.Email;
            AgentToUpdate.Description = model.Description;
            AgentToUpdate.AgencyId = model.AgencyId;
            AgentToUpdate.Photo = model.Photo;
            AgentToUpdate.ModifiedBy = model.ModifiedBy;
            AgentToUpdate.ModifiedAt = DateTime.Now;
            _context.SaveChanges();
        }


    }
}
