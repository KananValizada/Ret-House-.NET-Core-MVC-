using Microsoft.EntityFrameworkCore;
using Repository.Data;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.Repositories.AdminPagesCrud.Properties
{
    public interface IPropFeatureRepository
    {
        IEnumerable<PropFeature> GetPropFeatures(int count);
        IEnumerable<PropFeature> GetAllPropFeatures();
        void CreatePropFeature(PropFeature model);
        PropFeature GetPropFeatureById(int id);
        void UpdatePropFeature(PropFeature PropFeatureToUpdate, PropFeature model);
        void DeletePropFeature(PropFeature PropFeature);
    }
    public class PropFeatureRepository : IPropFeatureRepository
    {
        private readonly RetHouseDbContext _context;
        public PropFeatureRepository(RetHouseDbContext context)
        {
            _context = context;
        }

        public void CreatePropFeature(PropFeature model)
        {
            _context.PropFeatures.Add(model);
            _context.SaveChanges();
        }

        public void DeletePropFeature(PropFeature PropFeature)
        {
            _context.PropFeatures.Remove(PropFeature);
            _context.SaveChanges();
        }

        public PropFeature GetPropFeatureById(int id)
        {
            return _context.PropFeatures.Find(id);
        }

        public IEnumerable<PropFeature> GetPropFeatures(int count)
        {
            return _context.PropFeatures.Take(count).ToList();
        }

        public IEnumerable<PropFeature> GetAllPropFeatures()
        {
            return _context.PropFeatures.Include("Property").ToList();
        }

        public void UpdatePropFeature(PropFeature PropFeatureToUpdate, PropFeature model)
        {
            PropFeatureToUpdate.PropertyId = model.PropertyId;
            PropFeatureToUpdate.Key = model.Key;
            PropFeatureToUpdate.Value = model.Value;
            _context.SaveChanges();
        }


    }
}
