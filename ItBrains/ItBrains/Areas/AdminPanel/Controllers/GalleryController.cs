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

    public class GalleryController : Controller
    {
        private readonly AppDbContext _db;
        private readonly IWebHostEnvironment _env;
        public GalleryController(AppDbContext db, IWebHostEnvironment env)
        {
            _db = db;
            _env = env;
        }
        public async Task<IActionResult> Index()
        {
            List<Gallery> Gallerys = await _db.Galleries.ToListAsync();
            return View(Gallerys);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(string imgCropped, Gallery Gallery)
        {

            if (imgCropped == null)
            {
                ModelState.AddModelError("", "Zəhmət olmasa şəkil seçin !");
                return View();
            }
            string folder = Path.Combine("src", "img", "gallery");

            //****************         Save New Image      **************************
            Gallery.Image = Helper.UploadImage(imgCropped, _env.WebRootPath, folder);
            await _db.Galleries.AddAsync(Gallery);
            await _db.SaveChangesAsync();


            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Update(int? id)
        {
            if (id == null)
                return View("Error");
            Gallery Gallery = await _db.Galleries.FirstOrDefaultAsync(x => x.Id == id);
            if (Gallery == null)
                return NotFound(Gallery);
            return View(Gallery);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? id, Gallery Gallery, string imgCropped)
        {
            if (id == null)
                return View("Error");
            Gallery dbGallery = await _db.Galleries.FirstOrDefaultAsync(x => x.Id == id);
            if (Gallery == null)
                return View("Error");

            if (imgCropped != null)
            {
                string folder = Path.Combine("src", "img", "gallery");
                string fullPath = Path.Combine(_env.WebRootPath, folder, dbGallery.Image);
                //****************         Delete Old Image      **************************
                Helper.DeleteImage(fullPath);

                //****************         Save New Image      **************************
                dbGallery.Image = Helper.UploadImage(imgCropped, _env.WebRootPath, folder);
            }

            await _db.SaveChangesAsync();

            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
                return View("Error");
            Gallery Gallery = await _db.Galleries.FirstOrDefaultAsync(x => x.Id == id);
            if (Gallery == null)
                return View("Error");
            Gallery.IsDeactive = true;
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Activate(int? id)
        {
            if (id == null)
                return View("Error");
            Gallery Gallery = await _db.Galleries.FirstOrDefaultAsync(x => x.Id == id);
            if (Gallery == null)
                return View("Error");
            Gallery.IsDeactive = false;
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");

        }
    }
}
