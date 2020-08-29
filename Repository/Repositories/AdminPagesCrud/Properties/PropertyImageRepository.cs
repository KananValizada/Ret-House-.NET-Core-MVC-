using Microsoft.EntityFrameworkCore;
using Repository.Data;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.Repositories.AdminPagesCrud.Properties
{
    public interface IPropImageRepository
    {
        IEnumerable<PropImage> GetPropImages(int count);
        IEnumerable<PropImage> GetAllPropImages();
        void CreatePropImage(PropImage model);
        PropImage GetPropImageById(int id);
        void UpdatePropImage(PropImage PropImageToUpdate, PropImage model);
        void DeletePropImage(PropImage PropImage);
    }
    public class PropImageRepository : IPropImageRepository
    {
        private readonly RetHouseDbContext _context;
        public PropImageRepository(RetHouseDbContext context)
        {
            _context = context;
        }

        public void CreatePropImage(PropImage model)
        {
            model.CreatedAt = DateTime.Now;
            _context.PropImages.Add(model);
            _context.SaveChanges();
        }

        public void DeletePropImage(PropImage PropImage)
        {
            _context.PropImages.Remove(PropImage);
            _context.SaveChanges();
        }

        public PropImage GetPropImageById(int id)
        {
            return _context.PropImages.Find(id);
        }

        public IEnumerable<PropImage> GetPropImages(int count)
        {
            return _context.PropImages.Where(a => a.Status).Take(count).ToList();
        }

        public IEnumerable<PropImage> GetAllPropImages()
        {
            return _context.PropImages.Include("Property").ToList();
        }

        public void UpdatePropImage(PropImage PropImageToUpdate, PropImage model)
        {
            PropImageToUpdate.Status = model.Status;
            PropImageToUpdate.PropertyId = model.PropertyId;
            PropImageToUpdate.Photo = model.Photo;
            PropImageToUpdate.ModifiedBy = model.ModifiedBy;
            PropImageToUpdate.ModifiedAt = DateTime.Now;
            _context.SaveChanges();
        }


    }
}
