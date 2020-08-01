using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Admin.Filters;
using Microsoft.AspNetCore.Mvc;
using Repository.Models;
using Repository.Repositories.AdminPagesCrud;

namespace Admin.Controllers
{
    [TypeFilter(typeof(Auth))]
    public class CategoriesController : Controller
    {
        private Repository.Models.Admin _admin => RouteData.Values["Admin"] as Repository.Models.Admin;
        private readonly ICategoryRepository _categoryRepository;

        public CategoriesController(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }
        public IActionResult Index()
        {
            var categories = _categoryRepository.GetAllCategories();
            return View(categories);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Category category)
        {
            if (ModelState.IsValid)
            {
                category.CreatedBy = _admin.Fullname;
                _categoryRepository.CreateCategory(category);
                return RedirectToAction("index");
            }
            return View(category);
        }
        public IActionResult Edit(int id)
        {
            Category abs = _categoryRepository.GetCategoryById(id);
            if (abs == null) return NotFound();
            return View(abs);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Category abs)
        {
            if (ModelState.IsValid)
            {
                abs.ModifiedBy = _admin.Fullname;
                Category CategoryToUpdate = _categoryRepository.GetCategoryById(abs.Id);
                if (CategoryToUpdate == null) return NotFound();
                _categoryRepository.UpdateCategory(CategoryToUpdate, abs);
                return RedirectToAction("index");
            }
            return Ok(abs);
        }
        public IActionResult Delete(int id)
        {
            Category abs = _categoryRepository.GetCategoryById(id);
            if (abs == null) return NotFound();
            _categoryRepository.DeleteCategory(abs);
            return RedirectToAction("index");
        }
    }
}
