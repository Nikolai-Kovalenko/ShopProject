using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Shop.Data;
using Shop.Data.Interfaces;
using Shop.Data.Mocks;
using Shop.Data.Reository;

namespace Shop
{
    public class Startup
    {
        private IConfigurationRoot _confString;

        public Startup(IHostingEnvironment hostEvn)
        {
            _confString = new ConfigurationBuilder().SetBasePath(hostEvn.ContentRootPath).AddJsonFile("DBSettings.json").Build();   
        }
                
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<AppDBContent>(options => options.UseSqlServer(_confString.GetConnectionString("DefaultConnection")));
            services.AddTransient<IAllCars, CarRepository>(); 
            services.AddTransient<ICarsCategory, CategotyRepository>();
            services.AddMvc();
            services.AddControllersWithViews();

           
            //services.MvcOptions.EnableEndpointRouting = false;

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseDeveloperExceptionPage();
            app.UseStatusCodePages();
            app.UseStaticFiles();
            app.UseRouting();

            //  од ниже вз€л с GPT €кобы дл€ того, чтобы настроить маршрутизацию дл€ контроллера
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "cars",
                    pattern: "Cars/List",
                    defaults: new { controller = "Cars", action = "List" }
                );
            });

            using (var scope = app.ApplicationServices.CreateScope())
            {
                AppDBContent content = scope.ServiceProvider.GetRequiredService<AppDBContent>();
                DBObjects.Initial(content);
            }

            
        }
    }
}
