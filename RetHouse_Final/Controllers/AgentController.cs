using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using Repository.Models;
using Repository.Repositories.AdminPagesCrud.Agency_and_Agent;
using Repository.Repositories.MainPage;
using System;

namespace RetHouse_Final.Controllers
{
    public class AgentController : Controller
    {
        private readonly IAgentRepository _agentRepository;
        private readonly IMainRepository _mainRepository;
        private readonly IAgentReviewRepository _agentReviewRepository;
        private int _catId; 
        public AgentController(IMainRepository mainRepository,
                               IAgentRepository agentRepository,
                               IAgentReviewRepository agentReviewRepository
                               )
        {
            _agentRepository = agentRepository;
            _mainRepository = mainRepository;
            _agentReviewRepository = agentReviewRepository;
        }
        public IActionResult Index()
        {
            var model = _mainRepository.GetCategories();
            return View(model);
        }
        public IActionResult SingleAgent(int id,int agentId)
        {
            _catId = id;
            var model = _mainRepository.GetCategoryById(id);
            ViewBag.AgentId = agentId;
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult SingleAgent(Category catgory)
        {

            if (catgory.Id == 9999)
            {
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
                AgentReview model = new AgentReview
                {
                    CreatedBy = catgory.CreatedBy,
                    Status = true,
                    Star = (byte)catgory.Id,
                    Name = catgory.CreatedBy,
                    Comment = catgory.Name,
                    AgentId = Int32.Parse(catgory.ModifiedBy)
                };
                var routevaule = new
                {
                    id = catgory.catId,
                    agentId = Int32.Parse(catgory.ModifiedBy)
                };

                if (ModelState.IsValid)
                {
                    _agentReviewRepository.CreateAgentReview(model);
                    return RedirectToAction("singleagent", "agent", routevaule);

                }
                return RedirectToAction("singleagent", "agent", routevaule);

            }

            
        }
    }
}
