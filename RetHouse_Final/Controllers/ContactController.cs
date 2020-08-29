using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using Repository.Models;

namespace RetHouse_Final.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(Agent model)
        {

                var message = new MimeMessage();
                message.From.Add(new MailboxAddress(model.Name, "kananrv@code.edu.az"));
                message.To.Add(new MailboxAddress("System", "kanan.veli@yahoo.com"));
                message.Subject = model.CreatedBy + "/" + model.Email;
                message.Body = new TextPart("plain")
                {
                    Text = model.Description
                };
                using (var client = new SmtpClient())
                {
                    client.Connect("smtp.gmail.com", 587, false);
                    client.Authenticate("KananRv@code.edu.az", "Hack2019@");
                    client.Send(message);
                    client.Disconnect(true);
                }

                return RedirectToAction("successPage", "property");

        }

    }
}
