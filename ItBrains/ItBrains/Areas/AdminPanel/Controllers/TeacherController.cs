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

    public class TeacherController : Controller
    {
        private readonly AppDbContext _db;
        private readonly IWebHostEnvironment _env;
        public TeacherController(AppDbContext db, IWebHostEnvironment env)
        {
            _db = db;
            _env = env;
        }
        public async Task<IActionResult> Index()
        {
            List<Teacher> Teachers = await _db.Teachers.ToListAsync();
            return View(Teachers);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(string imgCropped, Teacher teacher)
        {

            if (imgCropped == null)
            {
                ModelState.AddModelError("", "Zəhmət olmasa şəkil seçin !");
                return View();
            }
            string folder = Path.Combine("src", "img", "teachers");

            //****************         Save New Image      **************************
            teacher.Image = Helper.UploadImage(imgCropped, _env.WebRootPath, folder);
            await _db.Teachers.AddAsync(teacher);
            await _db.SaveChangesAsync();


            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Update(int? id)
        {
            if (id == null)
                return View("Error");
            Teacher Teacher = await _db.Teachers.FirstOrDefaultAsync(x => x.Id == id);
            if (Teacher == null)
                return NotFound(Teacher);
            return View(Teacher);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? id, Teacher Teacher, string imgCropped)
        {
            if (id == null)
                return View("Error");
            Teacher dbTeacher = await _db.Teachers.FirstOrDefaultAsync(x => x.Id == id);
            if (Teacher == null)
                return View("Error");

            if (imgCropped != null)
            {
                string folder = Path.Combine("src", "img", "teachers");
                string fullPath = Path.Combine(_env.WebRootPath, folder, dbTeacher.Image);
                //****************         Delete Old Image      **************************
                Helper.DeleteImage(fullPath);

                //****************         Save New Image      **************************
                dbTeacher.Image = Helper.UploadImage(imgCropped, _env.WebRootPath, folder);
            }
            dbTeacher.Fullname = Teacher.Fullname;
            dbTeacher.Field = Teacher.Field;

            await _db.SaveChangesAsync();

            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
                return View("Error");
            Teacher Teacher = await _db.Teachers.FirstOrDefaultAsync(x => x.Id == id);
            if (Teacher == null)
                return View("Error");
            Teacher.IsDeactive = true;
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Activate(int? id)
        {
            if (id == null)
                return View("Error");
            Teacher Teacher = await _db.Teachers.FirstOrDefaultAsync(x => x.Id == id);
            if (Teacher == null)
                return View("Error");
            Teacher.IsDeactive = false;
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");

        }
    }
}
