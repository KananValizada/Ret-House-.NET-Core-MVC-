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
    public class AboutUsController : Controller
    {
        private Repository.Models.Admin _admin => RouteData.Values["Admin"] as Repository.Models.Admin;
        private readonly IAboutUsRepository _AboutUsRepository;

        public AboutUsController(IAboutUsRepository AboutUsRepository)
        {
            _AboutUsRepository = AboutUsRepository;
        }
        public IActionResult Index()
        {
            var AboutUs = _AboutUsRepository.GetAllAboutUs();
            return View(AboutUs);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(AboutUs AboutUs)
        {
            if (ModelState.IsValid)
            {
                AboutUs.CreatedBy = _admin.Fullname;
                _AboutUsRepository.CreateAboutUs(AboutUs);
                return RedirectToAction("index");
            }
            return View(AboutUs);
        }
        public IActionResult Edit(int id)
        {
            AboutUs abs = _AboutUsRepository.GetAboutUsById(id);
            if (abs == null) return NotFound();
            return View(abs);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(AboutUs abs)
        {
            if (ModelState.IsValid)
            {
                abs.ModifiedBy = _admin.Fullname;
                AboutUs AboutUsToUpdate = _AboutUsRepository.GetAboutUsById(abs.Id);
                if (AboutUsToUpdate == null) return NotFound();
                _AboutUsRepository.UpdateAboutUs(AboutUsToUpdate, abs);
                return RedirectToAction("index");
            }
            return View(abs);
        }
        public IActionResult Delete(int id)
        {
            AboutUs abs = _AboutUsRepository.GetAboutUsById(id);
            if (abs == null) return NotFound();
            _AboutUsRepository.DeleteAboutUs(abs);
            return RedirectToAction("index");
        }
    }
}
