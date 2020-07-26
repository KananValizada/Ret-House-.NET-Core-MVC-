using Microsoft.AspNetCore.Mvc;
using Repository.Repositories.MainPage;
using Repository.Repositories.Pages;

namespace RetHouse_Final.Controllers
{
    public class AgencyController : Controller
    {
        private readonly IAgencyRepository _agencyRepository;
        private readonly IMainRepository _mainRepository;
        public AgencyController(IAgencyRepository agencyRepository, IMainRepository mainRepository)
        {
            _agencyRepository = agencyRepository;
            _mainRepository = mainRepository;
        }
        public IActionResult Index()
        {
            var model = _mainRepository.GetCategories();
            return View(model);
        }
        public IActionResult SingleAgency(int id,int agencyId)
        {
            var model = _mainRepository.GetCategoryById(id);
            ViewBag.AgencyId = agencyId;
            return View(model);
        }
    }
}
