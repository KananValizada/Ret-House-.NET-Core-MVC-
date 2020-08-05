using Repository.Data;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.Repositories.AdminPagesCrud.Properties
{
    public interface IPropertyRepository
    {
        IEnumerable<Property> GetProperties(int count);
        IEnumerable<Property> GetAllProperties();
        void CreateProperty(Property model);
        Property GetPropertyById(int id);
        void UpdateProperty(Property PropertyToUpdate, Property model);
        void DeleteProperty(Property Property);
    }
    public class PropertyRepository : IPropertyRepository
    {
        private readonly RetHouseDbContext _context;
        public PropertyRepository(RetHouseDbContext context)
        {
            _context = context;
        }

        public void CreateProperty(Property model)
        {
            model.CreatedAt = DateTime.Now;
            _context.Properties.Add(model);
            _context.SaveChanges();
        }

        public void DeleteProperty(Property Property)
        {
            _context.Properties.Remove(Property);
            _context.SaveChanges();
        }

        public Property GetPropertyById(int id)
        {
            return _context.Properties.Find(id);
        }

        public IEnumerable<Property> GetProperties(int count)
        {
            return _context.Properties.Where(a => a.Status).Take(count).ToList();
        }

        public IEnumerable<Property> GetAllProperties()
        {
            return _context.Properties.ToList();
        }

        public void UpdateProperty(Property PropertyToUpdate, Property model)
        {
            PropertyToUpdate.Status = model.Status;
            PropertyToUpdate.CountryId = model.CountryId;
            PropertyToUpdate.AgencyId = model.AgencyId;
            PropertyToUpdate.AgentId = model.AgentId;
            PropertyToUpdate.Name = model.Name;
            PropertyToUpdate.RoomCount = model.RoomCount;
            PropertyToUpdate.BathCount = model.BathCount;
            PropertyToUpdate.BedCount = model.BedCount;
            PropertyToUpdate.Price = model.Price;
            PropertyToUpdate.Adress = model.Adress;
            PropertyToUpdate.Description = model.Description;
            PropertyToUpdate.Area = model.Area;
            PropertyToUpdate.Video = model.Video;
            PropertyToUpdate.IsFeatured = model.IsFeatured;
            PropertyToUpdate.PropStatus = model.PropStatus;
            PropertyToUpdate.PropFilter = model.PropFilter;
            PropertyToUpdate.ModifiedBy = model.ModifiedBy;
            PropertyToUpdate.ModifiedAt = DateTime.Now;
            _context.SaveChanges();
        }


    }
}
