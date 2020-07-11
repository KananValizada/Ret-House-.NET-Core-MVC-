using Microsoft.AspNetCore.Mvc;
using Repository.Repositories.MainPage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RetHouse_Final.ViewComponents
{
    public class PropertyItemViewComponent : ViewComponent
    {
        private readonly IMainRepository _agentRepository; 
        public PropertyItemViewComponent(IMainRepository agentRepository)
        {
            _agentRepository = agentRepository;
        }
        public IViewComponentResult Invoke()
        {
            var propertyItems = _agentRepository.GetAgents();

            return View(propertyItems);
        }
    
    }
}
