using Microsoft.AspNetCore.Mvc;

namespace RetHouse_Final.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
