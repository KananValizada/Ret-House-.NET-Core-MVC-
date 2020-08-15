using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Repository.Repositories.MainPage;
using RetHouse_Final.MailChip;
using RetHouse_Final.Models;

namespace RetHouse_Final.Controllers
{
    public class HomeController : Controller
    {
        private readonly MailchimpRepository _mailchimpRepository;
        public HomeController(MailchimpRepository mailchimpRepository)
        {
            _mailchimpRepository = mailchimpRepository;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Message message)
        {
            _mailchimpRepository.CreateAndSendCampaign(message.TextMessage);
            message.TextMessage = "Qeydiyyat üçün təşəkkürlər";
            return View(message);
        }
    }
}
