using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Admin.Filters;
using Microsoft.AspNetCore.Mvc;
using Repository.Models;
using Repository.Repositories.AdminPagesCrud;

namespace Admin.Controllers
{
    [TypeFilter(typeof(Auth))]
    public class CountriesController : Controller
    {
        private Repository.Models.Admin _admin => RouteData.Values["Admin"] as Repository.Models.Admin;
        private readonly ICountryRepository _CountryRepository;

        public CountriesController(ICountryRepository CountryRepository)
        {
            _CountryRepository = CountryRepository;
        }
        public IActionResult Index()
        {
            var Countries = _CountryRepository.GetAllCountries();
            return View(Countries);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Country Country)
        {
            if (ModelState.IsValid)
            {
                Country.CreatedBy = _admin.Fullname;
                _CountryRepository.CreateCountry(Country);
                return RedirectToAction("index");
            }
            return View(Country);
        }
        public IActionResult Edit(int id)
        {
            Country abs = _CountryRepository.GetCountryById(id);
            if (abs == null) return NotFound();
            return View(abs);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Country abs)
        {
            if (ModelState.IsValid)
            {
                abs.ModifiedBy = _admin.Fullname;
                Country CountryToUpdate = _CountryRepository.GetCountryById(abs.Id);
                if (CountryToUpdate == null) return NotFound();
                _CountryRepository.UpdateCountry(CountryToUpdate, abs);
                return RedirectToAction("index");
            }
            return View(abs);
        }
        public IActionResult Delete(int id)
        {
            Country abs = _CountryRepository.GetCountryById(id);
            if (abs == null) return NotFound();
            _CountryRepository.DeleteCountry(abs);
            return RedirectToAction("index");
        }
    }
}
