using Repository.Data;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.Repositories.AdminPagesCrud
{
    public interface ICityRepository
    {
        IEnumerable<City> GetCities(int count);
        IEnumerable<City> GetAllCities();
        void CreateCity(City model);
        City GetCityById(int id);
        void UpdateCity(City CityToUpdate, City model);
        void DeleteCity(City City);
    }
    public class CityRepository : ICityRepository
    {
        private readonly RetHouseDbContext _context;
        public CityRepository(RetHouseDbContext context)
        {
            _context = context;
        }

        public void CreateCity(City model)
        {
            model.CreatedAt = DateTime.Now;
            _context.Cities.Add(model);
            _context.SaveChanges();
        }

        public void DeleteCity(City City)
        {
            _context.Cities.Remove(City);
            _context.SaveChanges();
        }

        public City GetCityById(int id)
        {
            return _context.Cities.Find(id);
        }

        public IEnumerable<City> GetCities(int count)
        {
            return _context.Cities.Where(a => a.Status).Take(count).ToList();
        }

        public IEnumerable<City> GetAllCities()
        {
            return _context.Cities.ToList();
        }

        public void UpdateCity(City CityToUpdate, City model)
        {
            CityToUpdate.Status = model.Status;
            CityToUpdate.Name = model.Name;
            CityToUpdate.Photo = model.Photo;
            CityToUpdate.ModifiedBy = model.ModifiedBy;
            CityToUpdate.ModifiedAt = DateTime.Now;
            _context.SaveChanges();
        }


    }
}
