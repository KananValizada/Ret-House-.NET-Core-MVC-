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
        private readonly IBlogRepository _blogRepository;
        private readonly IBlogTagRepository _blogTagRepository;

        public BlogTagRelateController(IBlogTagRelateRepository BlogTagRelateRepository, 
                                       IBlogRepository blogRepository,
                                       IBlogTagRepository blogTagRepository)
        {
            _BlogTagRelateRepository = BlogTagRelateRepository;
            _blogRepository = blogRepository;
            _blogTagRepository = blogTagRepository;
        }
        public IActionResult Index()
        {
            var BlogTagRelate = _BlogTagRelateRepository.GetAllBlogTagRelates();
            return View(BlogTagRelate);
        }
        public IActionResult Create()
        {
            ViewBag.Blogs = _blogRepository.GetAllBlogs();
            ViewBag.BlogTags = _blogTagRepository.GetAllBlogTags();
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
            ViewBag.Blogs = _blogRepository.GetAllBlogs();
            ViewBag.BlogTags = _blogTagRepository.GetAllBlogTags();
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
            return View(abs);
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
