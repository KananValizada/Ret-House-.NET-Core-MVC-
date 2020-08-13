using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Admin.Filters;
using Microsoft.AspNetCore.Mvc;
using Repository.Models;
using Repository.Repositories;

namespace Admin.Controllers
{
    [TypeFilter(typeof(Auth))]
    public class PeopleSayController : Controller
    {
        private Repository.Models.Admin _admin => RouteData.Values["Admin"] as Repository.Models.Admin;
        private readonly IPeopleSayRepository _PeopleSayRepository;

        public PeopleSayController(IPeopleSayRepository PeopleSayRepository)
        {
            _PeopleSayRepository = PeopleSayRepository;
        }
        public IActionResult Index()
        {
            var PeopleSay = _PeopleSayRepository.GetAllPeopleSay();
            return View(PeopleSay);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(PeopleSay PeopleSay)
        {
            if (ModelState.IsValid)
            {
                PeopleSay.CreatedBy = _admin.Fullname;
                _PeopleSayRepository.CreatePeopleSay(PeopleSay);
                return RedirectToAction("index");
            }
            return View(PeopleSay);
        }
        public IActionResult Edit(int id)
        {
            PeopleSay abs = _PeopleSayRepository.GetPeopleSayById(id);
            if (abs == null) return NotFound();
            return View(abs);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(PeopleSay abs)
        {
            if (ModelState.IsValid)
            {
                abs.ModifiedBy = _admin.Fullname;
                PeopleSay PeopleSayToUpdate = _PeopleSayRepository.GetPeopleSayById(abs.Id);
                if (PeopleSayToUpdate == null) return NotFound();
                _PeopleSayRepository.UpdatePeopleSay(PeopleSayToUpdate, abs);
                return RedirectToAction("index");
            }
            return View(abs);
        }
        public IActionResult Delete(int id)
        {
            PeopleSay abs = _PeopleSayRepository.GetPeopleSayById(id);
            if (abs == null) return NotFound();
            _PeopleSayRepository.DeletePeopleSay(abs);
            return RedirectToAction("index");
        }
    }
}
