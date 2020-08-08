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
    public class PropertyFloorsController : Controller
    {
        private Repository.Models.Admin _admin => RouteData.Values["Admin"] as Repository.Models.Admin;
        private readonly IPropFloorRepository _PropFloorRepository;
        private readonly IPropertyRepository _propertyRepository;

        public PropertyFloorsController(IPropFloorRepository PropFloorRepository,
                                          IPropertyRepository propertyRepository)
        {
            _PropFloorRepository = PropFloorRepository;
            _propertyRepository = propertyRepository;
        }
        public IActionResult Index()
        {
            var PropFloor = _PropFloorRepository.GetAllPropFloors();
            return View(PropFloor);
        }
        public IActionResult Create()
        {
            ViewBag.Properties = _propertyRepository.GetAllProperties();
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(PropFloor PropFloor)
        {
            if (ModelState.IsValid)
            {
                PropFloor.CreatedBy = _admin.Fullname;
                _PropFloorRepository.CreatePropFloor(PropFloor);
                return RedirectToAction("index");
            }
            ViewBag.Properties = _propertyRepository.GetAllProperties();
            return View(PropFloor);
        }
        public IActionResult Edit(int id)
        {
            ViewBag.Properties = _propertyRepository.GetAllProperties();
            PropFloor abs = _PropFloorRepository.GetPropFloorById(id);
            if (abs == null) return NotFound();
            return View(abs);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(PropFloor abs)
        {
            if (ModelState.IsValid)
            {
                abs.ModifiedBy = _admin.Fullname;
                PropFloor PropFloorToUpdate = _PropFloorRepository.GetPropFloorById(abs.Id);
                if (PropFloorToUpdate == null) return NotFound();
                _PropFloorRepository.UpdatePropFloor(PropFloorToUpdate, abs);
                return RedirectToAction("index");
            }
            ViewBag.Properties = _propertyRepository.GetAllProperties();
            return View(abs);
        }
        public IActionResult Delete(int id)
        {
            PropFloor abs = _PropFloorRepository.GetPropFloorById(id);
            if (abs == null) return NotFound();
            _PropFloorRepository.DeletePropFloor(abs);
            return RedirectToAction("index");
        }
    }
}
