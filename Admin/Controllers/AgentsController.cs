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
    public class AgentsController : Controller
    {
        private Repository.Models.Admin _admin => RouteData.Values["Admin"] as Repository.Models.Admin;
        private readonly IAgentRepository _AgentRepository;
        private readonly ICategoryRepository _categoryRepository;
        private readonly ICityRepository _cityRepository;
        private readonly IAgencyRepository _agencyRepository;

        public AgentsController(IAgentRepository AgentRepository, 
                                ICategoryRepository categoryRepository,
                                ICityRepository cityRepository,
                                IAgencyRepository agencyRepository)
        {
            _AgentRepository = AgentRepository;
            _categoryRepository = categoryRepository;
            _cityRepository = cityRepository;
            _agencyRepository = agencyRepository;
        }
        public IActionResult Index()
        {
            var Agents = _AgentRepository.GetAllAgents();
            return View(Agents);
        }
        public IActionResult Create()
        {
            ViewBag.Category = _categoryRepository.GetAllCategories();
            ViewBag.Agencies = _agencyRepository.GetAllAgencies();
            ViewBag.Cities = _cityRepository.GetAllCities();
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Agent Agent)
        {
            if (ModelState.IsValid)
            {
                Agent.CreatedBy = _admin.Fullname;
                _AgentRepository.CreateAgent(Agent);
                return RedirectToAction("index");
            }
            return View(Agent);
        }
        public IActionResult Edit(int id)
        {
            ViewBag.Category = _categoryRepository.GetAllCategories();
            ViewBag.Agencies = _agencyRepository.GetAllAgencies();
            ViewBag.Cities = _cityRepository.GetAllCities();
            Agent abs = _AgentRepository.GetAgentById(id);
            if (abs == null) return NotFound();
            return View(abs);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Agent abs)
        {
            if (ModelState.IsValid)
            {
                abs.ModifiedBy = _admin.Fullname;
                Agent AgentToUpdate = _AgentRepository.GetAgentById(abs.Id);
                if (AgentToUpdate == null) return NotFound();
                _AgentRepository.UpdateAgent(AgentToUpdate, abs);
                return RedirectToAction("index");
            }
            return Ok(abs);
        }
        public IActionResult Delete(int id)
        {
            Agent abs = _AgentRepository.GetAgentById(id);
            if (abs == null) return NotFound();
            _AgentRepository.DeleteAgent(abs);
            return RedirectToAction("index");
        }
    }
}
