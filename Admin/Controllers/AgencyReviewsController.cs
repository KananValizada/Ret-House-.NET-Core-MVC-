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
    public class AgencyReviewsController : Controller
    {
        private Repository.Models.Admin _admin => RouteData.Values["Admin"] as Repository.Models.Admin;
        private readonly IAgencyRepository _AgencyRepository;
        private readonly IAgencyReviewRepository _agencyReview;

        public AgencyReviewsController(IAgencyRepository AgencyRepository, IAgencyReviewRepository agencyReview)
        {
            _AgencyRepository = AgencyRepository;
            _agencyReview = agencyReview;
        }
        public IActionResult Index()
        {
            var AgencyReviews = _agencyReview.GetAllAgencyReviews();
            return View(AgencyReviews);
        }
        public IActionResult Create()
        {
            ViewBag.Agencies = _AgencyRepository.GetAllAgencies();
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(AgencyReview AgencyReview)
        {
            if (ModelState.IsValid)
            {
                AgencyReview.CreatedBy = _admin.Fullname;
                _agencyReview.CreateAgencyReview(AgencyReview);
                return RedirectToAction("index");
            }
            return View(AgencyReview);
        }
        public IActionResult Edit(int id)
        {
            ViewBag.Agencies = _AgencyRepository.GetAllAgencies();
            AgencyReview abs = _agencyReview.GetAgencyReviewById(id);
            if (abs == null) return NotFound();
            return View(abs);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(AgencyReview abs)
        {
            if (ModelState.IsValid)
            {
                abs.ModifiedBy = _admin.Fullname;
                AgencyReview AgencyToUpdate = _agencyReview.GetAgencyReviewById(abs.Id);
                if (AgencyToUpdate == null) return NotFound();
                _agencyReview.UpdateAgencyReview(AgencyToUpdate, abs);
                return RedirectToAction("index");
            }
            return View(abs);
        }
        public IActionResult Delete(int id)
        {
            AgencyReview abs = _agencyReview.GetAgencyReviewById(id);
            if (abs == null) return NotFound();
            _agencyReview.DeleteAgencyReview(abs);
            return RedirectToAction("index");
        }
    }
}
