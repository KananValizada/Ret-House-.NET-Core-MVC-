using Repository.Data;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.Repositories.AdminPagesCrud
{
    public interface ITeamRepository
    {
        IEnumerable<Team> GetTeams(int count);
        IEnumerable<Team> GetAllTeams();
        void CreateTeam(Team model);
        Team GetTeamById(int id);
        void UpdateTeam(Team TeamToUpdate, Team model);
        void DeleteTeam(Team Team);
    }
    public class TeamRepository : ITeamRepository
    {
        private readonly RetHouseDbContext _context;
        public TeamRepository(RetHouseDbContext context)
        {
            _context = context;
        }

        public void CreateTeam(Team model)
        {
            model.CreatedAt = DateTime.Now;
            _context.Teams.Add(model);
            _context.SaveChanges();
        }

        public void DeleteTeam(Team Team)
        {
            _context.Teams.Remove(Team);
            _context.SaveChanges();
        }

        public Team GetTeamById(int id)
        {
            return _context.Teams.Find(id);
        }

        public IEnumerable<Team> GetTeams(int count)
        {
            return _context.Teams.Where(a => a.Status).Take(count).ToList();
        }

        public IEnumerable<Team> GetAllTeams()
        {
            return _context.Teams.ToList();
        }

        public void UpdateTeam(Team TeamToUpdate, Team model)
        {
            TeamToUpdate.Status = model.Status;
            TeamToUpdate.OrderBy = model.OrderBy;
            TeamToUpdate.AboutUsId = model.AboutUsId;
            TeamToUpdate.Name = model.Name;
            TeamToUpdate.Profession = model.Profession;
            TeamToUpdate.Image = model.Image;
            TeamToUpdate.ModifiedBy = model.ModifiedBy;
            TeamToUpdate.ModifiedAt = DateTime.Now;
            _context.SaveChanges();
        }


    }
}
