using Microsoft.AspNetCore.Mvc;
using Repository.Data;
using Repository.Repositories.Pages;

namespace RetHouse_Final.Controllers
{
    public class AboutUsController : Controller
    {
        private readonly IAboutUsRepository _aboutUsRepository;
        public AboutUsController(IAboutUsRepository aboutUsRepository)
        {
            _aboutUsRepository = aboutUsRepository;
        }
        public IActionResult Index()
        {
            var model = _aboutUsRepository.GetAbout();
            return View(model);
        }
    }
}
