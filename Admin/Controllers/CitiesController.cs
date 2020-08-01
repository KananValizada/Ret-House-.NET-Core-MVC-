using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Admin.Filters;
using Admin.Libs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repository.Models;
using Repository.Repositories.AdminPagesCrud;
using Repository.Services;

namespace Admin.Controllers
{
    [TypeFilter(typeof(Auth))]
    public class CitiesController : Controller
    {
        private Repository.Models.Admin _admin => RouteData.Values["Admin"] as Repository.Models.Admin;
        private readonly ICityRepository _cityRepository;
        private readonly ICloudinaryService _cloudinaryService;
        private readonly IFileManager _fileManager;
        public CitiesController(ICityRepository cityRepository,ICloudinaryService cloudinaryService,IFileManager fileManager)
        {
            _cityRepository = cityRepository;
            _cloudinaryService = cloudinaryService;
            _fileManager = fileManager;
        }
        public IActionResult Index()
        {
            var cities = _cityRepository.GetAllCities();
            return View(cities);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(City abs)
        {
            if (ModelState.IsValid)
            {
                abs.CreatedBy = _admin.Fullname;
                _cityRepository.CreateCity(abs);
                return RedirectToAction("index");
            }
            return View(abs);
        }
        public IActionResult Edit(int id)
        {
            City abs = _cityRepository.GetCityById(id);
            if (abs == null) return NotFound();
            return View(abs);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(City abs)
        {
            if (ModelState.IsValid)
            {
                abs.ModifiedBy = _admin.Fullname;
                City CityToUpdate = _cityRepository.GetCityById(abs.Id);
                if (CityToUpdate == null) return NotFound();

                _cityRepository.UpdateCity(CityToUpdate, abs);
                return RedirectToAction("index");
            }
            return View(abs);
        }
        [HttpPost]
        public IActionResult Upload(IFormFile file)
        {
            var filename = _fileManager.Upload(file);
            var publicId = _cloudinaryService.Store(filename);
            _fileManager.Delete(filename);
            return Ok(new
            {
                filename = publicId,
                src = _cloudinaryService.BuildUrl(publicId)
            });
        }

        public IActionResult Remove(string name)
        {
            _cloudinaryService.Delete(name);
            return Ok(new { status = 200 });

        }
        public IActionResult Delete(int id)
        {

            City abs = _cityRepository.GetCityById(id);
            if (abs == null) return NotFound();
            _cityRepository.DeleteCity(abs);
            return RedirectToAction("index");
        }
    }
}
