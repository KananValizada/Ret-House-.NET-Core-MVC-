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
    public class BlogTagRelateController : Controller
    {
        private Repository.Models.Admin _admin => RouteData.Values["Admin"] as Repository.Models.Admin;
        private readonly IBlogTagRelateRepository _BlogTagRelateRepository;

        public BlogTagRelateController(IBlogTagRelateRepository BlogTagRelateRepository)
        {
            _BlogTagRelateRepository = BlogTagRelateRepository;
        }
        public IActionResult Index()
        {
            var BlogTagRelate = _BlogTagRelateRepository.GetAllBlogTagRelates();
            return View(BlogTagRelate);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(BlogTagRelate BlogTagRelate)
        {
            if (ModelState.IsValid)
            {
                _BlogTagRelateRepository.CreateBlogTagRelate(BlogTagRelate);
                return RedirectToAction("index");
            }
            return View(BlogTagRelate);
        }
        public IActionResult Edit(int id)
        {
            BlogTagRelate abs = _BlogTagRelateRepository.GetBlogTagRelateById(id);
            if (abs == null) return NotFound();
            return View(abs);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(BlogTagRelate abs)
        {
            if (ModelState.IsValid)
            {
                BlogTagRelate BlogTagRelateToUpdate = _BlogTagRelateRepository.GetBlogTagRelateById(abs.Id);
                if (BlogTagRelateToUpdate == null) return NotFound();
                _BlogTagRelateRepository.UpdateBlogTagRelate(BlogTagRelateToUpdate, abs);
                return RedirectToAction("index");
            }
            return Ok(abs);
        }
        public IActionResult Delete(int id)
        {
            BlogTagRelate abs = _BlogTagRelateRepository.GetBlogTagRelateById(id);
            if (abs == null) return NotFound();
            _BlogTagRelateRepository.DeleteBlogTagRelate(abs);
            return RedirectToAction("index");
        }
    }
}
