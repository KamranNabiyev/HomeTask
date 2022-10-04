using ItBrains.DAL;
using ItBrains.Extentions;
using ItBrains.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ItBrains.Areas.AdminPanel.Controllers
{
    [Area("AdminPanel")]
    [Authorize]

    public class NewsController : Controller
    {
        private readonly AppDbContext _db;
        private readonly IWebHostEnvironment _env;
        public NewsController(AppDbContext db, IWebHostEnvironment env)
        {
            _db = db;
            _env = env;
        }
        public async Task<IActionResult> Index()
        {
            List<News> News = await _db.News.ToListAsync();
            return View(News);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(string imgCropped, News news)
        {

            if (imgCropped == null)
            {
                ModelState.AddModelError("", "Zəhmət olmasa şəkil seçin !");
                return View();
            }
            string folder = Path.Combine("src", "img", "news");

            //****************         Save New Image      **************************
            news.Image = Helper.UploadImage(imgCropped, _env.WebRootPath, folder);
            await _db.News.AddAsync(news);
            await _db.SaveChangesAsync();


            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Update(int? id)
        {
            if (id == null)
                return View("Error");
            News news = await _db.News.FirstOrDefaultAsync(x => x.Id == id);
            if (news == null)
                return View("Error");
            return View(news);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? id, News news, string imgCropped)
        {
            if (id == null)
                return View("Error");
            News dbNews = await _db.News.FirstOrDefaultAsync(x => x.Id == id);
            if (dbNews == null)
                return View("Error");

            if (imgCropped != null)
            {
                string folder = Path.Combine("src", "img", "news");
                string fullPath = Path.Combine(_env.WebRootPath, folder, dbNews.Image);
                //****************         Delete Old Image      **************************
                Helper.DeleteImage(fullPath);

                //****************         Save New Image      **************************
                dbNews.Image = Helper.UploadImage(imgCropped, _env.WebRootPath, folder);
            }
            dbNews.AzTitle = news.AzTitle;
            dbNews.RuTitle = news.RuTitle;
            dbNews.EnTitle = news.EnTitle;
            dbNews.AzSubTitle = news.AzSubTitle;
            dbNews.EnSubTitle = news.EnSubTitle;
            dbNews.RuSubTitle = news.RuSubTitle;
            dbNews.AzDescription = news.AzDescription;
            dbNews.EnDescription = news.EnDescription;
            dbNews.RuDescription = news.RuDescription;
            
            await _db.SaveChangesAsync();

            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
                return View("Error");
            News news = await _db.News.FirstOrDefaultAsync(x => x.Id == id);
            if (news == null)
                return View("Error");
            news.IsDeactive = true;
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Activate(int? id)
        {
            if (id == null)
                return View("Error");
            News news = await _db.News.FirstOrDefaultAsync(x => x.Id == id);
            if (news == null)
                return View("Error");
            news.IsDeactive = false;
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");

        }
    }
}
