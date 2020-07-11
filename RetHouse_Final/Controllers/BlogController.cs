using Microsoft.AspNetCore.Mvc;

namespace RetHouse_Final.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
