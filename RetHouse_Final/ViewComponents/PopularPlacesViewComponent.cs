using Microsoft.AspNetCore.Mvc;
using Repository.Repositories.MainPage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RetHouse_Final.ViewComponents
{
    public class PopularPlacesViewComponent : ViewComponent
    {
        private readonly IMainRepository _agentRepository;
        public PopularPlacesViewComponent(IMainRepository propertyItemRepository)
        {
            _agentRepository = propertyItemRepository;
        }
        public IViewComponentResult Invoke()
        {
            var city = _agentRepository.GetPopularCities(5);

            return View(city);
        }
    }
}
