using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using Repository.Models;
using Repository.Repositories.AdminPagesCrud.Properties;
using Repository.Repositories.MainPage;
using RetHouse_Final.MailChip;
using RetHouse_Final.Models;
using System;

namespace RetHouse_Final.Controllers
{
    public class PropertyController : Controller
    {
        private readonly IPropertyRepository _propertyRepository;
        private readonly IMainRepository _mainRepository;
        private readonly IPropertyReviewRepository _propertyReviewRepository;
        private int _catId;
        private int _propId;
       
       
        public PropertyController (IMainRepository mainRepository,
                                   IPropertyRepository propertyRepository,
                                   IPropertyReviewRepository propertyReviewRepository,
                                   MailchimpRepository mailchimpRepository)
        {
            _mainRepository = mainRepository;
            _propertyRepository = propertyRepository;
            _propertyReviewRepository = propertyReviewRepository;
        }
        public IActionResult Index()
        {
            var model = _mainRepository.GetCategories();
            return View(model);
        }
        public IActionResult SuccessPage()
        {
            return View();
        }
        
        public IActionResult SingleProduct(int id,int agentId,int propId) 
        {
            
            _catId = id;
            _propId = propId;
            var model = _mainRepository.GetCategoryById(id);
            ViewBag.AgentId = agentId;
            ViewBag.PropId = propId;
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult SingleProduct(Category catgory)
        {
            if (catgory.Id == 9999) {
                var message = new MimeMessage();
                message.From.Add(new MailboxAddress(catgory.Name, "kananrv@code.edu.az"));
                message.To.Add(new MailboxAddress("System", catgory.ModifiedBy));
                message.Subject = catgory.Name + "/" +catgory.othrId.ToString();
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
                PropertyReview model = new PropertyReview
                {
                    CreatedBy = catgory.CreatedBy,
                    Status = true,
                    Star = (byte)catgory.Id,
                    Name = catgory.CreatedBy,
                    Comment = catgory.Name,
                    PropertyId = Int32.Parse(catgory.ModifiedBy)
                };
                var routevaule = new
                {
                    id = catgory.catId,
                    agentId = catgory.othrId,
                    propId = Int32.Parse(catgory.ModifiedBy)

                };

                if (ModelState.IsValid)
                {
                    _propertyReviewRepository.CreatePropertyReview(model);
                    return RedirectToAction("singleproduct", "property", routevaule);

                }
                return RedirectToAction("singleproduct", "property", routevaule);
            }

        }
    }
}
