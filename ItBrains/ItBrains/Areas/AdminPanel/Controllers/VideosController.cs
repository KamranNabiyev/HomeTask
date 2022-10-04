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

    public class VideosController : Controller
    {
        private readonly AppDbContext _db;
        private readonly IWebHostEnvironment _env;
        public VideosController(AppDbContext db, IWebHostEnvironment env)
        {
            _db = db;
            _env = env;
        }
        public async Task<IActionResult> Index()
        {
            List<Video> Videos = await _db.Videos.ToListAsync();
            return View(Videos);
        }
        public async Task<IActionResult> Create()
        {
            ViewBag.Lessons = await _db.VideoLessons.ToListAsync();
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(int lessonId, Video Video)
        {
            ViewBag.Lessons = await _db.VideoLessons.ToListAsync();

            Video.VideoLessonId = lessonId;
            await _db.Videos.AddAsync(Video);
            await _db.SaveChangesAsync();


            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Update(int? id)
        {
            ViewBag.Lessons = await _db.VideoLessons.ToListAsync();
            if (id == null)
                return View("Error");
            Video Video = await _db.Videos.FirstOrDefaultAsync(x => x.Id == id);
            if (Video == null)
                return View("Error");
          
            return View(Video);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? id, Video Video,int lessonId)
        {
            ViewBag.Lessons = await _db.VideoLessons.ToListAsync();
            if (id == null)
                return View("Error");
            Video dbVideo = await _db.Videos.FirstOrDefaultAsync(x => x.Id == id);
            if (Video == null)
                return View("Error");
           
            dbVideo.VideoLessonId = lessonId;
            dbVideo.Link = Video.Link;

            await _db.SaveChangesAsync();

            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
                return View("Error");
            Video Video = await _db.Videos.FirstOrDefaultAsync(x => x.Id == id);
            if (Video == null)
                return View("Error");
            Video.IsDeactive = true;
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Activate(int? id)
        {
            if (id == null)
                return View("Error");
            Video Video = await _db.Videos.FirstOrDefaultAsync(x => x.Id == id);
            if (Video == null)
                return View("Error");
            Video.IsDeactive = false;
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");

        }
    }
}
