
using Microsoft.EntityFrameworkCore;
using ShopPanel___ASP.NET_MVC.Data;
using ShopPanel___ASP.NET_MVC.Interfaces;
using ShopPanel___ASPNetMVC.Data;
using ZOLLA.TestTask.Models;

namespace Automarket
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }
        
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            
            var connection = Configuration.GetConnectionString("DefaultConnection");
            services.AddDbContext<ShopContext>(options =>
                options.UseSqlServer(connection));

            services.AddScoped<IRepository<Buyer>, BuyerRepository>();
            services.AddScoped<IRepository<Products>, ProductsRepository>();
        }
        
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
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