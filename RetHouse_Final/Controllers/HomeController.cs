using Microsoft.AspNetCore.Mvc;
using Repository.Repositories.MainPage;

namespace RetHouse_Final.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

    }
}
