using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using Repository.Data;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.Repositories.Pages
{
    public interface IAgencyRepository
    {
        IEnumerable<Agency> GetAgencies();
    }
    public class AgencyRepository : IAgencyRepository
    {
        private readonly RetHouseDbContext _context;
        public AgencyRepository(RetHouseDbContext context)
        {
            _context = context;
        }
        public IEnumerable<Agency> GetAgencies()
        {
            return _context.Agencies.Include("Properties").Where(a => a.Status).ToList();
        }

    }
}
