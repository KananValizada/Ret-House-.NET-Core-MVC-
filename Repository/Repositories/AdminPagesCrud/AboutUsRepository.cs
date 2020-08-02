using Repository.Data;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.Repositories.AdminPagesCrud
{
    public interface IAboutUsRepository
    {
        IEnumerable<AboutUs> GetAboutUs(int count);
        IEnumerable<AboutUs> GetAllAboutUs();
        void CreateAboutUs(AboutUs model);
        AboutUs GetAboutUsById(int id);
        void UpdateAboutUs(AboutUs AboutUsToUpdate, AboutUs model);
        void DeleteAboutUs(AboutUs AboutUs);
    }
    public class AboutUsRepository : IAboutUsRepository
    {
        private readonly RetHouseDbContext _context;
        public AboutUsRepository(RetHouseDbContext context)
        {
            _context = context;
        }

        public void CreateAboutUs(AboutUs model)
        {
            model.CreatedAt = DateTime.Now;
            _context.AboutUs.Add(model);
            _context.SaveChanges();
        }

        public void DeleteAboutUs(AboutUs AboutUs)
        {
            _context.AboutUs.Remove(AboutUs);
            _context.SaveChanges();
        }

        public AboutUs GetAboutUsById(int id)
        {
            return _context.AboutUs.Find(id);
        }

        public IEnumerable<AboutUs> GetAboutUs(int count)
        {
            return _context.AboutUs.Where(a => a.Status).Take(count).ToList();
        }

        public IEnumerable<AboutUs> GetAllAboutUs()
        {
            return _context.AboutUs.ToList();
        }

        public void UpdateAboutUs(AboutUs AboutUsToUpdate, AboutUs model)
        {
            AboutUsToUpdate.Status = model.Status;
            AboutUsToUpdate.Title = model.Title;
            AboutUsToUpdate.Text = model.Text;
            AboutUsToUpdate.FirstImage = model.FirstImage;
            AboutUsToUpdate.SecondImage = model.SecondImage;
            AboutUsToUpdate.ModifiedBy = model.ModifiedBy;
            AboutUsToUpdate.ModifiedAt = DateTime.Now;
            _context.SaveChanges();
        }


    }
}
