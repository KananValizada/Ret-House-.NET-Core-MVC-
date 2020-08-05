using Repository.Data;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.Repositories.AdminPagesCrud.Properties
{
    public interface IPropFloorRepository
    {
        IEnumerable<PropFloor> GetPropFloors(int count);
        IEnumerable<PropFloor> GetAllPropFloors();
        void CreatePropFloor(PropFloor model);
        PropFloor GetPropFloorById(int id);
        void UpdatePropFloor(PropFloor PropFloorToUpdate, PropFloor model);
        void DeletePropFloor(PropFloor PropFloor);
    }
    public class PropFloorRepository : IPropFloorRepository
    {
        private readonly RetHouseDbContext _context;
        public PropFloorRepository(RetHouseDbContext context)
        {
            _context = context;
        }

        public void CreatePropFloor(PropFloor model)
        {
            model.CreatedAt = DateTime.Now;
            _context.PropFloors.Add(model);
            _context.SaveChanges();
        }

        public void DeletePropFloor(PropFloor PropFloor)
        {
            _context.PropFloors.Remove(PropFloor);
            _context.SaveChanges();
        }

        public PropFloor GetPropFloorById(int id)
        {
            return _context.PropFloors.Find(id);
        }

        public IEnumerable<PropFloor> GetPropFloors(int count)
        {
            return _context.PropFloors.Where(a => a.Status).Take(count).ToList();
        }

        public IEnumerable<PropFloor> GetAllPropFloors()
        {
            return _context.PropFloors.ToList();
        }

        public void UpdatePropFloor(PropFloor PropFloorToUpdate, PropFloor model)
        {
            PropFloorToUpdate.Status = model.Status;
            PropFloorToUpdate.PropertyId = model.PropertyId;
            PropFloorToUpdate.Name = model.Name;
            PropFloorToUpdate.Area = model.Area;
            PropFloorToUpdate.Photo = model.Photo;
            PropFloorToUpdate.ModifiedBy = model.ModifiedBy;
            PropFloorToUpdate.ModifiedAt = DateTime.Now;
            _context.SaveChanges();
        }


    }
}
