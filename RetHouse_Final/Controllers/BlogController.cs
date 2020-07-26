using Microsoft.AspNetCore.Mvc;
using Repository.Repositories.Pages;

namespace RetHouse_Final.Controllers
{
    public class BlogController : Controller
    {
        private readonly IBlogRepository _blogRepository;
        public BlogController(IBlogRepository blogRepository)
        {
            _blogRepository = blogRepository;
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
    }
}
