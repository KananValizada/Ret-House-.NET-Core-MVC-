using Microsoft.AspNetCore.Mvc;
using Repository.Models;
using Repository.Repositories.AdminPagesCrud.Agency_and_Agent;
using Repository.Repositories.MainPage;
using System;

namespace RetHouse_Final.Controllers
{
    public class AgentController : Controller
    {
        private readonly IAgentRepository _agentRepository;
        private readonly IMainRepository _mainRepository;
        private readonly IAgentReviewRepository _agentReviewRepository;
        private int _catId; 
        public AgentController(IMainRepository mainRepository,
                               IAgentRepository agentRepository,
                               IAgentReviewRepository agentReviewRepository
                               )
        {
            _agentRepository = agentRepository;
            _mainRepository = mainRepository;
            _agentReviewRepository = agentReviewRepository;
        }
        public IActionResult Index()
        {
            var model = _mainRepository.GetCategories();
            return View(model);
        }
        public IActionResult SingleAgent(int id,int agentId)
        {
            _catId = id;
            var model = _mainRepository.GetCategoryById(id);
            ViewBag.AgentId = agentId;
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult SingleAgent(Category catgory)
        {
            AgentReview model = new AgentReview
            {
                CreatedBy = catgory.CreatedBy,
                Status = true,
                Star = (byte)catgory.Id,
                Name = catgory.CreatedBy,
                Comment = catgory.Name,
                AgentId = Int32.Parse(catgory.ModifiedBy)
            };
            var routevaule = new
            {
                id = catgory.catId,
                agentId = Int32.Parse(catgory.ModifiedBy)
            };

            if (ModelState.IsValid)
            {
                _agentReviewRepository.CreateAgentReview(model);
                return RedirectToAction("singleagent", "agent", routevaule);

            }
            return RedirectToAction("singleagent", "agent", routevaule);
        }
    }
}
