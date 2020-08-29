using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Admin.Filters;
using Microsoft.AspNetCore.Mvc;
using Repository.Models;
using Repository.Repositories.AdminPagesCrud;

namespace Admin.Controllers
{
    [TypeFilter(typeof(Auth))]
    public class TeamsController : Controller
    {
        private Repository.Models.Admin _admin => RouteData.Values["Admin"] as Repository.Models.Admin;
        private readonly ITeamRepository _TeamRepository;

        public TeamsController(ITeamRepository TeamRepository)
        {
            _TeamRepository = TeamRepository;
        }
        public IActionResult Index()
        {
            var Teams = _TeamRepository.GetAllTeams();
            return View(Teams);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Team Team)
        {
            if (ModelState.IsValid)
            {
                Team.CreatedBy = _admin.Fullname;
                Team.AboutUsId = 1;
                _TeamRepository.CreateTeam(Team);
                return RedirectToAction("index");
            }
            return View(Team);
        }
        public IActionResult Edit(int id)
        {
            Team abs = _TeamRepository.GetTeamById(id);
            if (abs == null) return NotFound();
            return View(abs);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Team abs)
        {
            abs.AboutUsId = 1; 
            if (ModelState.IsValid)
            {
                abs.ModifiedBy = _admin.Fullname;
                Team TeamToUpdate = _TeamRepository.GetTeamById(abs.Id);
                if (TeamToUpdate == null) return NotFound();
                _TeamRepository.UpdateTeam(TeamToUpdate, abs);
                return RedirectToAction("index");
            }
            return View(abs);
        }
        public IActionResult Delete(int id)
        {
            Team abs = _TeamRepository.GetTeamById(id);
            if (abs == null) return NotFound();
            _TeamRepository.DeleteTeam(abs);
            return RedirectToAction("index");
        }
    }
}
