using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Repository.Models;
using Repository.Repositories.MainPage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RetHouse_Final.ViewComponents
{
    public class PartnersViewComponent : ViewComponent
    {
        private readonly IMainRepository _mainRepository;
        public PartnersViewComponent(IMainRepository mainRepository)
        {
            _mainRepository = mainRepository;
        }
        public IViewComponentResult Invoke()
        {
            var city = _mainRepository.GetPartners(5);

            return View(city);
        }
    }
}
