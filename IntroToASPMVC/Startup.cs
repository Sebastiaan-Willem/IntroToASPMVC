using IntroToASPMVC.Data;
using IntroToASPMVC.Helper;
using IntroToASPMVC.Models;
using IntroToASPMVC.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntroToASPMVC
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
            services.AddAutoMapper(typeof(AutoMapperProfile).Assembly);
            services.AddScoped<IMovieService, MovieService>();
            services.AddScoped<IContactService, ContactService>();
            services.AddScoped<IAddressService, AddressService>();
            services.AddScoped<IGenericRepo<Movie>, GenericRepo<Movie>>();
            services.AddScoped<IContactRepo, ContactRepo>();
            services.AddScoped<IGenericRepo<Contact>, GenericRepo<Contact>>();
            services.AddScoped<IGenericRepo<Address>, GenericRepo<Address>>();

            services.AddScoped<IWeatherRepository, WeatherRepository>();
            services.AddScoped<IWeatherService, WeatherService>();

            services.AddDbContext<AspContext>(options =>
            {
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnectionString"));
                
            });

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
                //Attribute Routing
                //endpoints.MapControllers();

                //Conventional Routing

                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
