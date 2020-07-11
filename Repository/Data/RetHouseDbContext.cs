using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Repository.Models;

namespace Repository.Data
{
    public class RetHouseDbContext : DbContext
    {
        public RetHouseDbContext(DbContextOptions<RetHouseDbContext> options) : base(options) { }
        public DbSet<Agency> Agencies { get; set; }
        public DbSet<AgencyReview> AgencyReviews { get; set; }
        public DbSet<Agent> Agents { get; set; }
        public DbSet<AgentReview> AgentReviews { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<PropDetail> PropDetails { get; set; }
        public DbSet<Property> Properties { get; set; }
        public DbSet<PropertyReview> PropertyReviews { get; set; }
        public DbSet<PropFeature> PropFeatures { get; set; }
        public DbSet<PropFloor> PropFloors { get; set; }
        public DbSet<PropImage> PropImages { get; set; }
        public DbSet<Setting> Setting { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<BlogReview> BlogReviews { get; set; }
        public DbSet<BlogPhase> BlogPhases { get; set; }
        public DbSet<BlogTag> BlogTags { get; set; }
        public DbSet<BlogTagRelate> BlogTagRelates { get; set; }
        public DbSet<SliderItem> SliderItems { get; set; }
        public DbSet<Partner> Partners { get; set; }
        public DbSet<PeopleSay> PeopleSays { get; set; }


    }
}
