using ItBrains.Areas.AdminPanel.Utils;
using ItBrains.DAL;
using ItBrains.Extensions;
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
    public class About2Controller : Controller
    {
        private readonly AppDbContext _db;
        private readonly IWebHostEnvironment _env;

        public About2Controller(AppDbContext db, IWebHostEnvironment env)
        {
            _db = db;
            _env = env;
        }
        public IActionResult Index()
        {
            About2 about = _db.Abouts2.Where(x => !x.IsDeactive).FirstOrDefault();
            return View(about);
        }

        #region Update
        public async Task<IActionResult> Update(int? id)
        {
            if (id == null)
                return View("Error");

            About2 dbAbout = await _db.Abouts2.Where(x => x.IsDeactive == false).FirstOrDefaultAsync(y => y.Id == id);

            if (dbAbout == null)
                return View("Error");

            return View(dbAbout);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? id, About2 about, string imgCropped)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            var dbAbout = await _db.Abouts2.Where(x => x.IsDeactive == false).FirstOrDefaultAsync(y => y.Id == id);

            if (dbAbout == null)
                return View("Error");

            if (imgCropped != null)
            {
                string folder = Path.Combine("src", "img");
                string fullPath = Path.Combine(_env.WebRootPath, folder, dbAbout.Image);
                //****************         Delete Old Image      **************************
                Helper.DeleteImage(fullPath);

                //****************         Save New Image      **************************
                dbAbout.Image = Helper.UploadImage(imgCropped, _env.WebRootPath, folder);
            }

            dbAbout.AzDescription = about.AzDescription;
            dbAbout.EnDescription = about.EnDescription;
            dbAbout.RuDescription = about.RuDescription;

            await _db.SaveChangesAsync();

            return RedirectToAction("Index");
        }

        #endregion

        #region Detail
        public IActionResult Detail(int? id)
        {
            if (id == null)
                return View("Error");

            About2 about = _db.Abouts2.Where(x => x.IsDeactive == false).FirstOrDefault(y => y.Id == id);

            if (about == null)
                return View("Error");

            return View(about);
        }
        #endregion
    }
}
