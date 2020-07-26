using Microsoft.AspNetCore.Mvc;
using Repository.Repositories.MainPage;

namespace RetHouse_Final.Controllers
{
    public class AgentController : Controller
    {
        private readonly IMainRepository _mainRepository;
        public AgentController(IMainRepository mainRepository)
        {
            _mainRepository = mainRepository; 
        }
        public IActionResult Index()
        {
            var model = _mainRepository.GetCategories();
            return View(model);
        }
        public IActionResult SingleAgent(int id,int agentId)
        {
            var model = _mainRepository.GetCategoryById(id);
            ViewBag.AgentId = agentId;
            return View(model);
        }
    }
}
