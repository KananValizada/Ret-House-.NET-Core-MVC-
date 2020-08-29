using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Admin.Filters;
using Microsoft.AspNetCore.Mvc;
using Repository.Repositories.AdminPagesCrud;
using Repository.Repositories.AdminPagesCrud.Agency_and_Agent;
using Repository.Repositories.AdminPagesCrud.Properties;

namespace Admin.Controllers
{
    [TypeFilter(typeof(Auth))]
    public class DashboardController : Controller
    {
        private Repository.Models.Admin _admin => RouteData.Values["Admin"] as Repository.Models.Admin;
        private readonly ICategoryRepository _categoryRepository;
        private readonly IAgencyRepository _agencyRepository;
        private readonly IAgentRepository _agentRepository;
        private readonly IPropertyRepository _propertyRepository;

        public DashboardController(ICategoryRepository categoryRepository,
                                   IAgencyRepository agencyRepository,
                                   IAgentRepository agentRepository,
                                   IPropertyRepository propertyRepository)
        {
            _categoryRepository = categoryRepository;
            _agentRepository = agentRepository;
            _agencyRepository = agencyRepository;
            _propertyRepository = propertyRepository;
        }
        public IActionResult Index()
        {
            ViewBag.AdminName = _admin.Fullname;
            ViewBag.categoryCount = _categoryRepository.GetAllCategories().Count();
            ViewBag.agencyCount = _agencyRepository.GetAllAgencies().Count();
            ViewBag.agentCount = _agentRepository.GetAllAgents().Count();
            ViewBag.propertyCount = _propertyRepository.GetAllProperties().Count();
            return View();
        }
    }
}
