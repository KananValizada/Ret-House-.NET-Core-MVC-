using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Repository.Data;
using Repository.Repositories.AdminPagesCrud.Agency_and_Agent;
using Repository.Repositories.AdminPagesCrud.Blogs;
using Repository.Repositories.AdminPagesCrud.Properties;
using Repository.Repositories.MainPage;
using Repository.Repositories.Pages;
using Repository.Services;
using RetHouse_Final.MailChip;

namespace RetHouse_Final
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
            services.AddTransient<ISliderRepository, SliderRepository>();
            services.AddTransient<IMainRepository, MainRepository>();
            services.AddTransient<IAboutUsRepository, AboutUsRepository>();
            services.AddTransient<Repository.Repositories.Pages.IAgencyRepository, Repository.Repositories.Pages.AgencyRepository>();
            services.AddTransient<IAgentRepository, AgentRepository>();
            services.AddTransient<IAgentReviewRepository, AgentReviewRepository>();
            services.AddTransient<IPropertyRepository, PropertyRepository>();
            services.AddTransient<IPropertyReviewRepository, PropertyReviewRepository>();
            services.AddTransient<Repository.Repositories.Pages.IBlogRepository, Repository.Repositories.Pages.BlogRepository>();
            services.AddTransient<IBlogReviewRepository, BlogReviewRepository>();
            services.AddTransient<IAgencyReviewRepository, AgencyReviewRepository>();
            services.AddTransient<ICloudinaryService, CloudinaryService>();
            services.AddTransient<MailchimpRepository>();
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
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
