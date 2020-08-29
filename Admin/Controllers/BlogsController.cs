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
    public class BlogsController : Controller
    {
        private Repository.Models.Admin _admin => RouteData.Values["Admin"] as Repository.Models.Admin;
        private readonly IBlogRepository _BlogRepository;
        private readonly IBlogPhaseRepository _blogPhaseRepository;

        public BlogsController(IBlogRepository BlogRepository, IBlogPhaseRepository blogPhaseRepository)
        {
            _BlogRepository = BlogRepository;
            _blogPhaseRepository = blogPhaseRepository;
        }
        public IActionResult Index()
        {
            var Blogs = _BlogRepository.GetAllBlogs();
            return View(Blogs);
        }
        public IActionResult Create()
        {
            ViewBag.BlogPhases = _blogPhaseRepository.GetAllBlogPhases();
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Blog Blog)
        {
            if (ModelState.IsValid)
            {
                Blog.CreatedBy = _admin.Fullname;
                _BlogRepository.CreateBlog(Blog);
                return RedirectToAction("index");
            }
            return View(Blog);
        }
        public IActionResult Edit(int id)
        {
            ViewBag.BlogPhases = _blogPhaseRepository.GetAllBlogPhases();
            Blog abs = _BlogRepository.GetBlogById(id);
            if (abs == null) return NotFound();
            return View(abs);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Blog abs)
        {
            if (ModelState.IsValid)
            {
                abs.ModifiedBy = _admin.Fullname;
                Blog BlogToUpdate = _BlogRepository.GetBlogById(abs.Id);
                if (BlogToUpdate == null) return NotFound();
                _BlogRepository.UpdateBlog(BlogToUpdate, abs);
                return RedirectToAction("index");
            }
            return View(abs);
        }
        public IActionResult Delete(int id)
        {
            Blog abs = _BlogRepository.GetBlogById(id);
            if (abs == null) return NotFound();
            _BlogRepository.DeleteBlog(abs);
            return RedirectToAction("index");
        }
    }
}
