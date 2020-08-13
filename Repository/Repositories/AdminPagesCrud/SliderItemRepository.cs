using Repository.Data;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.Repositories.AdminPagesCrud
{
    public interface ISliderItemRepository
    {
        IEnumerable<SliderItem> GetSliderItem(int count);
        IEnumerable<SliderItem> GetAllSliderItem();
        void CreateSliderItem(SliderItem model);
        SliderItem GetSliderItemById(int id);
        void UpdateSliderItem(SliderItem SliderItemToUpdate, SliderItem model);
        void DeleteSliderItem(SliderItem SliderItem);
    }
    public class SliderItemRepository : ISliderItemRepository
    {
        private readonly RetHouseDbContext _context;
        public SliderItemRepository(RetHouseDbContext context)
        {
            _context = context;
        }

        public void CreateSliderItem(SliderItem model)
        {
            model.CreatedAt = DateTime.Now;
            model.ActionText = "#";
            model.EndPoint = "#";
            _context.SliderItems.Add(model);
            _context.SaveChanges();
        }

        public void DeleteSliderItem(SliderItem SliderItem)
        {
            _context.SliderItems.Remove(SliderItem);
            _context.SaveChanges();
        }

        public SliderItem GetSliderItemById(int id)
        {
            return _context.SliderItems.Find(id);
        }

        public IEnumerable<SliderItem> GetSliderItem(int count)
        {
            return _context.SliderItems.Where(a => a.Status).Take(count).ToList();
        }

        public IEnumerable<SliderItem> GetAllSliderItem()
        {
            return _context.SliderItems.ToList();
        }

        public void UpdateSliderItem(SliderItem SliderItemToUpdate, SliderItem model)
        {
            SliderItemToUpdate.Status = model.Status;
            SliderItemToUpdate.Title = model.Title;
            SliderItemToUpdate.ActionText = "#";
            SliderItemToUpdate.EndPoint = "#";
            SliderItemToUpdate.Slogan = model.Slogan;
            SliderItemToUpdate.Image = model.Image;
            SliderItemToUpdate.OrderBy = model.OrderBy;
            SliderItemToUpdate.ModifiedBy = model.ModifiedBy;
            SliderItemToUpdate.ModifiedAt = DateTime.Now;
            _context.SaveChanges();
        }


    }
}
