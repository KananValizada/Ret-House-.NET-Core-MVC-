using Microsoft.AspNetCore.Mvc;
using Repository.Repositories.MainPage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RetHouse_Final.ViewComponents
{
    public class SliderViewComponent : ViewComponent
    {
        private readonly ISliderRepository _sliderRepository;
        public SliderViewComponent(ISliderRepository sliderRepository)
        {
            _sliderRepository = sliderRepository;
        }
        public IViewComponentResult Invoke()
        {
            var sliderItems = _sliderRepository.GetSliderItems();

            return View(sliderItems);
        }
    }
}
