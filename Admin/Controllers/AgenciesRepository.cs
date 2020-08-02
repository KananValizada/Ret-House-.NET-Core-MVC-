using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Admin.Filters;
using Microsoft.AspNetCore.Mvc;
using Repository.Models;
using Repository.Repositories.AdminPagesCrud;
using Repository.Repositories.AdminPagesCrud.Agency_and_Agent;

namespace Admin.Controllers
{
    [TypeFilter(typeof(Auth))]
    public class AgenciesController : Controller
    {
        private Repository.Models.Admin _admin => RouteData.Values["Admin"] as Repository.Models.Admin;
        private readonly IAgencyRepository _AgencyRepository;
        private readonly ICategoryRepository _categoryRepository;

        public AgenciesController(IAgencyRepository AgencyRepository, ICategoryRepository categoryRepository)
        {
            _AgencyRepository = AgencyRepository;
            _categoryRepository = categoryRepository;
        }
        public IActionResult Index()
        {
            var Agencies = _AgencyRepository.GetAllAgencies();
            return View(Agencies);
        }
        public IActionResult Create()
        {
            ViewBag.Category = _categoryRepository.GetAllCategories();
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Agency Agency)
        {
            if (ModelState.IsValid)
            {
                Agency.CreatedBy = _admin.Fullname;
                _AgencyRepository.CreateAgency(Agency);
                return RedirectToAction("index");
            }
            return View(Agency);
        }
        public IActionResult Edit(int id)
        {
            ViewBag.Category = _categoryRepository.GetAllCategories();
            Agency abs = _AgencyRepository.GetAgencyById(id);
            if (abs == null) return NotFound();
            return View(abs);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Agency abs)
        {
            if (ModelState.IsValid)
            {
                abs.ModifiedBy = _admin.Fullname;
                Agency AgencyToUpdate = _AgencyRepository.GetAgencyById(abs.Id);
                if (AgencyToUpdate == null) return NotFound();
                _AgencyRepository.UpdateAgency(AgencyToUpdate, abs);
                return RedirectToAction("index");
            }
            return Ok(abs);
        }
        public IActionResult Delete(int id)
        {
            Agency abs = _AgencyRepository.GetAgencyById(id);
            if (abs == null) return NotFound();
            _AgencyRepository.DeleteAgency(abs);
            return RedirectToAction("index");
        }
    }
}
