using Repository.Data;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.Repositories.AdminPagesCrud
{
    public interface IPartnerRepository
    {
        IEnumerable<Partner> GetPartners(int count);
        IEnumerable<Partner> GetAllPartners();
        void CreatePartner(Partner model);
        Partner GetPartnerById(int id);
        void UpdatePartner(Partner PartnerToUpdate, Partner model);
        void DeletePartner(Partner Partner);
    }
    public class PartnerRepository : IPartnerRepository
    {
        private readonly RetHouseDbContext _context;
        public PartnerRepository(RetHouseDbContext context)
        {
            _context = context;
        }

        public void CreatePartner(Partner model)
        {
            model.CreatedAt = DateTime.Now;
            _context.Partners.Add(model);
            _context.SaveChanges();
        }

        public void DeletePartner(Partner Partner)
        {
            _context.Partners.Remove(Partner);
            _context.SaveChanges();
        }

        public Partner GetPartnerById(int id)
        {
            return _context.Partners.Find(id);
        }

        public IEnumerable<Partner> GetPartners(int count)
        {
            return _context.Partners.Where(a => a.Status).Take(count).ToList();
        }

        public IEnumerable<Partner> GetAllPartners()
        {
            return _context.Partners.ToList();
        }

        public void UpdatePartner(Partner PartnerToUpdate, Partner model)
        {
            PartnerToUpdate.Status = model.Status;
            PartnerToUpdate.OrderBy = model.OrderBy;
            PartnerToUpdate.Logo = model.Logo;
            PartnerToUpdate.ModifiedBy = model.ModifiedBy;
            PartnerToUpdate.ModifiedAt = DateTime.Now;
            _context.SaveChanges();
        }


    }
}
