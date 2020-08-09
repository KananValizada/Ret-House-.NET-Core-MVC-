using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Repository.Models;
using Repository.Repositories.AdminPagesCrud.Agency_and_Agent;
using Repository.Repositories.MainPage;
using Repository.Repositories.Pages;
using System;
using System.ComponentModel;

namespace RetHouse_Final.Controllers
{
    public class AgencyController : Controller
    {
        private readonly Repository.Repositories.Pages.IAgencyRepository _agencyRepository;
        private readonly IMainRepository _mainRepository;
        private readonly IAgencyReviewRepository _agencyReviewRepository;
        private  int _catId;
        public AgencyController(Repository.Repositories.Pages.IAgencyRepository agencyRepository, 
                                IMainRepository mainRepository ,
                                IAgencyReviewRepository agencyReviewRepository)
        {
            _agencyRepository = agencyRepository;
            _mainRepository = mainRepository;
            _agencyReviewRepository = agencyReviewRepository;
        }
        public IActionResult Index()
        {
            var model = _mainRepository.GetCategories();
            return View(model);
        }
        public IActionResult SingleAgency(int id,int agencyId)
        {
            _catId = id;
            var model = _mainRepository.GetCategoryById(id);
            ViewBag.AgencyId = agencyId;
            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult SingleAgency(Category catgory)
        {
            AgencyReview model = new AgencyReview
            {
                CreatedBy = catgory.CreatedBy,
                Status = true,
                Star = (byte)catgory.Id,
                Name = catgory.CreatedBy,
                Comment = catgory.Name,
                AgencyId = Int32.Parse(catgory.ModifiedBy)
            };
            var routevaule = new
            {
                id = catgory.catId,
                agencyId = Int32.Parse(catgory.ModifiedBy)
            };

            if (ModelState.IsValid)
            {
                _agencyReviewRepository.CreateAgencyReview(model);
                return RedirectToAction("singleagency", "agency", routevaule);

            }
            return RedirectToAction("singleagency", "agency", routevaule);
        }
    }
}
