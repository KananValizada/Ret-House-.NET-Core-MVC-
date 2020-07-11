using Microsoft.AspNetCore.Mvc;
using Repository.Repositories.MainPage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RetHouse_Final.ViewComponents
{
    public class PeopleSaysViewComponent : ViewComponent
    {
        private readonly IMainRepository _mainRepository;
        public PeopleSaysViewComponent(IMainRepository mainRepository)
        {
            _mainRepository = mainRepository;
        }
        public IViewComponentResult Invoke()
        {
            var peoplesay = _mainRepository.GetPeopleSays();

            return View(peoplesay);
        }
    }
}
