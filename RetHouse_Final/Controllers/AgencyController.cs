using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using Repository.Models;
using Repository.Repositories.AdminPagesCrud.Agency_and_Agent;
using Repository.Repositories.MainPage;
using System;

namespace RetHouse_Final.Controllers
{
    public class AgencyController : Controller
    {
        private readonly Repository.Repositories.Pages.IAgencyRepository _agencyRepository;
        private readonly IMainRepository _mainRepository;
        private readonly IAgencyReviewRepository _agencyReviewRepository;
        private  int _catId;
        public AgencyController(Repository.Repositories.Pages.IAgencyRepository agencyRepository, 
                                IMainRepository mainRepository ,
                                IAgencyReviewRepository agencyReviewRepository)
        {
            _agencyRepository = agencyRepository;
            _mainRepository = mainRepository;
            _agencyReviewRepository = agencyReviewRepository;
        }
        public IActionResult Index()
        {
            var model = _mainRepository.GetCategories();
            return View(model);
        }
        public IActionResult SingleAgency(int id,int agencyId)
        {
            _catId = id;
            var model = _mainRepository.GetCategoryById(id);
            ViewBag.AgencyId = agencyId;
            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult SingleAgency(Category catgory)
        {
            if (catgory.Id == 9999)
            {
                if (ModelState.IsValid)
                {
                    if(catgory.othrId < 1) { return NotFound(); }
                    var message = new MimeMessage();
                    message.From.Add(new MailboxAddress(catgory.Name, "kananrv@code.edu.az"));
                    message.To.Add(new MailboxAddress("System", catgory.ModifiedBy));
                    message.Subject = catgory.Name + "/" + catgory.othrId.ToString();
                    message.Body = new TextPart("plain")
                    {
                        Text = catgory.CreatedBy
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
                else
                {
                    return NotFound();
                }
           
            }
            else
            {
                AgencyReview model = new AgencyReview
                {
                    CreatedBy = catgory.CreatedBy,
                    Status = true,
                    Star = (byte)catgory.Id,
                    Name = catgory.CreatedBy,
                    Comment = catgory.Name,
                    AgencyId = Int32.Parse(catgory.ModifiedBy)
                };
                var routevaule = new
                {
                    id = catgory.catId,
                    agencyId = Int32.Parse(catgory.ModifiedBy)
                };

                if (ModelState.IsValid)
                {
                    _agencyReviewRepository.CreateAgencyReview(model);
                    return RedirectToAction("singleagency", "agency", routevaule);

                }
                return RedirectToAction("singleagency", "agency", routevaule);
            }

          
        }
    }
}
