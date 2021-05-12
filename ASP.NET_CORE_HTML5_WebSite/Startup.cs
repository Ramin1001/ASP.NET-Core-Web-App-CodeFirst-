using ASP.NET_CORE_HTML5_WebSite.Service;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASP.NET_CORE_HTML5_WebSite.Domain.Repositories.Abstract;
using ASP.NET_CORE_HTML5_WebSite.Domain.Repositories.EntityFramwork;
using ASP.NET_CORE_HTML5_WebSite.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace ASP.NET_CORE_HTML5_WebSite
{
    public class Startup
    {

        public IConfiguration Configuration { get; } // added manualy
        public Startup(IConfiguration configuration) => Configuration = configuration; // added manualy


        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            // We bind the project property from appsettings.json to Config.cs to further manage it..
            Configuration.Bind("Project", new Config()); // added manualy


            // connect interface with EF files and for for one http request we open morethan one object
            // added manualy
            services.AddTransient<ITextFieldsRepository, EFTextFieldsRepository>();
            services.AddTransient<IServiceItemsRepository, EFServiceItemsRepository>();
            services.AddTransient<DataManager>();

            // connnect contex DB
            // added manualy
            services.AddDbContext<AppDbContext>(x => x.UseSqlServer(Config.ConnectionString));

            // set identity sistem
            // added manualy
            services.AddIdentity<IdentityUser, IdentityRole>(opts =>
            {
                opts.User.RequireUniqueEmail = true;
                opts.Password.RequiredLength = 6;
                opts.Password.RequireNonAlphanumeric = false;
                opts.Password.RequireLowercase = false;
                opts.Password.RequireUppercase = false;
                opts.Password.RequireDigit = false;
            }).AddEntityFrameworkStores<AppDbContext>().AddDefaultTokenProviders();

            // set authentication cookies
            // added manualy
            services.ConfigureApplicationCookie(options =>
            {
                options.Cookie.Name = "myTarvel";
                options.Cookie.HttpOnly = true;
                options.LoginPath = "/account/login";
                options.AccessDeniedPath="/account/accessdenied";
                options.SlidingExpiration = true;
            });

            // set policy authoriztion for Admin area
            // added manualy.
            services.AddAuthorization(x =>
            {
                x.AddPolicy("AdminArea", policy => { policy.RequireRole("admin"); }); // we required admin role from User
            });

            // add services for controller and views (MVC)
            // added manualy.
            services.AddControllersWithViews(x =>
            {
                x.Conventions.Add(new AdminAreaAuthorization("Admin", "AdminArea"));
            })
            .SetCompatibilityVersion(Microsoft.AspNetCore.Mvc.CompatibilityVersion.Version_3_0).AddSessionStateTempDataProvider(); 
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            // registration procedure of middlewre very important (Burdaki ardicilliq mutleqdir)

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage(); // we need to see all exeptions
              
            }

            app.UseRouting();
            
            //connect authentication and authorization
            // added manualy
            app.UseCookiePolicy();
            app.UseAuthentication();
            app.UseAuthorization();


            // connect static files (js, css and so on)
            app.UseStaticFiles();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute("admin", "{area:exists}/{controller=Home}/{action=Index}/{id?}"); // added manualy
                endpoints.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}"); // added manualy
            });
        }
    }
}
