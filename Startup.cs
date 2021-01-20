using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdvantShop.Data;
using AdvantShop.Data.Interfaces;
using AdvantShop.Data.Repository;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace AdvantShop
{
    public class Startup
    {

        private IConfigurationRoot _configString;

        public Startup(IHostingEnvironment hostEnv)
        {
            _configString = new ConfigurationBuilder().SetBasePath(hostEnv.ContentRootPath).AddJsonFile("dbsettings.json").Build();
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<AppDBContent>(options => options.UseSqlServer(_configString.GetConnectionString("DefaultConnection")));
            services.AddTransient<IAllCategories, CategoryRepository>();
            services.AddTransient<IAllProducts, ProductRepository>();
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseStaticFiles();
            //app.UseMvcWithDefaultRoute();
            app.UseMvc(routes=>{
                routes.MapRoute(name: "default", template: "{controller=Products}/{action=Index}/{id?}");
                routes.MapRoute(name: "categories", template: "Categories/{action}/{category?}", defaults: new { Controller= "Categories", action="List" });
            });
            using (var scope = app.ApplicationServices.CreateScope())
            {
                AppDBContent content = scope.ServiceProvider.GetRequiredService<AppDBContent>();
                DBObjects.Initial(content);
            }
        }
    }
}
