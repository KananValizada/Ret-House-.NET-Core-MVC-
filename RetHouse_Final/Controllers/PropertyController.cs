using Microsoft.AspNetCore.Mvc;

namespace RetHouse_Final.Controllers
{
    public class PropertyController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
