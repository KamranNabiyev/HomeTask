using ItBrains.Areas.AdminPanel.Utils;
using ItBrains.DAL;
using ItBrains.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ItBrains
{
    public class Startup
    {
        public Startup(IConfiguration configuration, IWebHostEnvironment enviroment)
        {
            Configuration = configuration;
            _enviroment = enviroment;
        }

        public readonly IWebHostEnvironment _enviroment;
        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().AddViewLocalization(LanguageViewLocationExpanderFormat.Suffix).
             AddDataAnnotationsLocalization();
            services.AddLocalization(option => { option.ResourcesPath = "Resources"; });

            services.AddIdentity<AppUser, IdentityRole>(IdentityOptions =>
            {
                IdentityOptions.Password.RequiredLength = 8;
                IdentityOptions.Password.RequireNonAlphanumeric = false;
                IdentityOptions.Password.RequireUppercase = true;
                IdentityOptions.Lockout.MaxFailedAccessAttempts = 5;
                IdentityOptions.Lockout.AllowedForNewUsers = true;
                IdentityOptions.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(3);
                IdentityOptions.User.RequireUniqueEmail = false;
                IdentityOptions.SignIn.RequireConfirmedPhoneNumber = false;
                IdentityOptions.SignIn.RequireConfirmedEmail = false;
            }).AddDefaultTokenProviders().AddEntityFrameworkStores<AppDbContext>();

            services.AddDbContext<AppDbContext>(settings => settings.UseSqlServer(Configuration["ConnectionStrings:DefaultConnection"]));

            Constants.AboutImageFolderPath = Path.Combine(_enviroment.WebRootPath,"src", "img", "about");

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
            
            app.UseAuthentication();
            app.UseAuthorization();
            var supportedCultures = new[]
            {
                new CultureInfo("az"),
                new CultureInfo("ru"),
                new CultureInfo("en"),
            };

            app.UseRequestLocalization(new RequestLocalizationOptions
            {
                DefaultRequestCulture = new RequestCulture("az"),
                SupportedCultures = supportedCultures,
                SupportedUICultures = supportedCultures
            }.SetDefaultCulture("az"));
            var options = app.ApplicationServices.GetService<IOptions<RequestLocalizationOptions>>();
            var cookieProvider = options.Value.RequestCultureProviders
                .OfType<CookieRequestCultureProvider>()
                .First();
            var urlProvider = options.Value.RequestCultureProviders
                .OfType<QueryStringRequestCultureProvider>().First();

            cookieProvider.Options.DefaultRequestCulture = new RequestCulture("az");
            urlProvider.Options.DefaultRequestCulture = new RequestCulture("az");

            cookieProvider.CookieName = "UserCulture";

            options.Value.RequestCultureProviders.Clear();
            options.Value.RequestCultureProviders.Add(cookieProvider);
            options.Value.RequestCultureProviders.Add(urlProvider);
            app.UseRequestLocalization(options.Value);
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                  name: "areas",
                  pattern: "{area:exists}/{controller=Dashboard}/{action=Index}/{id?}");
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
              
            });
        }
    }
}
