using Repository.Data;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.Repositories.AdminPagesCrud
{
    public interface ICountryRepository
    {
        IEnumerable<Country> GetCountries(int count);
        IEnumerable<Country> GetAllCountries();
        void CreateCountry(Country model);
        Country GetCountryById(int id);
        void UpdateCountry(Country CountryToUpdate, Country model);
        void DeleteCountry(Country Country);
    }
    public class CountryRepository : ICountryRepository
    {
        private readonly RetHouseDbContext _context;
        public CountryRepository(RetHouseDbContext context)
        {
            _context = context;
        }

        public void CreateCountry(Country model)
        {
            model.CreatedAt = DateTime.Now;
            _context.Countries.Add(model);
            _context.SaveChanges();
        }

        public void DeleteCountry(Country Country)
        {
            _context.Countries.Remove(Country);
            _context.SaveChanges();
        }

        public Country GetCountryById(int id)
        {
            return _context.Countries.Find(id);
        }

        public IEnumerable<Country> GetCountries(int count)
        {
            return _context.Countries.Where(a => a.Status).Take(count).ToList();
        }

        public IEnumerable<Country> GetAllCountries()
        {
            return _context.Countries.ToList();
        }

        public void UpdateCountry(Country CountryToUpdate, Country model)
        {
            CountryToUpdate.Status = model.Status;
            CountryToUpdate.Name = model.Name;
            CountryToUpdate.ModifiedBy = model.ModifiedBy;
            CountryToUpdate.ModifiedAt = DateTime.Now;
            _context.SaveChanges();
        }


    }
}
