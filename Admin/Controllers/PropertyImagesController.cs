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
    public class PropertyImagesController : Controller
    {
        private Repository.Models.Admin _admin => RouteData.Values["Admin"] as Repository.Models.Admin;
        private readonly IPropImageRepository _PropImageRepository;
        private readonly IPropertyRepository _propertyRepository;

        public PropertyImagesController(IPropImageRepository PropImageRepository,
                                          IPropertyRepository propertyRepository)
        {
            _PropImageRepository = PropImageRepository;
            _propertyRepository = propertyRepository;
        }
        public IActionResult Index()
        {
            var PropImage = _PropImageRepository.GetAllPropImages();
            return View(PropImage);
        }
        public IActionResult Create()
        {
            ViewBag.Properties = _propertyRepository.GetAllProperties();
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(PropImage PropImage)
        {
            if (ModelState.IsValid)
            {
                PropImage.CreatedBy = _admin.Fullname;
                _PropImageRepository.CreatePropImage(PropImage);
                return RedirectToAction("index");
            }
            return View(PropImage);
        }
        public IActionResult Edit(int id)
        {
            ViewBag.Properties = _propertyRepository.GetAllProperties();
            PropImage abs = _PropImageRepository.GetPropImageById(id);
            if (abs == null) return NotFound();
            return View(abs);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(PropImage abs)
        {
            if (ModelState.IsValid)
            {
                abs.ModifiedBy = _admin.Fullname;
                PropImage PropImageToUpdate = _PropImageRepository.GetPropImageById(abs.Id);
                if (PropImageToUpdate == null) return NotFound();
                _PropImageRepository.UpdatePropImage(PropImageToUpdate, abs);
                return RedirectToAction("index");
            }
            ViewBag.Properties = _propertyRepository.GetAllProperties();
            return View(abs);
        }
        public IActionResult Delete(int id)
        {
            PropImage abs = _PropImageRepository.GetPropImageById(id);
            if (abs == null) return NotFound();
            _PropImageRepository.DeletePropImage(abs);
            return RedirectToAction("index");
        }
    }
}
