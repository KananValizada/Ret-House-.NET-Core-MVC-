using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Admin.Filters;
using Microsoft.AspNetCore.Mvc;
using Repository.Models;
using Repository.Repositories.AdminPagesCrud.PropDetails;
using Repository.Repositories.AdminPagesCrud.Properties;

namespace Admin.Controllers
{
    [TypeFilter(typeof(Auth))]
    public class PropertyDetailsController : Controller
    {
        private Repository.Models.Admin _admin => RouteData.Values["Admin"] as Repository.Models.Admin;
        private readonly IPropDetailRepository _PropDetailRepository;
        private readonly IPropertyRepository _propertyRepository;

        public PropertyDetailsController(IPropDetailRepository PropDetailRepository,
                                          IPropertyRepository propertyRepository)
        {
            _PropDetailRepository = PropDetailRepository;
            _propertyRepository = propertyRepository;
        }
        public IActionResult Index()
        {
            var PropDetail = _PropDetailRepository.GetAllPropDetails();
            return View(PropDetail);
        }
        public IActionResult Create()
        {
            ViewBag.Properties = _propertyRepository.GetAllProperties();
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(PropDetail PropDetail)
        {
            if (ModelState.IsValid)
            {
                _PropDetailRepository.CreatePropDetail(PropDetail);
                return RedirectToAction("index");
            }
            return View(PropDetail);
        }
        public IActionResult Edit(int id)
        {
            ViewBag.Properties = _propertyRepository.GetAllProperties();
            PropDetail abs = _PropDetailRepository.GetPropDetailById(id);
            if (abs == null) return NotFound();
            return View(abs);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(PropDetail abs)
        {
            if (ModelState.IsValid)
            {

                PropDetail PropDetailToUpdate = _PropDetailRepository.GetPropDetailById(abs.Id);
                if (PropDetailToUpdate == null) return NotFound();
                _PropDetailRepository.UpdatePropDetail(PropDetailToUpdate, abs);
                return RedirectToAction("index");
            }
            return View(abs);
        }
        public IActionResult Delete(int id)
        {
            PropDetail abs = _PropDetailRepository.GetPropDetailById(id);
            if (abs == null) return NotFound();
            _PropDetailRepository.DeletePropDetail(abs);
            return RedirectToAction("index");
        }
    }
}
