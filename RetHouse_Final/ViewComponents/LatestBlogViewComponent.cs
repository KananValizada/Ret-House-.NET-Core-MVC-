using Microsoft.AspNetCore.Mvc;
using Repository.Repositories.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RetHouse_Final.ViewComponents
{
    public class LatestBlogViewComponent : ViewComponent
    {
        private readonly IBlogRepository _blogRepository;
        public LatestBlogViewComponent(IBlogRepository blogRepository)
        {
            _blogRepository = blogRepository;
        }
        public IViewComponentResult Invoke()
        {
            var blog = _blogRepository.GetLatestBlogs(5);

            return View(blog);
        }
    }
}
