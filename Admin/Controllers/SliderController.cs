using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Admin.Filters;
using Microsoft.AspNetCore.Mvc;
using Repository.Models;
using Repository.Repositories.AdminPagesCrud;

namespace Admin.Controllers
{
    [TypeFilter(typeof(Auth))]
    public class SliderController : Controller
    {
        private Repository.Models.Admin _admin => RouteData.Values["Admin"] as Repository.Models.Admin;
        private readonly ISliderItemRepository _SliderRepository;

        public SliderController(ISliderItemRepository SliderRepository)
        {
            _SliderRepository = SliderRepository;
        }
        public IActionResult Index()
        {
            var Slider = _SliderRepository.GetAllSliderItem();
            return View(Slider);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(SliderItem Slider)
        {
            if (ModelState.IsValid)
            {
                Slider.CreatedBy = _admin.Fullname;
                _SliderRepository.CreateSliderItem(Slider);
                return RedirectToAction("index");
            }
            return View(Slider);
        }
        public IActionResult Edit(int id)
        {
            SliderItem abs = _SliderRepository.GetSliderItemById(id);
            if (abs == null) return NotFound();
            return View(abs);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(SliderItem abs)
        {
            if (ModelState.IsValid)
            {
                abs.ModifiedBy = _admin.Fullname;
                SliderItem SliderToUpdate = _SliderRepository.GetSliderItemById(abs.Id);
                if (SliderToUpdate == null) return NotFound();
                _SliderRepository.UpdateSliderItem(SliderToUpdate, abs);
                return RedirectToAction("index");
            }
            return View(abs);
        }
        public IActionResult Delete(int id)
        {
            SliderItem abs = _SliderRepository.GetSliderItemById(id);
            if (abs == null) return NotFound();
            _SliderRepository.DeleteSliderItem(abs);
            return RedirectToAction("index");
        }
    }
}
