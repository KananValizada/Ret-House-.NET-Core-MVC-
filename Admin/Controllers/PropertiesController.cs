using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Admin.Filters;
using Microsoft.AspNetCore.Mvc;
using Repository.Models;
using Repository.Repositories.AdminPagesCrud;
using Repository.Repositories.AdminPagesCrud.Agency_and_Agent;
using Repository.Repositories.AdminPagesCrud.Properties;

namespace Admin.Controllers
{
    [TypeFilter(typeof(Auth))]
    public class PropertiesController : Controller
    {
        private Repository.Models.Admin _admin => RouteData.Values["Admin"] as Repository.Models.Admin;
        private readonly IPropertyRepository _PropertyRepository;
        private readonly IAgentRepository _agentRepository;
        private readonly IAgencyRepository _agencyRepository;
        private readonly ICountryRepository _countryRepository;

        public PropertiesController(IPropertyRepository PropertyRepository, 
                                    IAgentRepository agentRepository,
                                    IAgencyRepository agencyRepository,
                                    ICountryRepository countryRepository)
        {
            _PropertyRepository = PropertyRepository;
            _agentRepository = agentRepository;
            _agencyRepository = agencyRepository;
            _countryRepository = countryRepository;
        }
        public IActionResult Index()
        {
            var Properties = _PropertyRepository.GetAllProperties();
            return View(Properties);
        }
        public IActionResult Create()
        {
            ViewBag.Agents = _agentRepository.GetAllAgents();
            ViewBag.Agencies = _agencyRepository.GetAllAgencies();
            ViewBag.Countries = _countryRepository.GetAllCountries();
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Property Property)
        {
            if (ModelState.IsValid)
            {
                Property.CreatedBy = _admin.Fullname;
                _PropertyRepository.CreateProperty(Property);
                return RedirectToAction("index");
            }
            return View(Property);
        }
        public IActionResult Edit(int id)
        {
            ViewBag.Agents = _agentRepository.GetAllAgents();
            ViewBag.Agencies = _agencyRepository.GetAllAgencies();
            ViewBag.Countries = _countryRepository.GetAllCountries();
            Property abs = _PropertyRepository.GetPropertyById(id);
            if (abs == null) return NotFound();
            return View(abs);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Property abs)
        {
            if (ModelState.IsValid)
            {
                abs.ModifiedBy = _admin.Fullname;
                Property PropertyToUpdate = _PropertyRepository.GetPropertyById(abs.Id);
                if (PropertyToUpdate == null) return NotFound();
                _PropertyRepository.UpdateProperty(PropertyToUpdate, abs);
                return RedirectToAction("index");
            }
            return View(abs);
        }
        public IActionResult Delete(int id)
        {
            Property abs = _PropertyRepository.GetPropertyById(id);
            if (abs == null) return NotFound();
            _PropertyRepository.DeleteProperty(abs);
            return RedirectToAction("index");
        }
    }
}
