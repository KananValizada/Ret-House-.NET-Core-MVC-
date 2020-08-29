using Admin.Filters;
using Microsoft.AspNetCore.Mvc;
using Repository.Models;
using Repository.Repositories.AdminPagesCrud;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Admin.Controllers
{
    [TypeFilter(typeof(Auth))]
    public class PartnersController : Controller
    {
        private Repository.Models.Admin _admin => RouteData.Values["Admin"] as Repository.Models.Admin;
        private readonly IPartnerRepository _PartnerRepository;

        public PartnersController(IPartnerRepository PartnerRepository)
        {
            _PartnerRepository = PartnerRepository;
        }
        public IActionResult Index()
        {
            var Partners = _PartnerRepository.GetAllPartners();
            return View(Partners);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Partner Partner)
        {
            if (ModelState.IsValid)
            {
                Partner.CreatedBy = _admin.Fullname;
                _PartnerRepository.CreatePartner(Partner);
                return RedirectToAction("index");
            }
            return View(Partner);
        }
        public IActionResult Edit(int id)
        {
            Partner abs = _PartnerRepository.GetPartnerById(id);
            if (abs == null) return NotFound();
            return View(abs);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Partner abs)
        {
            if (ModelState.IsValid)
            {
                abs.ModifiedBy = _admin.Fullname;
                Partner PartnerToUpdate = _PartnerRepository.GetPartnerById(abs.Id);
                if (PartnerToUpdate == null) return NotFound();
                _PartnerRepository.UpdatePartner(PartnerToUpdate, abs);
                return RedirectToAction("index");
            }
            return View(abs);
        }
        public IActionResult Delete(int id)
        {
            Partner abs = _PartnerRepository.GetPartnerById(id);
            if (abs == null) return NotFound();
            _PartnerRepository.DeletePartner(abs);
            return RedirectToAction("index");
        }
    }
}
