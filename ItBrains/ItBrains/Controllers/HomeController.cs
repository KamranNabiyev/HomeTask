using ItBrains.DAL;
using ItBrains.Models;
using ItBrains.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ItBrains.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _db;
        public HomeController(AppDbContext db)
        {
            _db = db;
        }

        public async Task<IActionResult> Index()
        {
            HomeVM homeVM = new HomeVM
            {
                Services = await _db.Services.Where(x => !x.IsDeactive).ToListAsync(),
                GraduatedOpinions = await _db.GraduatedOpinions.Where(x=> !x.IsDeactive)
                .OrderByDescending(x=>x.Id).Take(6).ToListAsync(),
                News = await _db.News.Where(x => !x.IsDeactive)
                .OrderByDescending(x => x.Id).Take(3).ToListAsync(),
                About=await _db.Abouts.FirstOrDefaultAsync()
            };
            return View(homeVM);
        }

        public IActionResult SetLanguage(string culture, string url)
        {
            try
            {
                Response.Cookies.Append(
               CookieRequestCultureProvider.DefaultCookieName,
               CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(culture)),
               new CookieOptions { Expires = DateTimeOffset.UtcNow.AddYears(1) });
                return LocalRedirect(url);
            }
            catch (Exception)
            {
                return RedirectToAction(nameof(Index));
                throw;
            }

        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
