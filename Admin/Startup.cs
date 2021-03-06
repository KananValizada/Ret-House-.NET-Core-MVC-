using Admin.Libs;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Repository.Data;
using Repository.Repositories;
using Repository.Repositories.AdminPagesCrud;
using Repository.Repositories.AdminPagesCrud.Agency_and_Agent;
using Repository.Repositories.AdminPagesCrud.Blogs;
using Repository.Repositories.AdminPagesCrud.PropDetails;
using Repository.Repositories.AdminPagesCrud.Properties;
using Repository.Repositories.AdminRepositories;
using Repository.Services;

namespace Admin
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            services.AddDbContext<RetHouseDbContext>(options =>
                   options.UseSqlServer(Configuration.GetConnectionString("Default"),
                   x => x.MigrationsAssembly("Repository")));
            services.AddTransient<IAdminRepository, AdminRepository>();
            services.AddTransient<ICategoryRepository, CategoryRepository>();
            services.AddTransient<ICityRepository, CityRepository>();
            services.AddTransient<ICountryRepository, CountryRepository>();
            services.AddTransient<IPartnerRepository, PartnerRepository>();
            services.AddTransient<ITeamRepository, TeamRepository>();
            services.AddTransient<IAboutUsRepository, AboutUsRepository>();
            services.AddTransient<IAgencyRepository, AgencyRepository>();
            services.AddTransient<IAgentRepository, AgentRepository>();
            services.AddTransient<IAgencyReviewRepository, AgencyReviewRepository>();
            services.AddTransient<IAgentReviewRepository, AgentReviewRepository>();
            services.AddTransient<IBlogPhaseRepository, BlogPhaseRepository>();
            services.AddTransient<IBlogRepository, BlogRepository>();
            services.AddTransient<IBlogReviewRepository, BlogReviewRepository>();
            services.AddTransient<IBlogTagRelateRepository, BlogTagRelateRepository>();
            services.AddTransient<IBlogTagRepository, BlogTagRepository>();
            services.AddTransient<IPropertyRepository, PropertyRepository>();
            services.AddTransient<IPropertyReviewRepository, PropertyReviewRepository>();
            services.AddTransient<IPropFeatureRepository, PropFeatureRepository>();
            services.AddTransient<IPropDetailRepository, PropDetailRepository>();
            services.AddTransient<IPropFloorRepository, PropFloorRepository>();
            services.AddTransient<IPropImageRepository, PropImageRepository>();
            services.AddTransient<ISliderItemRepository, SliderItemRepository>();
            services.AddTransient<IPeopleSayRepository, PeopleSayRepository>();
            services.AddTransient<ICloudinaryService, CloudinaryService>();
            services.AddTransient<IFileManager, FileManager>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Dashboard}/{action=Index}/{id?}");
            });
        }
    }
}
