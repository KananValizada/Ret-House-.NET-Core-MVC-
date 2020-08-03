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
    public class BlogTagController : Controller
    {
        private Repository.Models.Admin _admin => RouteData.Values["Admin"] as Repository.Models.Admin;
        private readonly IBlogTagRepository _BlogTagRepository;

        public BlogTagController(IBlogTagRepository BlogTagRepository)
        {
            _BlogTagRepository = BlogTagRepository;
        }
        public IActionResult Index()
        {
            var BlogTag = _BlogTagRepository.GetAllBlogTags();
            return View(BlogTag);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(BlogTag BlogTag)
        {
            if (ModelState.IsValid)
            {
                BlogTag.CreatedBy = _admin.Fullname;
                _BlogTagRepository.CreateBlogTag(BlogTag);
                return RedirectToAction("index");
            }
            return View(BlogTag);
        }
        public IActionResult Edit(int id)
        {
            BlogTag abs = _BlogTagRepository.GetBlogTagById(id);
            if (abs == null) return NotFound();
            return View(abs);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(BlogTag abs)
        {
            if (ModelState.IsValid)
            {
                abs.ModifiedBy = _admin.Fullname;
                BlogTag BlogTagToUpdate = _BlogTagRepository.GetBlogTagById(abs.Id);
                if (BlogTagToUpdate == null) return NotFound();
                _BlogTagRepository.UpdateBlogTag(BlogTagToUpdate, abs);
                return RedirectToAction("index");
            }
            return Ok(abs);
        }
        public IActionResult Delete(int id)
        {
            BlogTag abs = _BlogTagRepository.GetBlogTagById(id);
            if (abs == null) return NotFound();
            _BlogTagRepository.DeleteBlogTag(abs);
            return RedirectToAction("index");
        }
    }
}
