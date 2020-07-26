using Microsoft.AspNetCore.Mvc;
using Repository.Repositories.MainPage;

namespace RetHouse_Final.Controllers
{
    public class PropertyController : Controller
    {
        private readonly IMainRepository _mainRepository;
        public PropertyController (IMainRepository mainRepository)
        {
            _mainRepository = mainRepository; 
        }
        public IActionResult Index()
        {
            var model = _mainRepository.GetCategories();
            return View(model);
        }
        public IActionResult SingleProduct(int id,int agentId,int propId) 
        {
            var model = _mainRepository.GetCategoryById(id);
            ViewBag.AgentId = agentId;
            ViewBag.PropId = propId;
            return View(model);
        }
    }
}
