using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Admin.Filters;
using Microsoft.AspNetCore.Mvc;
using Repository.Models;
using Repository.Repositories.AdminPagesCrud.Blogs;

namespace Admin.Controllers
{
    [TypeFilter(typeof(Auth))]
    public class BlogPhaseController : Controller
    {
        private Repository.Models.Admin _admin => RouteData.Values["Admin"] as Repository.Models.Admin;
        private readonly IBlogPhaseRepository _BlogPhaseRepository;

        public BlogPhaseController(IBlogPhaseRepository BlogPhaseRepository)
        {
            _BlogPhaseRepository = BlogPhaseRepository;
        }
        public IActionResult Index()
        {
            var BlogPhase = _BlogPhaseRepository.GetAllBlogPhases();
            return View(BlogPhase);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(BlogPhase BlogPhase)
        {
            if (ModelState.IsValid)
            {
                BlogPhase.CreatedBy = _admin.Fullname;
                _BlogPhaseRepository.CreateBlogPhase(BlogPhase);
                return RedirectToAction("index");
            }
            return View(BlogPhase);
        }
        public IActionResult Edit(int id)
        {
            BlogPhase abs = _BlogPhaseRepository.GetBlogPhaseById(id);
            if (abs == null) return NotFound();
            return View(abs);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(BlogPhase abs)
        {
            if (ModelState.IsValid)
            {
                abs.ModifiedBy = _admin.Fullname;
                BlogPhase BlogPhaseToUpdate = _BlogPhaseRepository.GetBlogPhaseById(abs.Id);
                if (BlogPhaseToUpdate == null) return NotFound();
                _BlogPhaseRepository.UpdateBlogPhase(BlogPhaseToUpdate, abs);
                return RedirectToAction("index");
            }
            return Ok(abs);
        }
        public IActionResult Delete(int id)
        {
            BlogPhase abs = _BlogPhaseRepository.GetBlogPhaseById(id);
            if (abs == null) return NotFound();
            _BlogPhaseRepository.DeleteBlogPhase(abs);
            return RedirectToAction("index");
        }
    }
}
