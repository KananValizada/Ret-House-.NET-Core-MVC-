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
    public class BlogReviewsController : Controller
    {
        private Repository.Models.Admin _admin => RouteData.Values["Admin"] as Repository.Models.Admin;
        private readonly IBlogRepository _BlogRepository;
        private readonly IBlogReviewRepository _BlogReview;

        public BlogReviewsController(IBlogRepository BlogRepository, IBlogReviewRepository BlogReview)
        {
            _BlogRepository = BlogRepository;
            _BlogReview = BlogReview;
        }
        public IActionResult Index()
        {
            var BlogReviews = _BlogReview.GetAllBlogReviews();
            return View(BlogReviews);
        }
        public IActionResult Create()
        {
            ViewBag.Blogs = _BlogRepository.GetAllBlogs();
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(BlogReview BlogReview)
        {
            if (ModelState.IsValid)
            {
                BlogReview.CreatedBy = _admin.Fullname;
                _BlogReview.CreateBlogReview(BlogReview);
                return RedirectToAction("index");
            }
            return View(BlogReview);
        }
        public IActionResult Edit(int id)
        {
            ViewBag.Blogs = _BlogRepository.GetAllBlogs();
            BlogReview abs = _BlogReview.GetBlogReviewById(id);
            if (abs == null) return NotFound();
            return View(abs);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(BlogReview abs)
        {
            if (ModelState.IsValid)
            {
                abs.ModifiedBy = _admin.Fullname;
                BlogReview BlogToUpdate = _BlogReview.GetBlogReviewById(abs.Id);
                if (BlogToUpdate == null) return NotFound();
                _BlogReview.UpdateBlogReview(BlogToUpdate, abs);
                return RedirectToAction("index");
            }
            return View(abs);
        }
        public IActionResult Delete(int id)
        {
            BlogReview abs = _BlogReview.GetBlogReviewById(id);
            if (abs == null) return NotFound();
            _BlogReview.DeleteBlogReview(abs);
            return RedirectToAction("index");
        }
    }
}
