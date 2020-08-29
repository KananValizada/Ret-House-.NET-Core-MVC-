using Microsoft.EntityFrameworkCore;
using Repository.Data;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.Repositories.AdminPagesCrud.PropDetails
{
    public interface IPropDetailRepository
    {
        IEnumerable<PropDetail> GetPropDetails(int count);
        IEnumerable<PropDetail> GetAllPropDetails();
        void CreatePropDetail(PropDetail model);
        PropDetail GetPropDetailById(int id);
        void UpdatePropDetail(PropDetail PropDetailToUpdate, PropDetail model);
        void DeletePropDetail(PropDetail PropDetail);
    }
    public class PropDetailRepository : IPropDetailRepository
    {
        private readonly RetHouseDbContext _context;
        public PropDetailRepository(RetHouseDbContext context)
        {
            _context = context;
        }

        public void CreatePropDetail(PropDetail model)
        {
            _context.PropDetails.Add(model);
            _context.SaveChanges();
        }

        public void DeletePropDetail(PropDetail PropDetail)
        {
            _context.PropDetails.Remove(PropDetail);
            _context.SaveChanges();
        }

        public PropDetail GetPropDetailById(int id)
        {
            return _context.PropDetails.Find(id);
        }

        public IEnumerable<PropDetail> GetPropDetails(int count)
        {
            return _context.PropDetails.Take(count).ToList();
        }

        public IEnumerable<PropDetail> GetAllPropDetails()
        {
            return _context.PropDetails.Include("Property").ToList();
        }

        public void UpdatePropDetail(PropDetail PropDetailToUpdate, PropDetail model)
        {
            PropDetailToUpdate.PropertyId = model.PropertyId;
            PropDetailToUpdate.Key = model.Key;
            PropDetailToUpdate.Value = model.Value;
            _context.SaveChanges();
        }


    }
}
