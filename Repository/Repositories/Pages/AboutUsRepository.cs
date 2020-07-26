using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Repository.Data;
using Repository.Models;

namespace Repository.Repositories.Pages
{
    public interface IAboutUsRepository
    {
        AboutUs GetAbout();
    }
    public class AboutUsRepository : IAboutUsRepository
    {
        private readonly RetHouseDbContext _context;
        public AboutUsRepository(RetHouseDbContext context)
        {
            _context = context; 
        }
        public AboutUs GetAbout()
        {
            return _context.AboutUs.Include("Teams").FirstOrDefault(a => a.Status);
        }
    }
}
