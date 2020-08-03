using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Admin.Filters;
using Microsoft.AspNetCore.Mvc;
using Repository.Models;
using Repository.Repositories.AdminPagesCrud.Agency_and_Agent;

namespace Admin.Controllers
{
    [TypeFilter(typeof(Auth))]
    public class AgentReviewsController : Controller
    {
        private Repository.Models.Admin _admin => RouteData.Values["Admin"] as Repository.Models.Admin;
        private readonly IAgentRepository _AgentRepository;
        private readonly IAgentReviewRepository _AgentReview;

        public AgentReviewsController(IAgentRepository AgentRepository, IAgentReviewRepository AgentReview)
        {
            _AgentRepository = AgentRepository;
            _AgentReview = AgentReview;
        }
        public IActionResult Index()
        {
            var AgentReviews = _AgentReview.GetAllAgentReviews();
            return View(AgentReviews);
        }
        public IActionResult Create()
        {
            ViewBag.Agents = _AgentRepository.GetAllAgents();
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(AgentReview AgentReview)
        {
            if (ModelState.IsValid)
            {
                AgentReview.CreatedBy = _admin.Fullname;
                _AgentReview.CreateAgentReview(AgentReview);
                return RedirectToAction("index");
            }
            return View(AgentReview);
        }
        public IActionResult Edit(int id)
        {
            ViewBag.Agents = _AgentRepository.GetAllAgents();
            AgentReview abs = _AgentReview.GetAgentReviewById(id);
            if (abs == null) return NotFound();
            return View(abs);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(AgentReview abs)
        {
            if (ModelState.IsValid)
            {
                abs.ModifiedBy = _admin.Fullname;
                AgentReview AgentToUpdate = _AgentReview.GetAgentReviewById(abs.Id);
                if (AgentToUpdate == null) return NotFound();
                _AgentReview.UpdateAgentReview(AgentToUpdate, abs);
                return RedirectToAction("index");
            }
            return View(abs);
        }
        public IActionResult Delete(int id)
        {
            AgentReview abs = _AgentReview.GetAgentReviewById(id);
            if (abs == null) return NotFound();
            _AgentReview.DeleteAgentReview(abs);
            return RedirectToAction("index");
        }
    }
}
