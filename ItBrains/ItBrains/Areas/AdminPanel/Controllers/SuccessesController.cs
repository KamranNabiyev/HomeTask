
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

    public class SuccessesController : Controller
    {
        private readonly AppDbContext _db;
        private readonly IWebHostEnvironment _env;
        public SuccessesController(AppDbContext db, IWebHostEnvironment env)
        {
            _db = db;
            _env = env;
        }
        public async Task<IActionResult> Index()
        {
            List<Success> successes = await _db.Successes.ToListAsync();
            return View(successes);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Success success)
        {
            if (success.Photo == null)
            {
                ModelState.AddModelError("Photo", "Sekil secin");
                return View();
            }
            if (!success.Photo.IsImage())
            {
                ModelState.AddModelError("Photo", "Sekil secin");
                return View();
            }
            string folder = Path.Combine("src", "img", "certificates");
            success.Image = await Extension.SaveImageAsync(success.Photo, _env.WebRootPath, folder);

            //****************         Save New Image      **************************
            await _db.Successes.AddAsync(success);
            await _db.SaveChangesAsync();


            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Update(int? id)
        {
            if (id == null)
                return View("Error");
            Success success = await _db.Successes.FirstOrDefaultAsync(x => x.Id == id);
            if (success == null)
                return NotFound();
            return View(success);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? id, Success success)
        {
            if (id == null)
                return View("Error");
            Success dbSuccess = await _db.Successes.FirstOrDefaultAsync(x => x.Id == id);
            if (dbSuccess == null)
                return NotFound();

            if (success.Photo != null)
            {
                if (!success.Photo.IsImage())
                {
                    ModelState.AddModelError("Photo", "Sekil secin");
                    return View();
                }
                string folder = Path.Combine("src", "img", "certificates");
                dbSuccess.Image = await Extension.SaveImageAsync(success.Photo, _env.WebRootPath, folder);
            }

            dbSuccess.Who = success.Who;
            dbSuccess.Position = success.Position;
            dbSuccess.By = success.By;

            await _db.SaveChangesAsync();

            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
                return View("Error");
            Success success = await _db.Successes.FirstOrDefaultAsync(x => x.Id == id);
            if (success == null)
                return View("Error");
            success.IsDeactive = true;
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Activate(int? id)
        {
            if (id == null)
                return View("Error");
            Success success = await _db.Successes.FirstOrDefaultAsync(x => x.Id == id);
            if (success == null)
                return View("Error");
            success.IsDeactive = false;
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");

        }
    }
}
