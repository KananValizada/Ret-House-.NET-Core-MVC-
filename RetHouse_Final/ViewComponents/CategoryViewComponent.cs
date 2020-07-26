using Microsoft.AspNetCore.Mvc;
using Repository.Repositories.MainPage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RetHouse_Final.ViewComponents
{
    public class CategoryViewComponent : ViewComponent
    {
        private readonly IMainRepository _categoryRepository;
        public CategoryViewComponent(IMainRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }
        public IViewComponentResult Invoke()
        {
            var category = _categoryRepository.GetCategories();

            return View(category);
        }
    }
}
