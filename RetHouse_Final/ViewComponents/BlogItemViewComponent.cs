using Microsoft.AspNetCore.Mvc;
using Repository.Repositories.MainPage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RetHouse_Final.ViewComponents
{
    public class BlogItemViewComponent : ViewComponent
    {
        private readonly IMainRepository _mainRepository;
        public BlogItemViewComponent(IMainRepository mainRepository)
        {
            _mainRepository = mainRepository;
        }
        public IViewComponentResult Invoke()
        {
            var city = _mainRepository.GetBlogItem(3);

            return View(city);
        }
    }
}
