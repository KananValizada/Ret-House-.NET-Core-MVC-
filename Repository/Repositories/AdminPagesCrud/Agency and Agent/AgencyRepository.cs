using Repository.Data;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.Repositories.AdminPagesCrud.Agency_and_Agent
{
    public interface IAgencyRepository
    {
        IEnumerable<Agency> GetAgencies(int count);
        IEnumerable<Agency> GetAllAgencies();
        void CreateAgency(Agency model);
        Agency GetAgencyById(int id);
        void UpdateAgency(Agency AgencyToUpdate, Agency model);
        void DeleteAgency(Agency Agency);
    }
    public class AgencyRepository : IAgencyRepository
    {
        private readonly RetHouseDbContext _context;
        public AgencyRepository(RetHouseDbContext context)
        {
            _context = context;
        }

        public void CreateAgency(Agency model)
        {
            model.CreatedAt = DateTime.Now;
            _context.Agencies.Add(model);
            _context.SaveChanges();
        }

        public void DeleteAgency(Agency Agency)
        {
            _context.Agencies.Remove(Agency);
            _context.SaveChanges();
        }

        public Agency GetAgencyById(int id)
        {
            return _context.Agencies.Find(id);
        }

        public IEnumerable<Agency> GetAgencies(int count)
        {
            return _context.Agencies.Where(a => a.Status).Take(count).ToList();
        }

        public IEnumerable<Agency> GetAllAgencies()
        {
            return _context.Agencies.ToList();
        }

        public void UpdateAgency(Agency AgencyToUpdate, Agency model)
        {
            AgencyToUpdate.Status = model.Status;
            AgencyToUpdate.CategoryId = model.CategoryId;
            AgencyToUpdate.Name = model.Name;
            AgencyToUpdate.OfficePhone = model.OfficePhone;
            AgencyToUpdate.MobilePhone = model.MobilePhone;
            AgencyToUpdate.Adress = model.Adress;
            AgencyToUpdate.Fax = model.Fax;
            AgencyToUpdate.Email = model.Email;
            AgencyToUpdate.Description = model.Description;
            AgencyToUpdate.Logo = model.Logo;
            AgencyToUpdate.ModifiedBy = model.ModifiedBy;
            AgencyToUpdate.ModifiedAt = DateTime.Now;
            _context.SaveChanges();
        }


    }
}
