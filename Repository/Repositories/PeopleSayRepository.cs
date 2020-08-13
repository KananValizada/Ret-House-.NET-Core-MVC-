using Repository.Data;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.Repositories
{
    public interface IPeopleSayRepository
    {
        IEnumerable<PeopleSay> GetPeopleSay(int count);
        IEnumerable<PeopleSay> GetAllPeopleSay();
        void CreatePeopleSay(PeopleSay model);
        PeopleSay GetPeopleSayById(int id);
        void UpdatePeopleSay(PeopleSay PeopleSayToUpdate, PeopleSay model);
        void DeletePeopleSay(PeopleSay PeopleSay);
    }
    public class PeopleSayRepository : IPeopleSayRepository
    {
        private readonly RetHouseDbContext _context;
        public PeopleSayRepository(RetHouseDbContext context)
        {
            _context = context;
        }

        public void CreatePeopleSay(PeopleSay model)
        {
            model.CreatedAt = DateTime.Now;
            _context.PeopleSays.Add(model);
            _context.SaveChanges();
        }

        public void DeletePeopleSay(PeopleSay PeopleSay)
        {
            _context.PeopleSays.Remove(PeopleSay);
            _context.SaveChanges();
        }

        public PeopleSay GetPeopleSayById(int id)
        {
            return _context.PeopleSays.Find(id);
        }

        public IEnumerable<PeopleSay> GetPeopleSay(int count)
        {
            return _context.PeopleSays.Where(a => a.Status).Take(count).ToList();
        }

        public IEnumerable<PeopleSay> GetAllPeopleSay()
        {
            return _context.PeopleSays.ToList();
        }

        public void UpdatePeopleSay(PeopleSay PeopleSayToUpdate, PeopleSay model)
        {
            PeopleSayToUpdate.Status = model.Status;
            PeopleSayToUpdate.PersonName = model.PersonName;
            PeopleSayToUpdate.PersonJob = model.PersonJob;
            PeopleSayToUpdate.PersonImage = model.PersonImage;
            PeopleSayToUpdate.PersonComment = model.PersonComment;
            PeopleSayToUpdate.ModifiedBy = model.ModifiedBy;
            PeopleSayToUpdate.ModifiedAt = DateTime.Now;
            _context.SaveChanges();
        }


    }
}
