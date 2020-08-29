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
    public class PropertyFeaturesController : Controller
    {
        private Repository.Models.Admin _admin => RouteData.Values["Admin"] as Repository.Models.Admin;
        private readonly IPropFeatureRepository _PropFeatureRepository;
        private readonly IPropertyRepository _propertyRepository;

        public PropertyFeaturesController(IPropFeatureRepository PropFeatureRepository,
                                          IPropertyRepository propertyRepository)
        {
            _PropFeatureRepository = PropFeatureRepository;
            _propertyRepository = propertyRepository;
        }
        public IActionResult Index()
        {
            var PropFeature = _PropFeatureRepository.GetAllPropFeatures();
            return View(PropFeature);
        }
        public IActionResult Create()
        {
            ViewBag.Properties = _propertyRepository.GetAllProperties();
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(PropFeature PropFeature)
        {
            if (ModelState.IsValid)
            {
                _PropFeatureRepository.CreatePropFeature(PropFeature);
                return RedirectToAction("index");
            }
            return View(PropFeature);
        }
        public IActionResult Edit(int id)
        {
            ViewBag.Properties = _propertyRepository.GetAllProperties();
            PropFeature abs = _PropFeatureRepository.GetPropFeatureById(id);
            if (abs == null) return NotFound();
            return View(abs);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(PropFeature abs)
        {
            if (ModelState.IsValid)
            {
                
                PropFeature PropFeatureToUpdate = _PropFeatureRepository.GetPropFeatureById(abs.Id);
                if (PropFeatureToUpdate == null) return NotFound();
                _PropFeatureRepository.UpdatePropFeature(PropFeatureToUpdate, abs);
                return RedirectToAction("index");
            }
            return View(abs);
        }
        public IActionResult Delete(int id)
        {
            PropFeature abs = _PropFeatureRepository.GetPropFeatureById(id);
            if (abs == null) return NotFound();
            _PropFeatureRepository.DeletePropFeature(abs);
            return RedirectToAction("index");
        }
    }
}
