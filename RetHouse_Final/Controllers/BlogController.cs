using Microsoft.AspNetCore.Mvc;
using Repository.Models;
using Repository.Repositories.AdminPagesCrud.Blogs;
using Repository.Repositories.Pages;
using System;

namespace RetHouse_Final.Controllers
{
    public class BlogController : Controller
    {
        private readonly IBlogReviewRepository _blogReviewRepository;
        private readonly Repository.Repositories.Pages.IBlogRepository _blogRepository;
        public BlogController(Repository.Repositories.Pages.IBlogRepository blogRepository,
                              IBlogReviewRepository blogReviewRepository)
        {
            _blogRepository = blogRepository;
            _blogReviewRepository = blogReviewRepository;
        }
        public IActionResult Index()
        {
            var model = _blogRepository.GetBlogPhases();
            return View(model);
        }
        public IActionResult BlogSingle(int Id,int BlogId)
        {
            var model = _blogRepository.GetBlogPhaseById(Id);
            ViewBag.BlogId = BlogId;
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult BlogSingle(BlogPhase blogPhase)
        {
            BlogReview model = new BlogReview
            {
                CreatedBy = blogPhase.CreatedBy,
                Status = true,
                Star = (byte)blogPhase.Id,
                Name = blogPhase.CreatedBy,
                Comment = blogPhase.Name,
                BlogId = Int32.Parse(blogPhase.ModifiedBy)
            };
            var routevaule = new
            {
                id = Int32.Parse(blogPhase.Phase),
                BlogId = Int32.Parse(blogPhase.ModifiedBy)
            };

            if (ModelState.IsValid)
            {
                _blogReviewRepository.CreateBlogReview(model);
                return RedirectToAction("blogsingle", "blog", routevaule);

            }
            return RedirectToAction("blogsingle", "blog", routevaule);
        }
    }
}
