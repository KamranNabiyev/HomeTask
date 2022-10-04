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

    public class GraduatedOpinionController : Controller
    {
        private readonly AppDbContext _db;
        private readonly IWebHostEnvironment _env;
        public GraduatedOpinionController(AppDbContext db, IWebHostEnvironment env)
        {
            _db = db;
            _env = env;
        }
        public async Task<IActionResult> Index()
        {
            List<GraduatedOpinion> graduatedOpinions = await _db.GraduatedOpinions.ToListAsync();
            return View(graduatedOpinions);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(string imgCropped, GraduatedOpinion graduatedOpinio)
        {

            if (imgCropped == null)
            {
                ModelState.AddModelError("", "Zəhmət olmasa şəkil seçin !");
                return View();
            }
            string folder = Path.Combine("src", "img","students");

            //****************         Save New Image      **************************
            graduatedOpinio.Image = Helper.UploadImage(imgCropped, _env.WebRootPath, folder);
            await _db.GraduatedOpinions.AddAsync(graduatedOpinio);
            await _db.SaveChangesAsync();


            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Update(int? id)
        {
            if (id == null)
                return View("Error");
            GraduatedOpinion graduatedOpinion = await _db.GraduatedOpinions.FirstOrDefaultAsync(x => x.Id == id);
            if (graduatedOpinion == null)
                return NotFound(graduatedOpinion);
            return View(graduatedOpinion);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? id, GraduatedOpinion graduatedOpinion, string imgCropped)
        {
            if (id == null)
                return View("Error");
            GraduatedOpinion dbGraduatedOpinion = await _db.GraduatedOpinions.FirstOrDefaultAsync(x => x.Id == id);
            if (graduatedOpinion == null)
                return View("Error");

            if (imgCropped != null)
            {
                string folder = Path.Combine("src", "img","students");
                string fullPath = Path.Combine(_env.WebRootPath, folder, dbGraduatedOpinion.Image);
                //****************         Delete Old Image      **************************
                Helper.DeleteImage(fullPath);

                //****************         Save New Image      **************************
                dbGraduatedOpinion.Image = Helper.UploadImage(imgCropped, _env.WebRootPath, folder);
            }
            dbGraduatedOpinion.Fullname = graduatedOpinion.Fullname;
            dbGraduatedOpinion.Field = graduatedOpinion.Field;
            dbGraduatedOpinion.AzDescription = graduatedOpinion.AzDescription;
            dbGraduatedOpinion.EnDescription = graduatedOpinion.EnDescription;
            dbGraduatedOpinion.RuDescription = graduatedOpinion.RuDescription;

            await _db.SaveChangesAsync();

            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
                return View("Error");
            GraduatedOpinion graduatedOpinion = await _db.GraduatedOpinions.FirstOrDefaultAsync(x => x.Id == id);
            if (graduatedOpinion == null)
                return View("Error");
            graduatedOpinion.IsDeactive = true;
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Activate(int? id)
        {
            if (id == null)
                return View("Error");
            GraduatedOpinion graduatedOpinion = await _db.GraduatedOpinions.FirstOrDefaultAsync(x => x.Id == id);
            if (graduatedOpinion == null)
                return View("Error");
            graduatedOpinion.IsDeactive = false;
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");

        }
    }
}
