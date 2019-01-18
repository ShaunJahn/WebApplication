using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CakesWebApplication.Models;
using CakesWebApplication.Repository_Implementation;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using CakesWebApplication.DbContexts;
using Microsoft.EntityFrameworkCore;
using CakesWebApplication.Repository;
using Microsoft.AspNetCore.Identity;

namespace CakesWebApplication
{
    public class Startup
    {
        public static IConfiguration config;

        public Startup(IConfiguration configuration )
        {
            config = configuration;
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            //to use mvc
            services.AddMvc();
            var connectionString =  Startup.config["ConnectionStrings:DefaultConnection"];
            services.AddDbContext<PiesDbContext>(c => c.UseSqlServer(connectionString));
            //for auth
            services.AddIdentity<IdentityUser, IdentityRole > ().AddEntityFrameworkStores<PiesDbContext>();
            services.AddTransient<IPieRepository, PieRepository>();

            services.AddTransient<ICategoryRepository, CategoryRepository>();
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddScoped<ShoppingCart>(sp => ShoppingCart.GetCart(sp));
            services.AddTransient<IOrderRepository, OrderRepository>();
            services.AddMemoryCache();
            services.AddSession();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, PiesDbContext piesDbContext)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseStatusCodePages();
            }
            else
            {
                app.UseExceptionHandler("/AppException");
            }
            app.UseStaticFiles();
            app.UseSession();
            app.UseAuthentication();
            DatabaseSeed.Seed(piesDbContext);
           
            app.UseMvc(routes =>
           {
               routes.MapRoute(
                   name: "categoryFilter",
                   template: "pie/{action}/{category}",
                   defaults: new { Controllers = "pie", action = "List" }); 

               routes.MapRoute(
                   name: "default",
                   template: "{controller=Home}/{action=Index}/{id?}");
           });
        }
    }
}
