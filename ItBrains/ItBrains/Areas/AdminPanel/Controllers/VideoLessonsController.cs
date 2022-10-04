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

    public class VideoLessonsController : Controller
    {
        private readonly AppDbContext _db;
        private readonly IWebHostEnvironment _env;
        public VideoLessonsController(AppDbContext db, IWebHostEnvironment env)
        {
            _db = db;
            _env = env;
        }
        public async Task<IActionResult> Index()
        {
            List<VideoLesson> VideoLessons = await _db.VideoLessons.ToListAsync();
            return View(VideoLessons);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(string imgCropped, VideoLesson VideoLesson)
        {

            if (imgCropped == null)
            {
                ModelState.AddModelError("", "Zəhmət olmasa şəkil seçin !");
                return View();
            }
            string folder = Path.Combine("src", "img", "videolessons");

            //****************         Save New Image      **************************
            VideoLesson.Image = Helper.UploadImage(imgCropped, _env.WebRootPath, folder);
            await _db.VideoLessons.AddAsync(VideoLesson);
            await _db.SaveChangesAsync();


            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Update(int? id)
        {
            if (id == null)
                return View("Error");
            VideoLesson VideoLesson = await _db.VideoLessons.FirstOrDefaultAsync(x => x.Id == id);
            if (VideoLesson == null)
                return View("Error");
            return View(VideoLesson);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? id, VideoLesson VideoLesson, string imgCropped)
        {
            if (id == null)
                return View("Error");
            VideoLesson dbVideoLesson = await _db.VideoLessons.FirstOrDefaultAsync(x => x.Id == id);
            if (VideoLesson == null)
                return View("Error");

            if (imgCropped != null)
            {
                string folder = Path.Combine("src", "img", "videolessons");
                string fullPath = Path.Combine(_env.WebRootPath, folder, dbVideoLesson.Image);
                //****************         Delete Old Image      **************************
                Helper.DeleteImage(fullPath);

                //****************         Save New Image      **************************
                dbVideoLesson.Image = Helper.UploadImage(imgCropped, _env.WebRootPath, folder);
            }
            dbVideoLesson.AzName = VideoLesson.AzName;
            dbVideoLesson.EnName = VideoLesson.EnName;
            dbVideoLesson.RuName = VideoLesson.RuName;

            await _db.SaveChangesAsync();

            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
                return View("Error");
            VideoLesson VideoLesson = await _db.VideoLessons.FirstOrDefaultAsync(x => x.Id == id);
            if (VideoLesson == null)
                return View("Error");
            VideoLesson.IsDeactive = true;
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Activate(int? id)
        {
            if (id == null)
                return View("Error");
            VideoLesson VideoLesson = await _db.VideoLessons.FirstOrDefaultAsync(x => x.Id == id);
            if (VideoLesson == null)
                return View("Error");
            VideoLesson.IsDeactive = false;
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");

        }
    }
}
