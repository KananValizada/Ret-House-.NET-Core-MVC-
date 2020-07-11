using System;
using Repository.Data;
using Repository.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.Repositories.MainPage
{
    public interface ISliderRepository
    {
        IEnumerable<SliderItem> GetSliderItems();
    }
    public class SliderRepository : ISliderRepository
    {
        private readonly RetHouseDbContext _context;
        public SliderRepository(RetHouseDbContext context)
        {
            _context = context;
        }
        public IEnumerable<SliderItem> GetSliderItems()
        {
            return _context.SliderItems.Where(s => s.Status)
                                       .OrderBy(s => s.OrderBy)
                                       .ToList();
        }
    }
}
