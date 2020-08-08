using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Admin.Filters;
using Microsoft.AspNetCore.Mvc;
using Repository.Models;
using Repository.Repositories.AdminPagesCrud.Properties;

namespace Admin.Controllers
{
    [TypeFilter(typeof(Auth))]
    public class PropertyReviewsController : Controller
    {
        private Repository.Models.Admin _admin => RouteData.Values["Admin"] as Repository.Models.Admin;
        private readonly IPropertyRepository _PropertyRepository;
        private readonly IPropertyReviewRepository _PropertyReview;

        public PropertyReviewsController(IPropertyRepository PropertyRepository, IPropertyReviewRepository PropertyReview)
        {
            _PropertyRepository = PropertyRepository;
            _PropertyReview = PropertyReview;
        }
        public IActionResult Index()
        {
            var PropertyReviews = _PropertyReview.GetAllPropertyReviews();
            return View(PropertyReviews);
        }
        public IActionResult Create()
        {
            ViewBag.Properties = _PropertyRepository.GetAllProperties();
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(PropertyReview PropertyReview)
        {
            if (ModelState.IsValid)
            {
                PropertyReview.CreatedBy = _admin.Fullname;
                _PropertyReview.CreatePropertyReview(PropertyReview);
                return RedirectToAction("index");
            }
            return View(PropertyReview);
        }
        public IActionResult Edit(int id)
        {
            ViewBag.Properties = _PropertyRepository.GetAllProperties();
            PropertyReview abs = _PropertyReview.GetPropertyReviewById(id);
            if (abs == null) return NotFound();
            return View(abs);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(PropertyReview abs)
        {
            if (ModelState.IsValid)
            {
                abs.ModifiedBy = _admin.Fullname;
                PropertyReview PropertyToUpdate = _PropertyReview.GetPropertyReviewById(abs.Id);
                if (PropertyToUpdate == null) return NotFound();
                _PropertyReview.UpdatePropertyReview(PropertyToUpdate, abs);
                return RedirectToAction("index");
            }
            return View(abs);
        }
        public IActionResult Delete(int id)
        {
            PropertyReview abs = _PropertyReview.GetPropertyReviewById(id);
            if (abs == null) return NotFound();
            _PropertyReview.DeletePropertyReview(abs);
            return RedirectToAction("index");
        }
    }
}
